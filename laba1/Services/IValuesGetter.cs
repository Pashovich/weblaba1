using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laba1.Services
{
    public interface IValuesGetter
    {
        int getFirst();
        int getSecond();
        Dictionary<string, string> getOperationsValues();
    }
}
