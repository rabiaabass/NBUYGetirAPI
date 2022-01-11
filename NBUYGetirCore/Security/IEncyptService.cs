using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Security
{
    public interface IEncyptService
    {
        /// <summary>
        /// MD5 ile veya SHA, DES, 3DES gibi algoritmalar ile şifreleme işlemleri yapan bir servis olarak kullanılabilir. MD5 hash algoritması geriye çevrilemez.
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        string chiperText(string plainText);
    }
}
