﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Estacionamento.Console.EstacionamentoServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EstacionamentoServiceReference.IEstacionamentoService")]
    public interface IEstacionamentoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamentoService/Checkin", ReplyAction="http://tempuri.org/IEstacionamentoService/CheckinResponse")]
        void Checkin(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamentoService/Checkin", ReplyAction="http://tempuri.org/IEstacionamentoService/CheckinResponse")]
        System.Threading.Tasks.Task CheckinAsync(string placa);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEstacionamentoServiceChannel : Estacionamento.Console.EstacionamentoServiceReference.IEstacionamentoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EstacionamentoServiceClient : System.ServiceModel.ClientBase<Estacionamento.Console.EstacionamentoServiceReference.IEstacionamentoService>, Estacionamento.Console.EstacionamentoServiceReference.IEstacionamentoService {
        
        public EstacionamentoServiceClient() {
        }
        
        public EstacionamentoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EstacionamentoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstacionamentoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstacionamentoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Checkin(string placa) {
            base.Channel.Checkin(placa);
        }
        
        public System.Threading.Tasks.Task CheckinAsync(string placa) {
            return base.Channel.CheckinAsync(placa);
        }
    }
}