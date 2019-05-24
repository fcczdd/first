using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel.Entities
{
   public abstract class BaseModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool is_delete { get; set; } = false;
       // public 
    }
}
