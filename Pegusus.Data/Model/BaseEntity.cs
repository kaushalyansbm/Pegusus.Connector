namespace Pegusus.Data.Model
{
    using System;
    public class BaseEntity:IBaseEntity
    {
        public int Id { get; set; }
        public bool isActive { get; set; }

        public bool isDeleted { get; set; }

        public DateTime AddedDateTime { get; set; }
    }
}