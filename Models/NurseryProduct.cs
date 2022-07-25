using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryExample3.Models
{
    public class NurseryProduct
    {
        public int Id { get; set; }
        //[Index("IX_First", IsUnique = true)]
        public int SKU_NO { get; set; }

        public string IsAvailable { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public NurseryCategory NurseryCategory { get; set; }
        //adding foreign key constraint
        public int NurseryCategoryId { get; set; }

        //adding unique key constarint
    }
}