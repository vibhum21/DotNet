﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGoodStockService")]
    public interface IGoodStockService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoodStockService/GetStockPrice", ReplyAction="http://tempuri.org/IGoodStockService/GetStockPriceResponse")]
        double GetStockPrice(string ticker);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGoodStockServiceChannel : Client.ServiceReference1.IGoodStockService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GoodStockServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IGoodStockService>, Client.ServiceReference1.IGoodStockService {
        
        public GoodStockServiceClient() {
        }
        
        public GoodStockServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GoodStockServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GoodStockServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GoodStockServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double GetStockPrice(string ticker) {
            return base.Channel.GetStockPrice(ticker);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGreatStockService")]
    public interface IGreatStockService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGreatStockService/GetStockPriceFast", ReplyAction="http://tempuri.org/IGreatStockService/GetStockPriceFastResponse")]
        double GetStockPriceFast(string ticker);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGreatStockServiceChannel : Client.ServiceReference1.IGreatStockService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GreatStockServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IGreatStockService>, Client.ServiceReference1.IGreatStockService {
        
        public GreatStockServiceClient() {
        }
        
        public GreatStockServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GreatStockServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GreatStockServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GreatStockServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double GetStockPriceFast(string ticker) {
            return base.Channel.GetStockPriceFast(ticker);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAllStockServices")]
    public interface IAllStockServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoodStockService/GetStockPrice", ReplyAction="http://tempuri.org/IGoodStockService/GetStockPriceResponse")]
        double GetStockPrice(string ticker);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGreatStockService/GetStockPriceFast", ReplyAction="http://tempuri.org/IGreatStockService/GetStockPriceFastResponse")]
        double GetStockPriceFast(string ticker);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAllStockServicesChannel : Client.ServiceReference1.IAllStockServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AllStockServicesClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IAllStockServices>, Client.ServiceReference1.IAllStockServices {
        
        public AllStockServicesClient() {
        }
        
        public AllStockServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AllStockServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AllStockServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AllStockServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double GetStockPrice(string ticker) {
            return base.Channel.GetStockPrice(ticker);
        }
        
        public double GetStockPriceFast(string ticker) {
            return base.Channel.GetStockPriceFast(ticker);
        }
    }
}