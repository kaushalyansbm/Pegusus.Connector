namespace Pegusus.Data.Model
{
    using System;
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime AddedDateTime { get; set; }
    }
}