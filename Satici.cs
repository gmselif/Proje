namespace Product
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satici
    {
        public int saticiID { get; set; }

        public string sName { get; set; }

        public string Password { get; set; }
    }
}
