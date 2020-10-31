﻿namespace Pegusus.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class BaseEntity:IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime AddedDateTime { get; set; }
    }
}