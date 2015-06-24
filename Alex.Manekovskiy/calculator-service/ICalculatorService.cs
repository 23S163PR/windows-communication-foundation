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

    [ServiceContract(Namespace = "http://itstep.org/CalculatorSerice/V2")]
    public interface ICalculatorService2 : ICalculatorService
    {
        [OperationContract(Name = "GetFloatingPointPythons")]
        double GetPythons(double parrotsCount);
        [OperationContract(Name = "GetFloatingPointParrots")]
        double GetParrots(double pythonsCount);
    }
}
