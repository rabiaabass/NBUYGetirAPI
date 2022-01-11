using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Authorization
{
    /// <summary>
    /// bu servis ile sistemdeki kullanıcının ilgili kaynağa erişimine yetkisi olup olmadığını kontrol edeceğiz. Clain ve Role bazlı kontrolleri içerisinde yapacağız
    /// </summary>
    public interface IAuthorizationService
    {
        bool HasRole(string roleName);
        bool HasRoles(params string[] roleNames);

        bool HasClaim(string claim);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clains"></param>
        /// <returns></returns>
        bool HasClains(params string[] clains);





    }
}
