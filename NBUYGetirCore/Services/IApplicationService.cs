using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Services
{
    public interface IApplicationService<TRequestDto, TResultDto>
    {

        /// <summary>
        /// Frontend tarafından gelen bir isteğin işlenip frontend tarfına bir sonucun döndürülmesi için yaptık. Api de Input Model ve View Model yerine artık Dto (Data transfer object) terimini kullanacağız. Buradaki servisi Application katmanı için yazıyoruz.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<TResultDto> HandleAsync(TRequestDto dto);
    }
}
