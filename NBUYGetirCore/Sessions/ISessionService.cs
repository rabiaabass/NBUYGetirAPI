using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Sessions
{
    /// <summary>
    /// kullanıcıya ait sepet bilgileri, sipariş işlemleri sırasında Session da saklanacak, bunun gibi oturum bazlı veri saklama durumlarımız için bu servisi kullancağız.
    /// </summary>
    public interface ISessionService<TObject> where TObject:class
    {
        void Add(TObject @object, string key); // key value cinsinden ramde oturum bilgisini object olarak tutmak için kullanacağız.
        void Remove(string key); //ilgili session bilgisini ramden kaldırmak için kullanacağız.

        /// <summary>
        /// RAm de oturum bazlı saklanan değer
        /// </summary>
        TObject GetSesion(string key);
    }
}
