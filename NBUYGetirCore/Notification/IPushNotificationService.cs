using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Notification
{
    public interface IPushNotificationService
    {
        /// <summary>
        /// Mobil uygulamayı bir kullanıcı indirince user hesabında DeviceId tutacağız. One Signal ile kullanıcının telefonuna bildirim göndreceğiz.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task SendPushNotificationAsync(string deviceId, string message);
    }
}
