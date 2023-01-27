using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTips.Console
{
    internal class KeepOriginalExceptionTrace
    {
        private void DoOperation()
        {
            throw new Exception("Exception occured at RunOperationWithException");
        }

        public void RunOperationWithException()
        {
            try
            {
                DoOperation();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RunOperationWithOriginalTrace()
        {
            try
            {
                DoOperation();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
