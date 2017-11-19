namespace StateOfObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? Town_Id { get; set; }

        public virtual Town Town { get; set; }
    }
}
