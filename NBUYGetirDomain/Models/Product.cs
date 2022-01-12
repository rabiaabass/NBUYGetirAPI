using NBUYGetirCommon.URL;
using NBUYGetirCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirDomain.Models

{
    public class Product
    {


        public string Name { get; private set; }

        public decimal UnitPrice { get; private set; } // alış fiyatı

        public double DiscountAmount { get; private set; } = 0;


        //Bu alan sadece program tarfında tutulacak. Veri tabanında tutulmayacak.
        public decimal DiscountListPrice { get; private set; } //indirimli fiyat

        public decimal ListPrice { get; private set; } //satış fiyatı

        public int Stock { get; set; } //current stock

        public string Description { get; set; } // 1lt 30cc 5oml

        public string PictureBase64 { get; private set; }

        public string PictureUrl { get; set; }

        public bool IsDiscounted
        {
            get
            {
                return DiscountListPrice < ListPrice ? true : false;
            }
        }

        /// <summary>
        /// stok kritik seviyede....
        /// </summary>
        public bool IsStockInCriticalLevel
        {
            get
            {
                return Stock < 10 ? true : false;
            }
        }

        public Product(string name, decimal unitPrice, double discountAmount, decimal listPrice, int stock, string description, string pictureBase64, string pictureUrl, decimal discountListPrice)
        {
            SetName(name);
            SetPrice(unitPrice, listPrice, discountListPrice);
            SetDescription(description);
            SetStock(stock);
            SetPictureUrl(pictureUrl);
        }

        public void SetPictureUrl(string pictureUrl)
        {
            if (!UrlHelper.ISUrl(pictureUrl))
            {
                throw new Exception("resim yolu url formatında olamlı");
            }

            if (string.IsNullOrEmpty(pictureUrl))
            {
                pictureUrl = "default-product.jpeg";
            }

            else
            {
                PictureUrl = pictureUrl.Trim();
            }
        }

        public void SetStock(int stock)
        {
            if (stock < 0)
            {
                throw new Exception("stok değeri sıfırdan küçük olamaz. ");

            }
            Stock = stock;
        }

        /// <summary>
        /// stoklama işlemi, ürünün envantere girilmesi işlemi
        /// </summary>
        public void StockIn(int quantity)
        {
            if (quantity < 0)
            {
                throw new Exception("stoğa girilecek yeni ürün adeti 0 ve daha düşük olamaz");
            }
            Stock += quantity;
        }

        public void StockOut(int quantity)
        {
            if (quantity < 0)
            {
                throw new Exception("0 dan küçük değer stoktan düşülmez");
            }

            if (!IsStockInCriticalLevel)
            {
                // kritik stok seviyesindeki bir ürün sipariş edildi diye bir mesaj atalım
            }

            if (quantity > Stock)
            {
                //hatalı kayıt gönderme işlemi
            }

            Stock -= quantity;
        }
        public void SetDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new Exception("ürün açıklaması giriniz");
            }
            if (description.Length > 50)
            {
                throw new Exception("max 50 karakter girebilirsiniz");
            }
            Description = description.Trim();
        }
        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("ürün ismi boş geçilemez !");

            }

            Name = name.Trim();
        }


        /// <summary>
        /// Ürüne ait fiyatların değişimini bu method ile yapacağız.
        /// </summary>
        /// <param name="unitPrice"></param>
        /// <param name="listPrice"></param>
        /// <param name="discountListPrice"></param>
        private void SetPrice(decimal unitPrice, decimal listPrice, decimal discountListPrice)
        {
            if (unitPrice > listPrice)
            {
                throw new Exception("birim fiyat liste fiyatından büyük olamaz.");
            }
            if (unitPrice <= 0 || listPrice <= 0 || discountListPrice <= 0)
            {
                throw new Exception("ürün birim fiyatı veya ürün satış fiyatı veya indirimli satış fiyatı negatif ve 0 verilemez");
            }
            if (discountListPrice > listPrice)
            {
                throw new Exception("indirimli satış fiyatı satış fiyatından büyük olamaz");
            }
            if (discountListPrice < unitPrice)
            {
                throw new Exception("indirimli satış fiyatı birim fiyattan küçük olamaz ");
            }

            ListPrice = listPrice;
            UnitPrice = unitPrice;
        }

        private void DecreasePrice(decimal newPrice)
        {
            if (newPrice > ListPrice)
            {
                throw new Exception("indirimli fiyat liste fıyatından fazla olamaz");
            }

            if (newPrice <= UnitPrice)
            {
                throw new Exception("indirimli fiyat birim fiyatından küçük olamaz");
            }

            DiscountListPrice = newPrice;

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="newListPrice"></param>
        /// <param name="discountedNewListPrice"></param>
        public void IncreasePrice(decimal newListPrice, decimal discountedNewListPrice)
        {

            //yeni satış fiyatı  newListPrice
            // yeni indirimli satış fiyatı    discountedNewListPrice

            if (newListPrice < ListPrice)
            {
                throw new Exception("ürünün liste fiyatı yeni fiyattan büyük girilemez.");
            }

            if (discountedNewListPrice > newListPrice)
            {
                throw new Exception("indirimli fiyat liste fiyatından büyük olamaz");
            }

            ListPrice = newListPrice;
        }

    }
}