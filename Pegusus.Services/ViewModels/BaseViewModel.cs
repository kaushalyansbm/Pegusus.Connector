using System;
using System.Collections.Generic;
using System.Text;

namespace Pegusus.Services.ViewModels
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public bool isActive { get; set; }

        public bool isDeleted { get; set; }

        public DateTime AddedDateTime { get; set; }
    }
}
