using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Notification
{
    public class EmailAttachement
    {
        public string Url { get; set; }

        /// <summary>
        /// Base 64 formatında veri (resim excel word vs dosyası olabilir.).
        /// </summary>
        public string Base64 { get; set; }

        /// <summary>
        /// dosya byte[] olarakta email saf halde gönderilebilir.
        /// </summary>
        public byte[] File { get; set; }


    }
    public interface IEmailService
    {
        /// <summary>
        /// E-posta atma ilemleri için bu servisi kullanacağız
        /// </summary>
        /// <param name="to">Aralarında  , olarak tek bir string ile birden fazla kişiye mail atılabilir. (mertalp@gmail.com, rb@gmail.com)  </param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <param name="cc"></param>
        /// <param name="emailAttachements"></param>
        /// <returns></returns>
        Task SendEmailAsync(string to, string subject, string message, string cc, List<EmailAttachement> emailAttachements);


        
    }
}
