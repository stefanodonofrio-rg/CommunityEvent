using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLocalTypesExample
{
    file class ImplementationOverride : IOverride
    {
        public void Test()
        {
            throw new NotImplementedException();
        }
    }
    
    public interface IOverride
    {
        void Test();
    }
}
