using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Authentication
{
    public class AuthenticationError
    {
        public string Code { get; set; }
        public string  Message { get; set; } 
        public string Key { get; set; } //userNAme

    }
    public class AuthenticationResult
    {
        public bool IsSucceded { get; set; }
        public string AccessToken { get; private set; }

        public List<AuthenticationError> Errors { get; set; }

        void AddError(AuthenticationError error)
        {
            IsSucceded = false;
            Errors.Add(error);

            
           
        }
        void SetAccessToken(string token)
        {
            if (IsSucceded)
            {
                AccessToken = token;
            }
        }


    }
    public interface IAuthentication
    {
        /// <summary>
        /// Login olduktan sonra remember me true olursa bu token 1 aylık bir token olsun diğer türlü 1 günlğk token oluşturacağız
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="rememberMe"></param>
        /// <returns></returns>
        AuthenticationResult Login(string email, string password, bool rememberMe);
        void LogOut(string accessToken); //kullanıcıya giriş işlemleri için verilen accessToken expire edeceğiz. artık bu access token geçersiz olacak. Kullanıcının sistemden güvenli çıkışı için var.


    }
}
