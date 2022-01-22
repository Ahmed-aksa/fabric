using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BaseModel
    {
        public Nullable<int> CreatedBy { set; get; }
        public Nullable<DateTime> CreatedAt { set; get; }
        public Nullable<int> UpdatedBy { set; get; }
        public Nullable<DateTime> UpdateAt { set; get; }
        public bool ISDeleted { set; get; }
    }
}
