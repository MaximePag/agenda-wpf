namespace AgendaWPF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class af458_customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public af458_customers()
        {
            af458_appointments = new HashSet<af458_appointments>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string lastname { get; set; }

        [Required]
        [StringLength(50)]
        public string firstname { get; set; }

        [Required]
        [StringLength(255)]
        public string mail { get; set; }

        [Required]
        [StringLength(10)]
        public string phoneNumber { get; set; }

        public int budget { get; set; }

        public int id_af458_brokers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<af458_appointments> af458_appointments { get; set; }

        public virtual af458_brokers af458_brokers { get; set; }
    }
}
