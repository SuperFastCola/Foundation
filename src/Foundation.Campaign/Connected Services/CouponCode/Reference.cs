﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Foundation.Campaign.Connected_Services.CouponCode
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap11.api.broadmail")]
    public partial class WebserviceException
    {
        
        private object causeField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public object cause
        {
            get
            {
                return this.causeField;
            }
            set
            {
                this.causeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", ConfigurationName="CouponCode.CouponCodeWebservice")]
    public interface CouponCodeWebservice
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="addReturn")]
        System.Threading.Tasks.Task<bool> addAsync(string in0, long in1, string in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CouponCode.addAllResponse> addAllAsync(CouponCode.addAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="removeReturn")]
        System.Threading.Tasks.Task<bool> removeAsync(string in0, long in1, string in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CouponCode.removeAllResponse> removeAllAsync(CouponCode.removeAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getCreatedReturn")]
        System.Threading.Tasks.Task<System.DateTime> getCreatedAsync(string in0, long in1, string in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getModifiedReturn")]
        System.Threading.Tasks.Task<System.DateTime> getModifiedAsync(string in0, long in1, string in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CouponCode.getAllAssignedResponse> getAllAssignedAsync(CouponCode.getAllAssignedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CouponCode.getAllUnAssignedResponse> getAllUnAssignedAsync(CouponCode.getAllUnAssignedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CouponCode.getByMailingAndRecipientIdResponse> getByMailingAndRecipientIdAsync(CouponCode.getByMailingAndRecipientIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="isUsedReturn")]
        System.Threading.Tasks.Task<bool> isUsedAsync(string in0, long in1, string in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="isAssignedReturn")]
        System.Threading.Tasks.Task<bool> isAssignedAsync(string in0, long in1, string in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task markAsUsedAsync(string in0, long in1, string in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getAssignedRecipientIdReturn")]
        System.Threading.Tasks.Task<string> getAssignedRecipientIdAsync(string in0, long in1, string in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getAssignedMailingReturn")]
        System.Threading.Tasks.Task<long> getAssignedMailingAsync(string in0, long in1, string in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CouponCode.WebserviceException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getVersionReturn")]
        System.Threading.Tasks.Task<string> getVersionAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addAll", WrapperNamespace="urn:api.broadmail.de/soap11/addons/CouponCode", IsWrapped=true)]
    public partial class addAllRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=0)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=1)]
        public long in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("in2")]
        public string[] in2;
        
        public addAllRequest()
        {
        }
        
        public addAllRequest(string in0, long in1, string[] in2)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addAllResponse", WrapperNamespace="urn:api.broadmail.de/soap11/addons/CouponCode", IsWrapped=true)]
    public partial class addAllResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("addAllReturn")]
        public bool[] addAllReturn;
        
        public addAllResponse()
        {
        }
        
        public addAllResponse(bool[] addAllReturn)
        {
            this.addAllReturn = addAllReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="removeAll", WrapperNamespace="urn:api.broadmail.de/soap11/addons/CouponCode", IsWrapped=true)]
    public partial class removeAllRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=0)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=1)]
        public long in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("in2")]
        public string[] in2;
        
        public removeAllRequest()
        {
        }
        
        public removeAllRequest(string in0, long in1, string[] in2)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="removeAllResponse", WrapperNamespace="urn:api.broadmail.de/soap11/addons/CouponCode", IsWrapped=true)]
    public partial class removeAllResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("removeAllReturn")]
        public bool[] removeAllReturn;
        
        public removeAllResponse()
        {
        }
        
        public removeAllResponse(bool[] removeAllReturn)
        {
            this.removeAllReturn = removeAllReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAllAssigned", WrapperNamespace="urn:api.broadmail.de/soap11/addons/CouponCode", IsWrapped=true)]
    public partial class getAllAssignedRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=0)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=1)]
        public long in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=2)]
        public long in2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=3)]
        public int in3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=4)]
        public int in4;
        
        public getAllAssignedRequest()
        {
        }
        
        public getAllAssignedRequest(string in0, long in1, long in2, int in3, int in4)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
            this.in3 = in3;
            this.in4 = in4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAllAssignedResponse", WrapperNamespace="urn:api.broadmail.de/soap11/addons/CouponCode", IsWrapped=true)]
    public partial class getAllAssignedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("getAllAssignedReturn")]
        public string[] getAllAssignedReturn;
        
        public getAllAssignedResponse()
        {
        }
        
        public getAllAssignedResponse(string[] getAllAssignedReturn)
        {
            this.getAllAssignedReturn = getAllAssignedReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAllUnAssigned", WrapperNamespace="urn:api.broadmail.de/soap11/addons/CouponCode", IsWrapped=true)]
    public partial class getAllUnAssignedRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=0)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=1)]
        public long in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=2)]
        public int in2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=3)]
        public int in3;
        
        public getAllUnAssignedRequest()
        {
        }
        
        public getAllUnAssignedRequest(string in0, long in1, int in2, int in3)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
            this.in3 = in3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAllUnAssignedResponse", WrapperNamespace="urn:api.broadmail.de/soap11/addons/CouponCode", IsWrapped=true)]
    public partial class getAllUnAssignedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("getAllUnAssignedReturn")]
        public string[] getAllUnAssignedReturn;
        
        public getAllUnAssignedResponse()
        {
        }
        
        public getAllUnAssignedResponse(string[] getAllUnAssignedReturn)
        {
            this.getAllUnAssignedReturn = getAllUnAssignedReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getByMailingAndRecipientId", WrapperNamespace="urn:api.broadmail.de/soap11/addons/CouponCode", IsWrapped=true)]
    public partial class getByMailingAndRecipientIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=0)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=1)]
        public long in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=2)]
        public long in2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=3)]
        public string in3;
        
        public getByMailingAndRecipientIdRequest()
        {
        }
        
        public getByMailingAndRecipientIdRequest(string in0, long in1, long in2, string in3)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
            this.in3 = in3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getByMailingAndRecipientIdResponse", WrapperNamespace="urn:api.broadmail.de/soap11/addons/CouponCode", IsWrapped=true)]
    public partial class getByMailingAndRecipientIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:api.broadmail.de/soap11/addons/CouponCode", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("getByMailingAndRecipientIdReturn")]
        public string[] getByMailingAndRecipientIdReturn;
        
        public getByMailingAndRecipientIdResponse()
        {
        }
        
        public getByMailingAndRecipientIdResponse(string[] getByMailingAndRecipientIdReturn)
        {
            this.getByMailingAndRecipientIdReturn = getByMailingAndRecipientIdReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface CouponCodeWebserviceChannel : CouponCode.CouponCodeWebservice, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class CouponCodeWebserviceClient : System.ServiceModel.ClientBase<CouponCode.CouponCodeWebservice>, CouponCode.CouponCodeWebservice
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CouponCodeWebserviceClient() : 
                base(CouponCodeWebserviceClient.GetDefaultBinding(), CouponCodeWebserviceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.CouponCode.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CouponCodeWebserviceClient(EndpointConfiguration endpointConfiguration) : 
                base(CouponCodeWebserviceClient.GetBindingForEndpoint(endpointConfiguration), CouponCodeWebserviceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CouponCodeWebserviceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CouponCodeWebserviceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CouponCodeWebserviceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CouponCodeWebserviceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CouponCodeWebserviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> addAsync(string in0, long in1, string in2)
        {
            return base.Channel.addAsync(in0, in1, in2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CouponCode.addAllResponse> CouponCode.CouponCodeWebservice.addAllAsync(CouponCode.addAllRequest request)
        {
            return base.Channel.addAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<CouponCode.addAllResponse> addAllAsync(string in0, long in1, string[] in2)
        {
            CouponCode.addAllRequest inValue = new CouponCode.addAllRequest();
            inValue.in0 = in0;
            inValue.in1 = in1;
            inValue.in2 = in2;
            return ((CouponCode.CouponCodeWebservice)(this)).addAllAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<bool> removeAsync(string in0, long in1, string in2)
        {
            return base.Channel.removeAsync(in0, in1, in2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CouponCode.removeAllResponse> CouponCode.CouponCodeWebservice.removeAllAsync(CouponCode.removeAllRequest request)
        {
            return base.Channel.removeAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<CouponCode.removeAllResponse> removeAllAsync(string in0, long in1, string[] in2)
        {
            CouponCode.removeAllRequest inValue = new CouponCode.removeAllRequest();
            inValue.in0 = in0;
            inValue.in1 = in1;
            inValue.in2 = in2;
            return ((CouponCode.CouponCodeWebservice)(this)).removeAllAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<System.DateTime> getCreatedAsync(string in0, long in1, string in2)
        {
            return base.Channel.getCreatedAsync(in0, in1, in2);
        }
        
        public System.Threading.Tasks.Task<System.DateTime> getModifiedAsync(string in0, long in1, string in2)
        {
            return base.Channel.getModifiedAsync(in0, in1, in2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CouponCode.getAllAssignedResponse> CouponCode.CouponCodeWebservice.getAllAssignedAsync(CouponCode.getAllAssignedRequest request)
        {
            return base.Channel.getAllAssignedAsync(request);
        }
        
        public System.Threading.Tasks.Task<CouponCode.getAllAssignedResponse> getAllAssignedAsync(string in0, long in1, long in2, int in3, int in4)
        {
            CouponCode.getAllAssignedRequest inValue = new CouponCode.getAllAssignedRequest();
            inValue.in0 = in0;
            inValue.in1 = in1;
            inValue.in2 = in2;
            inValue.in3 = in3;
            inValue.in4 = in4;
            return ((CouponCode.CouponCodeWebservice)(this)).getAllAssignedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CouponCode.getAllUnAssignedResponse> CouponCode.CouponCodeWebservice.getAllUnAssignedAsync(CouponCode.getAllUnAssignedRequest request)
        {
            return base.Channel.getAllUnAssignedAsync(request);
        }
        
        public System.Threading.Tasks.Task<CouponCode.getAllUnAssignedResponse> getAllUnAssignedAsync(string in0, long in1, int in2, int in3)
        {
            CouponCode.getAllUnAssignedRequest inValue = new CouponCode.getAllUnAssignedRequest();
            inValue.in0 = in0;
            inValue.in1 = in1;
            inValue.in2 = in2;
            inValue.in3 = in3;
            return ((CouponCode.CouponCodeWebservice)(this)).getAllUnAssignedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CouponCode.getByMailingAndRecipientIdResponse> CouponCode.CouponCodeWebservice.getByMailingAndRecipientIdAsync(CouponCode.getByMailingAndRecipientIdRequest request)
        {
            return base.Channel.getByMailingAndRecipientIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<CouponCode.getByMailingAndRecipientIdResponse> getByMailingAndRecipientIdAsync(string in0, long in1, long in2, string in3)
        {
            CouponCode.getByMailingAndRecipientIdRequest inValue = new CouponCode.getByMailingAndRecipientIdRequest();
            inValue.in0 = in0;
            inValue.in1 = in1;
            inValue.in2 = in2;
            inValue.in3 = in3;
            return ((CouponCode.CouponCodeWebservice)(this)).getByMailingAndRecipientIdAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<bool> isUsedAsync(string in0, long in1, string in2)
        {
            return base.Channel.isUsedAsync(in0, in1, in2);
        }
        
        public System.Threading.Tasks.Task<bool> isAssignedAsync(string in0, long in1, string in2)
        {
            return base.Channel.isAssignedAsync(in0, in1, in2);
        }
        
        public System.Threading.Tasks.Task markAsUsedAsync(string in0, long in1, string in2)
        {
            return base.Channel.markAsUsedAsync(in0, in1, in2);
        }
        
        public System.Threading.Tasks.Task<string> getAssignedRecipientIdAsync(string in0, long in1, string in2)
        {
            return base.Channel.getAssignedRecipientIdAsync(in0, in1, in2);
        }
        
        public System.Threading.Tasks.Task<long> getAssignedMailingAsync(string in0, long in1, string in2)
        {
            return base.Channel.getAssignedMailingAsync(in0, in1, in2);
        }
        
        public System.Threading.Tasks.Task<string> getVersionAsync()
        {
            return base.Channel.getVersionAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CouponCode))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CouponCode))
            {
                return new System.ServiceModel.EndpointAddress("http://api.broadmail.de/soap11/addons/CouponCode");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CouponCodeWebserviceClient.GetBindingForEndpoint(EndpointConfiguration.CouponCode);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CouponCodeWebserviceClient.GetEndpointAddress(EndpointConfiguration.CouponCode);
        }
        
        public enum EndpointConfiguration
        {
            
            CouponCode,
        }
    }
}
