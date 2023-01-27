using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTips.Console
{
    public enum SimpleEnum
    {
        None = 0,
        Red = 1,
        Yellow = 2,
        Green = 4,
        Black = 8,
    }

    [Flags]
    public enum SimpleEnumWithFlag
    {
        None = 0,
        Red = 1,
        Yellow = 2,
        Green = 4,
        Black = 8,
    }
}
