using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace calculator_service
{
    [ServiceContract(Namespace="http://itstep.org/CalculatorSerice/V1")]
    public interface ICalculatorService
    {
        [OperationContract]
        int GetPythons(int parrotsCount);
        [OperationContract]
        int GetParrots(int pythonsCount);
    }
}
