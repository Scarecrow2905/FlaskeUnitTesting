using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskeUnitTesting
{
    public class Operation
    {
        public static string[] operationNames = new[]
        {
            "Fylle flaske 1 fra springen",
            "Fylle flaske 2 fra springen",
            "Tømme flaske 1 i flaske 2",
            "Tømme flaske 2 i flaske 1",
            "Fylle opp flaske 2 med flaske 1",
            "Fylle opp flaske 1 med flaske 2",
            "Tømme flaske 1 (kaste vannet)",
            "Tømme flaske 2 (kaste vannet)",
        };

        public int OperationIndex { get; }

        public Operation(int operationIndex)
        {
            OperationIndex = operationIndex;
        }

        public string GetName()
        {
            return operationNames[OperationIndex];
        }
    }
}

