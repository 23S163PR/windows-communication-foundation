using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace calculator_service
{
    [ServiceContract(Namespace="http://itstep.org/CalculatorSerice/V1")]
    public interface ICalculatorService
    {
        [OperationContract]
        [FaultContract(typeof(InvalidArguments))]
        int GetPythons(int parrotsCount);
        [OperationContract]
        [FaultContract(typeof(InvalidArguments))]
        int GetParrots(int pythonsCount);
    }

    [ServiceContract(Namespace = "http://itstep.org/CalculatorSerice/V2")]
    public interface ICalculatorService2 : ICalculatorService
    {
        [OperationContract(Name = "GetFloatingPointPythons")]
        [FaultContract(typeof(InvalidArguments))]
        double GetPythons(double parrotsCount);
        [OperationContract(Name = "GetFloatingPointParrots")]
        [FaultContract(typeof(InvalidArguments))]
        double GetParrots(double pythonsCount);
    }

    [DataContract]
    public class InvalidArguments
    {
        [DataMember]
        public string ArgumentName { get; set; }
        [DataMember]
        public string ProblemDescription { get; set; }
    }
}
