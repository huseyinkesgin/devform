using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.ORMS
{
    public interface IEntity
    {
        public bool Deleted { get; set; }
    }
}
