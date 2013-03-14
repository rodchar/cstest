using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ILearning
    {
        string CurrentValue { get; }
        string Next();
        string Previous();
        void Reset();
    }
}
