﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace calculator_service_client.CalculatorServiceV2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvalidArguments", Namespace="http://schemas.datacontract.org/2004/07/calculator_service")]
    [System.SerializableAttribute()]
    public partial class InvalidArguments : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArgumentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProblemDescriptionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArgumentName {
            get {
                return this.ArgumentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ArgumentNameField, value) != true)) {
                    this.ArgumentNameField = value;
                    this.RaisePropertyChanged("ArgumentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProblemDescription {
            get {
                return this.ProblemDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ProblemDescriptionField, value) != true)) {
                    this.ProblemDescriptionField = value;
                    this.RaisePropertyChanged("ProblemDescription");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://itstep.org/CalculatorSerice/V2", ConfigurationName="CalculatorServiceV2.ICalculatorService2")]
    public interface ICalculatorService2 {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://itstep.org/CalculatorSerice/V1) of message GetPythonsRequest does not match the default value (http://itstep.org/CalculatorSerice/V2)
        [System.ServiceModel.OperationContractAttribute(Action="http://itstep.org/CalculatorSerice/V1/ICalculatorService/GetPythons", ReplyAction="http://itstep.org/CalculatorSerice/V1/ICalculatorService/GetPythonsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(calculator_service_client.CalculatorServiceV2.InvalidArguments), Action="http://itstep.org/CalculatorSerice/V1/ICalculatorService/GetPythonsInvalidArgumen" +
            "tsFault", Name="InvalidArguments", Namespace="http://schemas.datacontract.org/2004/07/calculator_service")]
        calculator_service_client.CalculatorServiceV2.GetPythonsResponse GetPythons(calculator_service_client.CalculatorServiceV2.GetPythonsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://itstep.org/CalculatorSerice/V1/ICalculatorService/GetPythons", ReplyAction="http://itstep.org/CalculatorSerice/V1/ICalculatorService/GetPythonsResponse")]
        System.Threading.Tasks.Task<calculator_service_client.CalculatorServiceV2.GetPythonsResponse> GetPythonsAsync(calculator_service_client.CalculatorServiceV2.GetPythonsRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://itstep.org/CalculatorSerice/V1) of message GetParrotsRequest does not match the default value (http://itstep.org/CalculatorSerice/V2)
        [System.ServiceModel.OperationContractAttribute(Action="http://itstep.org/CalculatorSerice/V1/ICalculatorService/GetParrots", ReplyAction="http://itstep.org/CalculatorSerice/V1/ICalculatorService/GetParrotsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(calculator_service_client.CalculatorServiceV2.InvalidArguments), Action="http://itstep.org/CalculatorSerice/V1/ICalculatorService/GetParrotsInvalidArgumen" +
            "tsFault", Name="InvalidArguments", Namespace="http://schemas.datacontract.org/2004/07/calculator_service")]
        calculator_service_client.CalculatorServiceV2.GetParrotsResponse GetParrots(calculator_service_client.CalculatorServiceV2.GetParrotsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://itstep.org/CalculatorSerice/V1/ICalculatorService/GetParrots", ReplyAction="http://itstep.org/CalculatorSerice/V1/ICalculatorService/GetParrotsResponse")]
        System.Threading.Tasks.Task<calculator_service_client.CalculatorServiceV2.GetParrotsResponse> GetParrotsAsync(calculator_service_client.CalculatorServiceV2.GetParrotsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://itstep.org/CalculatorSerice/V2/ICalculatorService2/GetFloatingPointPythons" +
            "", ReplyAction="http://itstep.org/CalculatorSerice/V2/ICalculatorService2/GetFloatingPointPythons" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(calculator_service_client.CalculatorServiceV2.InvalidArguments), Action="http://itstep.org/CalculatorSerice/V2/ICalculatorService2/GetFloatingPointPythons" +
            "InvalidArgumentsFault", Name="InvalidArguments", Namespace="http://schemas.datacontract.org/2004/07/calculator_service")]
        double GetFloatingPointPythons(double parrotsCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://itstep.org/CalculatorSerice/V2/ICalculatorService2/GetFloatingPointPythons" +
            "", ReplyAction="http://itstep.org/CalculatorSerice/V2/ICalculatorService2/GetFloatingPointPythons" +
            "Response")]
        System.Threading.Tasks.Task<double> GetFloatingPointPythonsAsync(double parrotsCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://itstep.org/CalculatorSerice/V2/ICalculatorService2/GetFloatingPointParrots" +
            "", ReplyAction="http://itstep.org/CalculatorSerice/V2/ICalculatorService2/GetFloatingPointParrots" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(calculator_service_client.CalculatorServiceV2.InvalidArguments), Action="http://itstep.org/CalculatorSerice/V2/ICalculatorService2/GetFloatingPointParrots" +
            "InvalidArgumentsFault", Name="InvalidArguments", Namespace="http://schemas.datacontract.org/2004/07/calculator_service")]
        double GetFloatingPointParrots(double pythonsCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://itstep.org/CalculatorSerice/V2/ICalculatorService2/GetFloatingPointParrots" +
            "", ReplyAction="http://itstep.org/CalculatorSerice/V2/ICalculatorService2/GetFloatingPointParrots" +
            "Response")]
        System.Threading.Tasks.Task<double> GetFloatingPointParrotsAsync(double pythonsCount);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPythons", WrapperNamespace="http://itstep.org/CalculatorSerice/V1", IsWrapped=true)]
    public partial class GetPythonsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://itstep.org/CalculatorSerice/V1", Order=0)]
        public int parrotsCount;
        
        public GetPythonsRequest() {
        }
        
        public GetPythonsRequest(int parrotsCount) {
            this.parrotsCount = parrotsCount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPythonsResponse", WrapperNamespace="http://itstep.org/CalculatorSerice/V1", IsWrapped=true)]
    public partial class GetPythonsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://itstep.org/CalculatorSerice/V1", Order=0)]
        public int GetPythonsResult;
        
        public GetPythonsResponse() {
        }
        
        public GetPythonsResponse(int GetPythonsResult) {
            this.GetPythonsResult = GetPythonsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetParrots", WrapperNamespace="http://itstep.org/CalculatorSerice/V1", IsWrapped=true)]
    public partial class GetParrotsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://itstep.org/CalculatorSerice/V1", Order=0)]
        public int pythonsCount;
        
        public GetParrotsRequest() {
        }
        
        public GetParrotsRequest(int pythonsCount) {
            this.pythonsCount = pythonsCount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetParrotsResponse", WrapperNamespace="http://itstep.org/CalculatorSerice/V1", IsWrapped=true)]
    public partial class GetParrotsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://itstep.org/CalculatorSerice/V1", Order=0)]
        public int GetParrotsResult;
        
        public GetParrotsResponse() {
        }
        
        public GetParrotsResponse(int GetParrotsResult) {
            this.GetParrotsResult = GetParrotsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorService2Channel : calculator_service_client.CalculatorServiceV2.ICalculatorService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorService2Client : System.ServiceModel.ClientBase<calculator_service_client.CalculatorServiceV2.ICalculatorService2>, calculator_service_client.CalculatorServiceV2.ICalculatorService2 {
        
        public CalculatorService2Client() {
        }
        
        public CalculatorService2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorService2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorService2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorService2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        calculator_service_client.CalculatorServiceV2.GetPythonsResponse calculator_service_client.CalculatorServiceV2.ICalculatorService2.GetPythons(calculator_service_client.CalculatorServiceV2.GetPythonsRequest request) {
            return base.Channel.GetPythons(request);
        }
        
        public int GetPythons(int parrotsCount) {
            calculator_service_client.CalculatorServiceV2.GetPythonsRequest inValue = new calculator_service_client.CalculatorServiceV2.GetPythonsRequest();
            inValue.parrotsCount = parrotsCount;
            calculator_service_client.CalculatorServiceV2.GetPythonsResponse retVal = ((calculator_service_client.CalculatorServiceV2.ICalculatorService2)(this)).GetPythons(inValue);
            return retVal.GetPythonsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<calculator_service_client.CalculatorServiceV2.GetPythonsResponse> calculator_service_client.CalculatorServiceV2.ICalculatorService2.GetPythonsAsync(calculator_service_client.CalculatorServiceV2.GetPythonsRequest request) {
            return base.Channel.GetPythonsAsync(request);
        }
        
        public System.Threading.Tasks.Task<calculator_service_client.CalculatorServiceV2.GetPythonsResponse> GetPythonsAsync(int parrotsCount) {
            calculator_service_client.CalculatorServiceV2.GetPythonsRequest inValue = new calculator_service_client.CalculatorServiceV2.GetPythonsRequest();
            inValue.parrotsCount = parrotsCount;
            return ((calculator_service_client.CalculatorServiceV2.ICalculatorService2)(this)).GetPythonsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        calculator_service_client.CalculatorServiceV2.GetParrotsResponse calculator_service_client.CalculatorServiceV2.ICalculatorService2.GetParrots(calculator_service_client.CalculatorServiceV2.GetParrotsRequest request) {
            return base.Channel.GetParrots(request);
        }
        
        public int GetParrots(int pythonsCount) {
            calculator_service_client.CalculatorServiceV2.GetParrotsRequest inValue = new calculator_service_client.CalculatorServiceV2.GetParrotsRequest();
            inValue.pythonsCount = pythonsCount;
            calculator_service_client.CalculatorServiceV2.GetParrotsResponse retVal = ((calculator_service_client.CalculatorServiceV2.ICalculatorService2)(this)).GetParrots(inValue);
            return retVal.GetParrotsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<calculator_service_client.CalculatorServiceV2.GetParrotsResponse> calculator_service_client.CalculatorServiceV2.ICalculatorService2.GetParrotsAsync(calculator_service_client.CalculatorServiceV2.GetParrotsRequest request) {
            return base.Channel.GetParrotsAsync(request);
        }
        
        public System.Threading.Tasks.Task<calculator_service_client.CalculatorServiceV2.GetParrotsResponse> GetParrotsAsync(int pythonsCount) {
            calculator_service_client.CalculatorServiceV2.GetParrotsRequest inValue = new calculator_service_client.CalculatorServiceV2.GetParrotsRequest();
            inValue.pythonsCount = pythonsCount;
            return ((calculator_service_client.CalculatorServiceV2.ICalculatorService2)(this)).GetParrotsAsync(inValue);
        }
        
        public double GetFloatingPointPythons(double parrotsCount) {
            return base.Channel.GetFloatingPointPythons(parrotsCount);
        }
        
        public System.Threading.Tasks.Task<double> GetFloatingPointPythonsAsync(double parrotsCount) {
            return base.Channel.GetFloatingPointPythonsAsync(parrotsCount);
        }
        
        public double GetFloatingPointParrots(double pythonsCount) {
            return base.Channel.GetFloatingPointParrots(pythonsCount);
        }
        
        public System.Threading.Tasks.Task<double> GetFloatingPointParrotsAsync(double pythonsCount) {
            return base.Channel.GetFloatingPointParrotsAsync(pythonsCount);
        }
    }
}
