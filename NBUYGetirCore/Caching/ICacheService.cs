using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Caching
{

    public class CacheData<T>
    {
        public string Key { get; set; } //cachelenecek veri için bir key değeri tutuyoruz, bu key değeri üzerinden bu Data bilgimize ulaşacağız.
        public List<T> Data { get; set; } // Liste halinde json[] olarak buraya data set edeceğiz
    }

    /// <summary>
    /// çok fazla insert update işlemi olmayan verilerimiz için cache mekanizmasını kullanırız.
    /// </summary>
    /// <typeparam name="TObject"></typeparam>
    public interface ICacheService<TResult> where TResult:class
    {
        /// <summary>
        /// veriyi Ramde tutarken key bilgisi üzerinden sistemde tutacağız.
        /// </summary>
        /// <param name="cacheData"></param>
        void SetCache(TResult cacheData, string key);

        /// <summary>
        /// ilgili Ramde cachedeki dataya set ederken verdiğimiz key üzerinden erişim json formatında deserialize edilmiş veriye ulaşacağız.
        /// </summary>
        /// <returns></returns>
        TResult GetFromCache(string key);
    }
}
