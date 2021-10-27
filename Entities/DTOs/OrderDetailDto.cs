using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class OrderDetailDto : IDto
    {
        public string MailAdress { get; set; }
        public string ProductName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
