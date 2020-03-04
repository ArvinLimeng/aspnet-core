using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACore.PhoneBook.Dto
{
    public class PagedAndSortedInputDto:IPagedAndSortedResultRequest,ISortedResultRequest
    {
        public string Sorting { get; set; }

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        [Range(1,500)]  //每页最多显示500条
        public int MaxResultCount { get; set; }
    }
}
