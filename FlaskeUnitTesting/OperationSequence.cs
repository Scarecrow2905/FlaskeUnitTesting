using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskeUnitTesting
{
    public class OperationSequence
    {
        private Operation[] _operations;

        public static bool UpdateOperations(int[] operations)
        {
            int i;
            for (i = operations.Length - 1; i >= 0; i--)
            {
                if (operations[i] < 7)
                {
                    operations[i]++;
                    break;
                }
                operations[i] = 0;
            }
            return i != -1;
        }
    }
}
