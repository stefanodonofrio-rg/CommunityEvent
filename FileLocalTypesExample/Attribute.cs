using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLocalTypesExample
{
    file class MyFileLocalAttribute : Attribute { }

    [MyFileLocal]
    internal class ClassWithAttribute
    {
    }
}
