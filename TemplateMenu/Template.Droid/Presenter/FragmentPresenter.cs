using System;
using System.Collections.Generic;
using Android.Content;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Core.ViewModels;
using System.Reflection;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;

namespace TemplateMenu.Droid.Presenter
{
    public class FragmentPresenter
        : MvxAndroidViewPresenter
    {
        public const string ViewModelRequestBundleKey = "__mvxViewModelRequest";

        private readonly FragmentHostRegistrationSettings _fragmentHostRegistrationSettings;
        private readonly Lazy<IMvxNavigationSerializer> _lazyNavigationSerializerFactory;

        protected IMvxNavigationSerializer Serializer => _lazyNavigationSerializerFactory.Value;

        public FragmentPresenter(IEnumerable<Assembly> AndroidViewAssemblies)
        {
            _lazyNavigationSerializerFactory = new Lazy<IMvxNavigationSerializer>(Mvx.Resolve<IMvxNavigationSerializer>);
            _fragmentHostRegistrationSettings = new FragmentHostRegistrationSettings(AndroidViewAssemblies);
        }

        public sealed override void Show(MvxViewModelRequest request)
        {
            if (_fragmentHostRegistrationSettings.IsTypeRegisteredAsFragment(request.ViewModelType))
                ShowFragment(request);
            else
                ShowActivity(request);
        }

        protected virtual void ShowActivity(MvxViewModelRequest request, MvxViewModelRequest fragmentRequest = null)
        {
            if (fragmentRequest == null)
            {
                if (request != null && request.PresentationValues != null)
                {
                    var intent = base.CreateIntentForRequest(request);

                    //if (request.PresentationValues.ContainsKey(NavigationMode.Root.ToString()))
                    //    intent.SetFlags(ActivityFlags.ClearTask | ActivityFlags.NewTask);
                    //else if (request.PresentationValues.ContainsKey(NavigationMode.Replace.ToString()))
                        intent.SetFlags(ActivityFlags.TaskOnHome | ActivityFlags.NewTask);

                    base.Show(intent);
                }
                else
                    base.Show(request);
            }
            else
                Show(request, fragmentRequest);
        }

        public void Show(MvxViewModelRequest request, MvxViewModelRequest fragmentRequest)
        {
            var intent = CreateIntentForRequest(request);
            if (fragmentRequest != null)
            {
                var converter = Mvx.Resolve<IMvxNavigationSerializer>();
                var requestText = converter.Serializer.SerializeObject(fragmentRequest);
                intent.PutExtra(ViewModelRequestBundleKey, requestText);
            }

            Show(intent);
        }

        protected virtual void ShowFragment(MvxViewModelRequest request)
        {
            var bundle = new Bundle();
            var serializedRequest = Serializer.Serializer.SerializeObject(request);
            bundle.PutString(ViewModelRequestBundleKey, serializedRequest);

            if (!_fragmentHostRegistrationSettings.IsActualHostValid(request.ViewModelType))
            {
                Type newFragmentHostViewModelType =
                    _fragmentHostRegistrationSettings.GetFragmentHostViewModelType(request.ViewModelType);

                var fragmentHostMvxViewModelRequest = MvxViewModelRequest.GetDefaultRequest(newFragmentHostViewModelType);
                ShowActivity(fragmentHostMvxViewModelRequest, request);
                return;
            }

            var mvxFragmentAttributeAssociated = _fragmentHostRegistrationSettings.GetMvxFragmentAttributeAssociatedWithCurrentHost(request.ViewModelType);
            var fragmentType = _fragmentHostRegistrationSettings.GetFragmentTypeAssociatedWith(request.ViewModelType);
            GetActualFragmentHost().Show(request, bundle, fragmentType, mvxFragmentAttributeAssociated);
        }

        public sealed override void Close(IMvxViewModel viewModel)
        {
            if (_fragmentHostRegistrationSettings.IsTypeRegisteredAsFragment(viewModel.GetType()))
                CloseFragment(viewModel);
            else
                CloseActivity(viewModel);
        }

        protected virtual void CloseActivity(IMvxViewModel viewModel)
        {
            base.Close(viewModel);
        }

        protected virtual void CloseFragment(IMvxViewModel viewModel)
        {
            GetActualFragmentHost().Close(viewModel);
        }

        protected IMvxFragmentHost GetActualFragmentHost()
        {
            var currentActivity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
            var fragmentHost = currentActivity as IMvxFragmentHost;

            if (fragmentHost == null)
                throw new InvalidOperationException($"You are trying to close ViewModel associated with Fragment when currently top Activity ({currentActivity.GetType()} does not implement IMvxFragmentHost interface!");

            return fragmentHost;
        }
    }
}