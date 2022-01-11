using NBUYGetirCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NBUYGetirDomain.Models
{
    public class Category: Entity
    {
        public string Name { get; set; }

        /// <summary>
        /// ekranda ilk açılışta....
        /// </summary>
        public bool IsTopLevel { get; set; } //en üst seviye kategori mi
        public List<Product> _products { get; set; }

        public List<Category> _subCategories = new List<Category>();

        public IReadOnlyCollection<Category> SubCategories => _subCategories;
        public IReadOnlyCollection<Product> Products => _products;

        public void AddSubCategory(Category category)
        {
            if (string.IsNullOrEmpty(category.Name))
            {
                throw new Exception("kategori ismi boş geçilemez");
            }
            _subCategories.Add(category);
        }

        public void AddProduct(Product product)
        {
            if (!IsTopLevel && _subCategories.Count() == 0)
            {
                _products.Add(product);
            }
        }


    }
}
