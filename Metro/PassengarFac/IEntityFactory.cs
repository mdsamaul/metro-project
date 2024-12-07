using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.PassengarFac
{
    public interface IEntityFactory 
    {
        IEntity CreateEntity();
    }
}
