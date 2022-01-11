using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Authentication
{
    public class TokenClain
    {
        public string ClainType { get; set; } // username, role
        public string ClainValue { get; set; } // rabia, admin

    }
    public class TokenModel
    {
        public string AccessToken { get; set; } // base64 formatında token bilgisi
        public DateTime ExpireDate { get; set; } // token ne zaman expire olacağı bilgisi

    }

    /// <summary>
    /// belirli bir süreliğine access token üretmek için bu servisi kullanacağız
    /// tokenda taşınacak bilgiler için tokenClain adında bir sınıf kullanacağız. Key value olarak tokenda bilgi saklayacağız.
    /// token model ise kullanıcının access token ve bu token geçerlilik süresi için açtığımız model
    /// </summary>
    public interface ITokenService
    {
        /// <summary>
        /// sisteme giriş yapacak kullanıcılar için erişim bileti access token oluşturacağız.
        /// </summary>
        /// <param name="clains"></param>
        /// <returns></returns>
        TokenModel CreateAccessToken(List<TokenClain> clains);
        /// <summary>
        /// Login işleminde bu tokenin bir daha bu kullanıcı tarafından kullanılmamsı için var. 
        /// </summary>
        /// <param name="token"></param>
        void RevokeAccessToken(string token); 
    }
}
