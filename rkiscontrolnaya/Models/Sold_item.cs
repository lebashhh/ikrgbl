namespace ikrgbl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sold_item
    {
        public int ID { get; set; }

        public int? ID_Good { get; set; }

        public int? ID_Worker { get; set; }

        public DateTime? Date_of_sale { get; set; }

        public int? ID_Outlets { get; set; }

        public virtual Goods Goods { get; set; }

        public virtual Workers Workers { get; set; }
    }
}
