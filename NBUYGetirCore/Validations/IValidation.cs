using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Validations
{
    

    public class ValidationErrorResult
    {
        public string Key { get; set; }
        public string ValidationMessage { get; set; }

    }

    public class ValidationResult
    {
        public bool IsValid { get; set; }

        /// <summary>
        /// nesne içerisinde birden fazla hata olması durumu için açıldı.
        /// </summary>
        public List<ValidationErrorResult> Errors { get; set; }

        public void AddError(ValidationErrorResult error)
        {
            Errors.Add(error);
        }
    }
         
    public interface IValidation<TDto> where TDto:class
    {

        ValidationResult ValidationResult { get; set; }
        /// <summary>
        /// valid olup olmadığını görebiliriz.
        /// </summary>
        bool IsValid { get;  }
        /// <summary>
        /// Frontend tarafında gönderilen dtonun validasyon kurallarına uyup uymadığını kontrol ederiz.
        /// </summary>
        /// <param name="dto"></param>
        void Validate(TDto dto);
    }
}
