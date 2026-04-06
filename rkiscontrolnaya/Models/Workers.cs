namespace ikrgbl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Workers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Workers()
        {
            Sold_item = new HashSet<Sold_item>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Login { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(20)]
        public string First_Name { get; set; }

        [StringLength(20)]
        public string Second_Name { get; set; }

        [StringLength(20)]
        public string Middle_Name { get; set; }

        [StringLength(20)]
        public string Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sold_item> Sold_item { get; set; }
    }
}
