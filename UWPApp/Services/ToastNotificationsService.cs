using System;
using System.Threading.Tasks;

using UWPApp.Activation;

using Windows.ApplicationModel.Activation;
using Windows.UI.Notifications;

namespace UWPApp.Services
{
    internal partial class ToastNotificationsService : ActivationHandler<ToastNotificationActivatedEventArgs>
    {
        public void ShowToastNotification(ToastNotification toastNotification)
        {
            try
            {
                ToastNotificationManager.CreateToastNotifier().Show(toastNotification);
            }
            catch (Exception)
            {
                // Handle exceptions.
            }
        }

        protected override async Task HandleInternalAsync(ToastNotificationActivatedEventArgs args)
        {
            //// Handle activation from toast notification
            //// More details at https://docs.microsoft.com/windows/uwp/design/shell/tiles-and-notifications/send-local-toast

            await Task.CompletedTask;
        }
    }
}
