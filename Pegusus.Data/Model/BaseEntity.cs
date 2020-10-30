namespace Pegusus.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class BaseEntity:IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool isActive { get; set; }

        public bool isDeleted { get; set; }

        public DateTime AddedDateTime { get; set; }
    }
}