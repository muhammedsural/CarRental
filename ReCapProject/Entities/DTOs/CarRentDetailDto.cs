using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class CarRentDetailDto:IDto
    {
        public int CarId { get; set; }
        public int RentId { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
