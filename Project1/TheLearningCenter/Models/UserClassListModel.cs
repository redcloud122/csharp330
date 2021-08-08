using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheLearningCenter.Models
{
    public class UserClassListModel
    {
        public int UserId { get; set; }
        public int ClassId { get; set; } = 0;
        public ShortClassListItem[] ClassList { get; set; }
    }
}
