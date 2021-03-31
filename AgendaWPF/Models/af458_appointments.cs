namespace AgendaWPF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class af458_appointments
    {
        public int id { get; set; }

        public DateTime dateHour { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string subject { get; set; }

        public int id_af458_brokers { get; set; }

        public int id_af458_customers { get; set; }

        public virtual af458_brokers af458_brokers { get; set; }

        public virtual af458_customers af458_customers { get; set; }
    }
}
