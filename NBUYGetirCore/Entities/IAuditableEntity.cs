using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Entities
{
    public interface IAuditableEntity
    {
        /// <summary>
        /// hangi tarihte ilk eklendi
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Entity hangi tarihte ilk güncellendi
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// kim tarafından eklendi
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// kim tarafından güncellendi
        /// </summary>
        public string UpdateBy { get; set; }
        

    }
}
