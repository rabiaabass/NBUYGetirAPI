using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Exceptions
{
    public static class ExceptionCodes
    {
        public const string UserNotFound = "1001";
        public const string OrderRejected = "2001";
        public const string AccountDenied = "3001";

    }

    /// <summary>
    /// uygulama içerisinde logic kaynaklı hataları fırlatmak için bu sınıfı kullanacağız.
    /// uygulama içerisinde oluşacak hatalara ExceptionCodes olarak birer kod veriyoruz.
    /// hata mesajı ile hangi kodu aldığımıza dair bişgileri bu sınıftan kalıtım alan sınıflara vereceğiz
    /// böylelikle uygulamada oluşan hataları daha kolay loglayabileceğiz 
    /// exception sınıfı ana hata sınıfı olup kendi hata sınıflarımızda oluşuracağız.
    /// </summary>
    public abstract class ExceptionBase: Exception
    {
        public string ErrorCode { get; private set; }
        public ExceptionBase(string message, string errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
