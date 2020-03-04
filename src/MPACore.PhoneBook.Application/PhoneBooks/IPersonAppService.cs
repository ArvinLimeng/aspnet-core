using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPACore.PhoneBook.Dto;
using MPACore.PhoneBook.PhoneBooks.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MPACore.PhoneBook.PhoneBooks
{
    public interface IPersonAppService:IApplicationService
    {
        /// <summary>
        /// 获取用人的相关信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        /// <summary>
        /// 根据Id获取相关用户信息
        /// </summary>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input);

        /// <summary>
        /// 新增或者更改联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input);

        /// <summary>
        /// 删除联系人信息
        /// </summary>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto input);
    }
}
