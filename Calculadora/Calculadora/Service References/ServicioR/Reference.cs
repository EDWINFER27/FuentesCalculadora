﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculadora.ServicioR {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioR.CalcularSoap")]
    public interface CalcularSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Calculadora.ServicioR.HelloWorldResponse HelloWorld(Calculadora.ServicioR.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Calculadora.ServicioR.HelloWorldResponse> HelloWorldAsync(Calculadora.ServicioR.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Suma", ReplyAction="*")]
        double Suma(double Num1, double Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Suma", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SumaAsync(double Num1, double Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Resta", ReplyAction="*")]
        double Resta(double Num1, double Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Resta", ReplyAction="*")]
        System.Threading.Tasks.Task<double> RestaAsync(double Num1, double Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicacion", ReplyAction="*")]
        double Multiplicacion(double Num1, double Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicacion", ReplyAction="*")]
        System.Threading.Tasks.Task<double> MultiplicacionAsync(double Num1, double Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Division", ReplyAction="*")]
        double Division(double Num1, double Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Division", ReplyAction="*")]
        System.Threading.Tasks.Task<double> DivisionAsync(double Num1, double Num2);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Calculadora.ServicioR.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Calculadora.ServicioR.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Calculadora.ServicioR.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Calculadora.ServicioR.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalcularSoapChannel : Calculadora.ServicioR.CalcularSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcularSoapClient : System.ServiceModel.ClientBase<Calculadora.ServicioR.CalcularSoap>, Calculadora.ServicioR.CalcularSoap {
        
        public CalcularSoapClient() {
        }
        
        public CalcularSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcularSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcularSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcularSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Calculadora.ServicioR.HelloWorldResponse Calculadora.ServicioR.CalcularSoap.HelloWorld(Calculadora.ServicioR.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Calculadora.ServicioR.HelloWorldRequest inValue = new Calculadora.ServicioR.HelloWorldRequest();
            inValue.Body = new Calculadora.ServicioR.HelloWorldRequestBody();
            Calculadora.ServicioR.HelloWorldResponse retVal = ((Calculadora.ServicioR.CalcularSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Calculadora.ServicioR.HelloWorldResponse> Calculadora.ServicioR.CalcularSoap.HelloWorldAsync(Calculadora.ServicioR.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Calculadora.ServicioR.HelloWorldResponse> HelloWorldAsync() {
            Calculadora.ServicioR.HelloWorldRequest inValue = new Calculadora.ServicioR.HelloWorldRequest();
            inValue.Body = new Calculadora.ServicioR.HelloWorldRequestBody();
            return ((Calculadora.ServicioR.CalcularSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public double Suma(double Num1, double Num2) {
            return base.Channel.Suma(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<double> SumaAsync(double Num1, double Num2) {
            return base.Channel.SumaAsync(Num1, Num2);
        }
        
        public double Resta(double Num1, double Num2) {
            return base.Channel.Resta(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<double> RestaAsync(double Num1, double Num2) {
            return base.Channel.RestaAsync(Num1, Num2);
        }
        
        public double Multiplicacion(double Num1, double Num2) {
            return base.Channel.Multiplicacion(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplicacionAsync(double Num1, double Num2) {
            return base.Channel.MultiplicacionAsync(Num1, Num2);
        }
        
        public double Division(double Num1, double Num2) {
            return base.Channel.Division(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<double> DivisionAsync(double Num1, double Num2) {
            return base.Channel.DivisionAsync(Num1, Num2);
        }
    }
}
