﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TareaPractica1.WSTareaPractica1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSTareaPractica1.Service1Soap")]
    public interface Service1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ProbarConexion", ReplyAction="*")]
        TareaPractica1.WSTareaPractica1.ProbarConexionResponse ProbarConexion(TareaPractica1.WSTareaPractica1.ProbarConexionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ProbarConexion", ReplyAction="*")]
        System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.ProbarConexionResponse> ProbarConexionAsync(TareaPractica1.WSTareaPractica1.ProbarConexionRequest request);
        
        // CODEGEN: Generating message contract since element name pnombre from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarLibro", ReplyAction="*")]
        TareaPractica1.WSTareaPractica1.AgregarLibroResponse AgregarLibro(TareaPractica1.WSTareaPractica1.AgregarLibroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarLibro", ReplyAction="*")]
        System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.AgregarLibroResponse> AgregarLibroAsync(TareaPractica1.WSTareaPractica1.AgregarLibroRequest request);
        
        // CODEGEN: Generating message contract since element name pnombre from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCliente", ReplyAction="*")]
        TareaPractica1.WSTareaPractica1.AgregarClienteResponse AgregarCliente(TareaPractica1.WSTareaPractica1.AgregarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.AgregarClienteResponse> AgregarClienteAsync(TareaPractica1.WSTareaPractica1.AgregarClienteRequest request);
        
        // CODEGEN: Generating message contract since element name nombre from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/busqueda", ReplyAction="*")]
        TareaPractica1.WSTareaPractica1.busquedaResponse busqueda(TareaPractica1.WSTareaPractica1.busquedaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/busqueda", ReplyAction="*")]
        System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.busquedaResponse> busquedaAsync(TareaPractica1.WSTareaPractica1.busquedaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ProbarConexionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ProbarConexion", Namespace="http://tempuri.org/", Order=0)]
        public TareaPractica1.WSTareaPractica1.ProbarConexionRequestBody Body;
        
        public ProbarConexionRequest() {
        }
        
        public ProbarConexionRequest(TareaPractica1.WSTareaPractica1.ProbarConexionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ProbarConexionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string error;
        
        public ProbarConexionRequestBody() {
        }
        
        public ProbarConexionRequestBody(string error) {
            this.error = error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ProbarConexionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ProbarConexionResponse", Namespace="http://tempuri.org/", Order=0)]
        public TareaPractica1.WSTareaPractica1.ProbarConexionResponseBody Body;
        
        public ProbarConexionResponse() {
        }
        
        public ProbarConexionResponse(TareaPractica1.WSTareaPractica1.ProbarConexionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ProbarConexionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ProbarConexionResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string error;
        
        public ProbarConexionResponseBody() {
        }
        
        public ProbarConexionResponseBody(bool ProbarConexionResult, string error) {
            this.ProbarConexionResult = ProbarConexionResult;
            this.error = error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarLibroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarLibro", Namespace="http://tempuri.org/", Order=0)]
        public TareaPractica1.WSTareaPractica1.AgregarLibroRequestBody Body;
        
        public AgregarLibroRequest() {
        }
        
        public AgregarLibroRequest(TareaPractica1.WSTareaPractica1.AgregarLibroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarLibroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string pnombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int pnumex;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int pnumpag;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string pautor;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ptema;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int pnumexl;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int pprestamo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public int preserva;
        
        public AgregarLibroRequestBody() {
        }
        
        public AgregarLibroRequestBody(string pnombre, int pnumex, int pnumpag, string pautor, string ptema, int pnumexl, int pprestamo, int preserva) {
            this.pnombre = pnombre;
            this.pnumex = pnumex;
            this.pnumpag = pnumpag;
            this.pautor = pautor;
            this.ptema = ptema;
            this.pnumexl = pnumexl;
            this.pprestamo = pprestamo;
            this.preserva = preserva;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarLibroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarLibroResponse", Namespace="http://tempuri.org/", Order=0)]
        public TareaPractica1.WSTareaPractica1.AgregarLibroResponseBody Body;
        
        public AgregarLibroResponse() {
        }
        
        public AgregarLibroResponse(TareaPractica1.WSTareaPractica1.AgregarLibroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarLibroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AgregarLibroResult;
        
        public AgregarLibroResponseBody() {
        }
        
        public AgregarLibroResponseBody(bool AgregarLibroResult) {
            this.AgregarLibroResult = AgregarLibroResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarCliente", Namespace="http://tempuri.org/", Order=0)]
        public TareaPractica1.WSTareaPractica1.AgregarClienteRequestBody Body;
        
        public AgregarClienteRequest() {
        }
        
        public AgregarClienteRequest(TareaPractica1.WSTareaPractica1.AgregarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string pnombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int pdpi;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string pdireccion;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int ptelefono;
        
        public AgregarClienteRequestBody() {
        }
        
        public AgregarClienteRequestBody(string pnombre, int pdpi, string pdireccion, int ptelefono) {
            this.pnombre = pnombre;
            this.pdpi = pdpi;
            this.pdireccion = pdireccion;
            this.ptelefono = ptelefono;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public TareaPractica1.WSTareaPractica1.AgregarClienteResponseBody Body;
        
        public AgregarClienteResponse() {
        }
        
        public AgregarClienteResponse(TareaPractica1.WSTareaPractica1.AgregarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AgregarClienteResult;
        
        public AgregarClienteResponseBody() {
        }
        
        public AgregarClienteResponseBody(bool AgregarClienteResult) {
            this.AgregarClienteResult = AgregarClienteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class busquedaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="busqueda", Namespace="http://tempuri.org/", Order=0)]
        public TareaPractica1.WSTareaPractica1.busquedaRequestBody Body;
        
        public busquedaRequest() {
        }
        
        public busquedaRequest(TareaPractica1.WSTareaPractica1.busquedaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class busquedaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        public busquedaRequestBody() {
        }
        
        public busquedaRequestBody(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class busquedaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="busquedaResponse", Namespace="http://tempuri.org/", Order=0)]
        public TareaPractica1.WSTareaPractica1.busquedaResponseBody Body;
        
        public busquedaResponse() {
        }
        
        public busquedaResponse(TareaPractica1.WSTareaPractica1.busquedaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class busquedaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool busquedaResult;
        
        public busquedaResponseBody() {
        }
        
        public busquedaResponseBody(bool busquedaResult) {
            this.busquedaResult = busquedaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : TareaPractica1.WSTareaPractica1.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<TareaPractica1.WSTareaPractica1.Service1Soap>, TareaPractica1.WSTareaPractica1.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TareaPractica1.WSTareaPractica1.ProbarConexionResponse TareaPractica1.WSTareaPractica1.Service1Soap.ProbarConexion(TareaPractica1.WSTareaPractica1.ProbarConexionRequest request) {
            return base.Channel.ProbarConexion(request);
        }
        
        public bool ProbarConexion(ref string error) {
            TareaPractica1.WSTareaPractica1.ProbarConexionRequest inValue = new TareaPractica1.WSTareaPractica1.ProbarConexionRequest();
            inValue.Body = new TareaPractica1.WSTareaPractica1.ProbarConexionRequestBody();
            inValue.Body.error = error;
            TareaPractica1.WSTareaPractica1.ProbarConexionResponse retVal = ((TareaPractica1.WSTareaPractica1.Service1Soap)(this)).ProbarConexion(inValue);
            error = retVal.Body.error;
            return retVal.Body.ProbarConexionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.ProbarConexionResponse> TareaPractica1.WSTareaPractica1.Service1Soap.ProbarConexionAsync(TareaPractica1.WSTareaPractica1.ProbarConexionRequest request) {
            return base.Channel.ProbarConexionAsync(request);
        }
        
        public System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.ProbarConexionResponse> ProbarConexionAsync(string error) {
            TareaPractica1.WSTareaPractica1.ProbarConexionRequest inValue = new TareaPractica1.WSTareaPractica1.ProbarConexionRequest();
            inValue.Body = new TareaPractica1.WSTareaPractica1.ProbarConexionRequestBody();
            inValue.Body.error = error;
            return ((TareaPractica1.WSTareaPractica1.Service1Soap)(this)).ProbarConexionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TareaPractica1.WSTareaPractica1.AgregarLibroResponse TareaPractica1.WSTareaPractica1.Service1Soap.AgregarLibro(TareaPractica1.WSTareaPractica1.AgregarLibroRequest request) {
            return base.Channel.AgregarLibro(request);
        }
        
        public bool AgregarLibro(string pnombre, int pnumex, int pnumpag, string pautor, string ptema, int pnumexl, int pprestamo, int preserva) {
            TareaPractica1.WSTareaPractica1.AgregarLibroRequest inValue = new TareaPractica1.WSTareaPractica1.AgregarLibroRequest();
            inValue.Body = new TareaPractica1.WSTareaPractica1.AgregarLibroRequestBody();
            inValue.Body.pnombre = pnombre;
            inValue.Body.pnumex = pnumex;
            inValue.Body.pnumpag = pnumpag;
            inValue.Body.pautor = pautor;
            inValue.Body.ptema = ptema;
            inValue.Body.pnumexl = pnumexl;
            inValue.Body.pprestamo = pprestamo;
            inValue.Body.preserva = preserva;
            TareaPractica1.WSTareaPractica1.AgregarLibroResponse retVal = ((TareaPractica1.WSTareaPractica1.Service1Soap)(this)).AgregarLibro(inValue);
            return retVal.Body.AgregarLibroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.AgregarLibroResponse> TareaPractica1.WSTareaPractica1.Service1Soap.AgregarLibroAsync(TareaPractica1.WSTareaPractica1.AgregarLibroRequest request) {
            return base.Channel.AgregarLibroAsync(request);
        }
        
        public System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.AgregarLibroResponse> AgregarLibroAsync(string pnombre, int pnumex, int pnumpag, string pautor, string ptema, int pnumexl, int pprestamo, int preserva) {
            TareaPractica1.WSTareaPractica1.AgregarLibroRequest inValue = new TareaPractica1.WSTareaPractica1.AgregarLibroRequest();
            inValue.Body = new TareaPractica1.WSTareaPractica1.AgregarLibroRequestBody();
            inValue.Body.pnombre = pnombre;
            inValue.Body.pnumex = pnumex;
            inValue.Body.pnumpag = pnumpag;
            inValue.Body.pautor = pautor;
            inValue.Body.ptema = ptema;
            inValue.Body.pnumexl = pnumexl;
            inValue.Body.pprestamo = pprestamo;
            inValue.Body.preserva = preserva;
            return ((TareaPractica1.WSTareaPractica1.Service1Soap)(this)).AgregarLibroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TareaPractica1.WSTareaPractica1.AgregarClienteResponse TareaPractica1.WSTareaPractica1.Service1Soap.AgregarCliente(TareaPractica1.WSTareaPractica1.AgregarClienteRequest request) {
            return base.Channel.AgregarCliente(request);
        }
        
        public bool AgregarCliente(string pnombre, int pdpi, string pdireccion, int ptelefono) {
            TareaPractica1.WSTareaPractica1.AgregarClienteRequest inValue = new TareaPractica1.WSTareaPractica1.AgregarClienteRequest();
            inValue.Body = new TareaPractica1.WSTareaPractica1.AgregarClienteRequestBody();
            inValue.Body.pnombre = pnombre;
            inValue.Body.pdpi = pdpi;
            inValue.Body.pdireccion = pdireccion;
            inValue.Body.ptelefono = ptelefono;
            TareaPractica1.WSTareaPractica1.AgregarClienteResponse retVal = ((TareaPractica1.WSTareaPractica1.Service1Soap)(this)).AgregarCliente(inValue);
            return retVal.Body.AgregarClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.AgregarClienteResponse> TareaPractica1.WSTareaPractica1.Service1Soap.AgregarClienteAsync(TareaPractica1.WSTareaPractica1.AgregarClienteRequest request) {
            return base.Channel.AgregarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.AgregarClienteResponse> AgregarClienteAsync(string pnombre, int pdpi, string pdireccion, int ptelefono) {
            TareaPractica1.WSTareaPractica1.AgregarClienteRequest inValue = new TareaPractica1.WSTareaPractica1.AgregarClienteRequest();
            inValue.Body = new TareaPractica1.WSTareaPractica1.AgregarClienteRequestBody();
            inValue.Body.pnombre = pnombre;
            inValue.Body.pdpi = pdpi;
            inValue.Body.pdireccion = pdireccion;
            inValue.Body.ptelefono = ptelefono;
            return ((TareaPractica1.WSTareaPractica1.Service1Soap)(this)).AgregarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TareaPractica1.WSTareaPractica1.busquedaResponse TareaPractica1.WSTareaPractica1.Service1Soap.busqueda(TareaPractica1.WSTareaPractica1.busquedaRequest request) {
            return base.Channel.busqueda(request);
        }
        
        public bool busqueda(string nombre) {
            TareaPractica1.WSTareaPractica1.busquedaRequest inValue = new TareaPractica1.WSTareaPractica1.busquedaRequest();
            inValue.Body = new TareaPractica1.WSTareaPractica1.busquedaRequestBody();
            inValue.Body.nombre = nombre;
            TareaPractica1.WSTareaPractica1.busquedaResponse retVal = ((TareaPractica1.WSTareaPractica1.Service1Soap)(this)).busqueda(inValue);
            return retVal.Body.busquedaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.busquedaResponse> TareaPractica1.WSTareaPractica1.Service1Soap.busquedaAsync(TareaPractica1.WSTareaPractica1.busquedaRequest request) {
            return base.Channel.busquedaAsync(request);
        }
        
        public System.Threading.Tasks.Task<TareaPractica1.WSTareaPractica1.busquedaResponse> busquedaAsync(string nombre) {
            TareaPractica1.WSTareaPractica1.busquedaRequest inValue = new TareaPractica1.WSTareaPractica1.busquedaRequest();
            inValue.Body = new TareaPractica1.WSTareaPractica1.busquedaRequestBody();
            inValue.Body.nombre = nombre;
            return ((TareaPractica1.WSTareaPractica1.Service1Soap)(this)).busquedaAsync(inValue);
        }
    }
}