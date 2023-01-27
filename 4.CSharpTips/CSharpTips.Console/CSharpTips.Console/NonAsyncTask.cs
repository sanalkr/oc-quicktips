using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTips.Console
{
    public class NonAsyncTask
    {

        public Task<object> GetResult()
        {
            return Task.FromResult<object>(null);
        }

    }
}
