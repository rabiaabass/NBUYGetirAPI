using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Notification
{
    public interface ISMSSender
    {
        /// <summary>
        /// hangi tel nosuna hangi mesajı atacağımızı bu servis ile yapcağız. Twilio diye bir paket kullabacağız.
        /// </summary>
        /// <param name="PhoneNumber"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task SendSMSAsync(string PhoneNumber, string message);

    }
}
