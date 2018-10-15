using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiI2cControlCsharp
{
    public interface ISerialUpdate
    {
        void Update(String message);
    }
}
