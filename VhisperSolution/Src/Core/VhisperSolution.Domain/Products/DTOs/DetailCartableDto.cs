using System;
using System.Collections.Generic;
using System.Text;
using VhisperSolution.Domain.Products.Entities;

namespace VhisperSolution.Domain.Products.DTOs
{
    public class DetailCartableDto
    {
        public DetailCartableDto()
        {

        }
        public DetailCartableDto(DetailCartable detailCartable)
        {
            Title = detailCartable.Title;
            Description = detailCartable.Description;
            IsRead = detailCartable.IsRead;
            CreatedBy = detailCartable.CreatedBy;
            this.SendUserId = detailCartable.CreatedBy;
            this.DateIsRead = detailCartable.DateIsRead;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? DateIsRead { get; set; }
        public Guid SendUserId { get; set; }
    }
}
