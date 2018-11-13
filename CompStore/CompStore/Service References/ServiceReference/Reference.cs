﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompStore.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.StoreWebServiceSoap")]
    public interface StoreWebServiceSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем region из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddStore", ReplyAction="*")]
        CompStore.ServiceReference.AddStoreResponse AddStore(CompStore.ServiceReference.AddStoreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddStore", ReplyAction="*")]
        System.Threading.Tasks.Task<CompStore.ServiceReference.AddStoreResponse> AddStoreAsync(CompStore.ServiceReference.AddStoreRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем id_product из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddReceive", ReplyAction="*")]
        CompStore.ServiceReference.AddReceiveResponse AddReceive(CompStore.ServiceReference.AddReceiveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddReceive", ReplyAction="*")]
        System.Threading.Tasks.Task<CompStore.ServiceReference.AddReceiveResponse> AddReceiveAsync(CompStore.ServiceReference.AddReceiveRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем id из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        CompStore.ServiceReference.GetAllResponse GetAll(CompStore.ServiceReference.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<CompStore.ServiceReference.GetAllResponse> GetAllAsync(CompStore.ServiceReference.GetAllRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем id из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteReceive", ReplyAction="*")]
        CompStore.ServiceReference.DeleteReceiveResponse DeleteReceive(CompStore.ServiceReference.DeleteReceiveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteReceive", ReplyAction="*")]
        System.Threading.Tasks.Task<CompStore.ServiceReference.DeleteReceiveResponse> DeleteReceiveAsync(CompStore.ServiceReference.DeleteReceiveRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем ident из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateNumberProduct", ReplyAction="*")]
        CompStore.ServiceReference.UpdateNumberProductResponse UpdateNumberProduct(CompStore.ServiceReference.UpdateNumberProductRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateNumberProduct", ReplyAction="*")]
        System.Threading.Tasks.Task<CompStore.ServiceReference.UpdateNumberProductResponse> UpdateNumberProductAsync(CompStore.ServiceReference.UpdateNumberProductRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddStoreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddStore", Namespace="http://tempuri.org/", Order=0)]
        public CompStore.ServiceReference.AddStoreRequestBody Body;
        
        public AddStoreRequest() {
        }
        
        public AddStoreRequest(CompStore.ServiceReference.AddStoreRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddStoreRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string region;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string city;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string street;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string bilding;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string phone;
        
        public AddStoreRequestBody() {
        }
        
        public AddStoreRequestBody(string region, string city, string street, string bilding, string name, string phone) {
            this.region = region;
            this.city = city;
            this.street = street;
            this.bilding = bilding;
            this.name = name;
            this.phone = phone;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddStoreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddStoreResponse", Namespace="http://tempuri.org/", Order=0)]
        public CompStore.ServiceReference.AddStoreResponseBody Body;
        
        public AddStoreResponse() {
        }
        
        public AddStoreResponse(CompStore.ServiceReference.AddStoreResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddStoreResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AddStoreResult;
        
        public AddStoreResponseBody() {
        }
        
        public AddStoreResponseBody(string AddStoreResult) {
            this.AddStoreResult = AddStoreResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddReceiveRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddReceive", Namespace="http://tempuri.org/", Order=0)]
        public CompStore.ServiceReference.AddReceiveRequestBody Body;
        
        public AddReceiveRequest() {
        }
        
        public AddReceiveRequest(CompStore.ServiceReference.AddReceiveRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddReceiveRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id_store;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string id_product;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.Nullable<int> number;
        
        public AddReceiveRequestBody() {
        }
        
        public AddReceiveRequestBody(int id_store, string id_product, System.Nullable<int> number) {
            this.id_store = id_store;
            this.id_product = id_product;
            this.number = number;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddReceiveResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddReceiveResponse", Namespace="http://tempuri.org/", Order=0)]
        public CompStore.ServiceReference.AddReceiveResponseBody Body;
        
        public AddReceiveResponse() {
        }
        
        public AddReceiveResponse(CompStore.ServiceReference.AddReceiveResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddReceiveResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AddReceiveResult;
        
        public AddReceiveResponseBody() {
        }
        
        public AddReceiveResponseBody(string AddReceiveResult) {
            this.AddReceiveResult = AddReceiveResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public CompStore.ServiceReference.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(CompStore.ServiceReference.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int id_store;
        
        public GetAllRequestBody() {
        }
        
        public GetAllRequestBody(string id, int id_store) {
            this.id = id;
            this.id_store = id_store;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public CompStore.ServiceReference.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(CompStore.ServiceReference.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CompStore.ServiceReference.ArrayOfString GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(CompStore.ServiceReference.ArrayOfString GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteReceiveRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteReceive", Namespace="http://tempuri.org/", Order=0)]
        public CompStore.ServiceReference.DeleteReceiveRequestBody Body;
        
        public DeleteReceiveRequest() {
        }
        
        public DeleteReceiveRequest(CompStore.ServiceReference.DeleteReceiveRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteReceiveRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int id_store;
        
        public DeleteReceiveRequestBody() {
        }
        
        public DeleteReceiveRequestBody(string id, int id_store) {
            this.id = id;
            this.id_store = id_store;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteReceiveResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteReceiveResponse", Namespace="http://tempuri.org/", Order=0)]
        public CompStore.ServiceReference.DeleteReceiveResponseBody Body;
        
        public DeleteReceiveResponse() {
        }
        
        public DeleteReceiveResponse(CompStore.ServiceReference.DeleteReceiveResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class DeleteReceiveResponseBody {
        
        public DeleteReceiveResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateNumberProductRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateNumberProduct", Namespace="http://tempuri.org/", Order=0)]
        public CompStore.ServiceReference.UpdateNumberProductRequestBody Body;
        
        public UpdateNumberProductRequest() {
        }
        
        public UpdateNumberProductRequest(CompStore.ServiceReference.UpdateNumberProductRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateNumberProductRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int number;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int id_store;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ident;
        
        public UpdateNumberProductRequestBody() {
        }
        
        public UpdateNumberProductRequestBody(int number, int id_store, string ident) {
            this.number = number;
            this.id_store = id_store;
            this.ident = ident;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateNumberProductResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateNumberProductResponse", Namespace="http://tempuri.org/", Order=0)]
        public CompStore.ServiceReference.UpdateNumberProductResponseBody Body;
        
        public UpdateNumberProductResponse() {
        }
        
        public UpdateNumberProductResponse(CompStore.ServiceReference.UpdateNumberProductResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateNumberProductResponseBody {
        
        public UpdateNumberProductResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StoreWebServiceSoapChannel : CompStore.ServiceReference.StoreWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StoreWebServiceSoapClient : System.ServiceModel.ClientBase<CompStore.ServiceReference.StoreWebServiceSoap>, CompStore.ServiceReference.StoreWebServiceSoap {
        
        public StoreWebServiceSoapClient() {
        }
        
        public StoreWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StoreWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StoreWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StoreWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CompStore.ServiceReference.AddStoreResponse CompStore.ServiceReference.StoreWebServiceSoap.AddStore(CompStore.ServiceReference.AddStoreRequest request) {
            return base.Channel.AddStore(request);
        }
        
        public string AddStore(string region, string city, string street, string bilding, string name, string phone) {
            CompStore.ServiceReference.AddStoreRequest inValue = new CompStore.ServiceReference.AddStoreRequest();
            inValue.Body = new CompStore.ServiceReference.AddStoreRequestBody();
            inValue.Body.region = region;
            inValue.Body.city = city;
            inValue.Body.street = street;
            inValue.Body.bilding = bilding;
            inValue.Body.name = name;
            inValue.Body.phone = phone;
            CompStore.ServiceReference.AddStoreResponse retVal = ((CompStore.ServiceReference.StoreWebServiceSoap)(this)).AddStore(inValue);
            return retVal.Body.AddStoreResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CompStore.ServiceReference.AddStoreResponse> CompStore.ServiceReference.StoreWebServiceSoap.AddStoreAsync(CompStore.ServiceReference.AddStoreRequest request) {
            return base.Channel.AddStoreAsync(request);
        }
        
        public System.Threading.Tasks.Task<CompStore.ServiceReference.AddStoreResponse> AddStoreAsync(string region, string city, string street, string bilding, string name, string phone) {
            CompStore.ServiceReference.AddStoreRequest inValue = new CompStore.ServiceReference.AddStoreRequest();
            inValue.Body = new CompStore.ServiceReference.AddStoreRequestBody();
            inValue.Body.region = region;
            inValue.Body.city = city;
            inValue.Body.street = street;
            inValue.Body.bilding = bilding;
            inValue.Body.name = name;
            inValue.Body.phone = phone;
            return ((CompStore.ServiceReference.StoreWebServiceSoap)(this)).AddStoreAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CompStore.ServiceReference.AddReceiveResponse CompStore.ServiceReference.StoreWebServiceSoap.AddReceive(CompStore.ServiceReference.AddReceiveRequest request) {
            return base.Channel.AddReceive(request);
        }
        
        public string AddReceive(int id_store, string id_product, System.Nullable<int> number) {
            CompStore.ServiceReference.AddReceiveRequest inValue = new CompStore.ServiceReference.AddReceiveRequest();
            inValue.Body = new CompStore.ServiceReference.AddReceiveRequestBody();
            inValue.Body.id_store = id_store;
            inValue.Body.id_product = id_product;
            inValue.Body.number = number;
            CompStore.ServiceReference.AddReceiveResponse retVal = ((CompStore.ServiceReference.StoreWebServiceSoap)(this)).AddReceive(inValue);
            return retVal.Body.AddReceiveResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CompStore.ServiceReference.AddReceiveResponse> CompStore.ServiceReference.StoreWebServiceSoap.AddReceiveAsync(CompStore.ServiceReference.AddReceiveRequest request) {
            return base.Channel.AddReceiveAsync(request);
        }
        
        public System.Threading.Tasks.Task<CompStore.ServiceReference.AddReceiveResponse> AddReceiveAsync(int id_store, string id_product, System.Nullable<int> number) {
            CompStore.ServiceReference.AddReceiveRequest inValue = new CompStore.ServiceReference.AddReceiveRequest();
            inValue.Body = new CompStore.ServiceReference.AddReceiveRequestBody();
            inValue.Body.id_store = id_store;
            inValue.Body.id_product = id_product;
            inValue.Body.number = number;
            return ((CompStore.ServiceReference.StoreWebServiceSoap)(this)).AddReceiveAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CompStore.ServiceReference.GetAllResponse CompStore.ServiceReference.StoreWebServiceSoap.GetAll(CompStore.ServiceReference.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public CompStore.ServiceReference.ArrayOfString GetAll(string id, int id_store) {
            CompStore.ServiceReference.GetAllRequest inValue = new CompStore.ServiceReference.GetAllRequest();
            inValue.Body = new CompStore.ServiceReference.GetAllRequestBody();
            inValue.Body.id = id;
            inValue.Body.id_store = id_store;
            CompStore.ServiceReference.GetAllResponse retVal = ((CompStore.ServiceReference.StoreWebServiceSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CompStore.ServiceReference.GetAllResponse> CompStore.ServiceReference.StoreWebServiceSoap.GetAllAsync(CompStore.ServiceReference.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<CompStore.ServiceReference.GetAllResponse> GetAllAsync(string id, int id_store) {
            CompStore.ServiceReference.GetAllRequest inValue = new CompStore.ServiceReference.GetAllRequest();
            inValue.Body = new CompStore.ServiceReference.GetAllRequestBody();
            inValue.Body.id = id;
            inValue.Body.id_store = id_store;
            return ((CompStore.ServiceReference.StoreWebServiceSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CompStore.ServiceReference.DeleteReceiveResponse CompStore.ServiceReference.StoreWebServiceSoap.DeleteReceive(CompStore.ServiceReference.DeleteReceiveRequest request) {
            return base.Channel.DeleteReceive(request);
        }
        
        public void DeleteReceive(string id, int id_store) {
            CompStore.ServiceReference.DeleteReceiveRequest inValue = new CompStore.ServiceReference.DeleteReceiveRequest();
            inValue.Body = new CompStore.ServiceReference.DeleteReceiveRequestBody();
            inValue.Body.id = id;
            inValue.Body.id_store = id_store;
            CompStore.ServiceReference.DeleteReceiveResponse retVal = ((CompStore.ServiceReference.StoreWebServiceSoap)(this)).DeleteReceive(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CompStore.ServiceReference.DeleteReceiveResponse> CompStore.ServiceReference.StoreWebServiceSoap.DeleteReceiveAsync(CompStore.ServiceReference.DeleteReceiveRequest request) {
            return base.Channel.DeleteReceiveAsync(request);
        }
        
        public System.Threading.Tasks.Task<CompStore.ServiceReference.DeleteReceiveResponse> DeleteReceiveAsync(string id, int id_store) {
            CompStore.ServiceReference.DeleteReceiveRequest inValue = new CompStore.ServiceReference.DeleteReceiveRequest();
            inValue.Body = new CompStore.ServiceReference.DeleteReceiveRequestBody();
            inValue.Body.id = id;
            inValue.Body.id_store = id_store;
            return ((CompStore.ServiceReference.StoreWebServiceSoap)(this)).DeleteReceiveAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CompStore.ServiceReference.UpdateNumberProductResponse CompStore.ServiceReference.StoreWebServiceSoap.UpdateNumberProduct(CompStore.ServiceReference.UpdateNumberProductRequest request) {
            return base.Channel.UpdateNumberProduct(request);
        }
        
        public void UpdateNumberProduct(int number, int id_store, string ident) {
            CompStore.ServiceReference.UpdateNumberProductRequest inValue = new CompStore.ServiceReference.UpdateNumberProductRequest();
            inValue.Body = new CompStore.ServiceReference.UpdateNumberProductRequestBody();
            inValue.Body.number = number;
            inValue.Body.id_store = id_store;
            inValue.Body.ident = ident;
            CompStore.ServiceReference.UpdateNumberProductResponse retVal = ((CompStore.ServiceReference.StoreWebServiceSoap)(this)).UpdateNumberProduct(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CompStore.ServiceReference.UpdateNumberProductResponse> CompStore.ServiceReference.StoreWebServiceSoap.UpdateNumberProductAsync(CompStore.ServiceReference.UpdateNumberProductRequest request) {
            return base.Channel.UpdateNumberProductAsync(request);
        }
        
        public System.Threading.Tasks.Task<CompStore.ServiceReference.UpdateNumberProductResponse> UpdateNumberProductAsync(int number, int id_store, string ident) {
            CompStore.ServiceReference.UpdateNumberProductRequest inValue = new CompStore.ServiceReference.UpdateNumberProductRequest();
            inValue.Body = new CompStore.ServiceReference.UpdateNumberProductRequestBody();
            inValue.Body.number = number;
            inValue.Body.id_store = id_store;
            inValue.Body.ident = ident;
            return ((CompStore.ServiceReference.StoreWebServiceSoap)(this)).UpdateNumberProductAsync(inValue);
        }
    }
}