using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;
using VhisperSolution.Domain.Common;

namespace VhisperSolution.Domain.Products.Entities
{
    public class DetailCartable : AuditableBaseEntity
    {
        private DetailCartable()
        {
            
        }
        public DetailCartable(string title , string description, bool isRead)
        {
            Title = title;
            Description = description;
            IsRead = isRead;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateIsRead { get; set; }
        public Guid SendUserId { get; set; }

        public void Update(string title, string description)
        {
            Title = title ;
            Description = description;
        }

        public void UpdateIsRead()
        {
            IsRead = true;
            this.DateIsRead = DateTime.Now;

        }
    }

    
}
