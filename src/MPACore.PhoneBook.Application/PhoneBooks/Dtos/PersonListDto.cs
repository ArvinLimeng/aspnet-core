using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using MPACore.PhoneBook.PhoneBooks.Persons;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACore.PhoneBook.PhoneBooks.Dtos
{
    [AutoMapFrom(typeof(Person))]
     public class PersonListDto: FullAuditedEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        public string Address { get; set; }
    }
}
