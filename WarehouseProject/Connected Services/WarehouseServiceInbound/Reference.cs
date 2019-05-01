﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InboundClient.WarehouseServiceInbound {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Warehouse", Namespace="http://schemas.datacontract.org/2004/07/Warehouse_Prj.Service")]
    [System.SerializableAttribute()]
    public partial class Warehouse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarehouseAddressCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarehouseAddressStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarehouseAddressStreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarehouseAddressZipcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WarehouseIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarehouseNameField;
        
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
        public string WarehouseAddressCity {
            get {
                return this.WarehouseAddressCityField;
            }
            set {
                if ((object.ReferenceEquals(this.WarehouseAddressCityField, value) != true)) {
                    this.WarehouseAddressCityField = value;
                    this.RaisePropertyChanged("WarehouseAddressCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WarehouseAddressState {
            get {
                return this.WarehouseAddressStateField;
            }
            set {
                if ((object.ReferenceEquals(this.WarehouseAddressStateField, value) != true)) {
                    this.WarehouseAddressStateField = value;
                    this.RaisePropertyChanged("WarehouseAddressState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WarehouseAddressStreet {
            get {
                return this.WarehouseAddressStreetField;
            }
            set {
                if ((object.ReferenceEquals(this.WarehouseAddressStreetField, value) != true)) {
                    this.WarehouseAddressStreetField = value;
                    this.RaisePropertyChanged("WarehouseAddressStreet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WarehouseAddressZipcode {
            get {
                return this.WarehouseAddressZipcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.WarehouseAddressZipcodeField, value) != true)) {
                    this.WarehouseAddressZipcodeField = value;
                    this.RaisePropertyChanged("WarehouseAddressZipcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WarehouseID {
            get {
                return this.WarehouseIDField;
            }
            set {
                if ((this.WarehouseIDField.Equals(value) != true)) {
                    this.WarehouseIDField = value;
                    this.RaisePropertyChanged("WarehouseID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WarehouseName {
            get {
                return this.WarehouseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.WarehouseNameField, value) != true)) {
                    this.WarehouseNameField = value;
                    this.RaisePropertyChanged("WarehouseName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseServiceInbound.IWarehouse")]
    public interface IWarehouse {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/GetWarehouse", ReplyAction="http://tempuri.org/IWarehouse/GetWarehouseResponse")]
        InboundClient.WarehouseServiceInbound.Warehouse GetWarehouse(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/GetWarehouse", ReplyAction="http://tempuri.org/IWarehouse/GetWarehouseResponse")]
        System.Threading.Tasks.Task<InboundClient.WarehouseServiceInbound.Warehouse> GetWarehouseAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/GetWarehouseByName", ReplyAction="http://tempuri.org/IWarehouse/GetWarehouseByNameResponse")]
        InboundClient.WarehouseServiceInbound.Warehouse GetWarehouseByName(string warehouse_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/GetWarehouseByName", ReplyAction="http://tempuri.org/IWarehouse/GetWarehouseByNameResponse")]
        System.Threading.Tasks.Task<InboundClient.WarehouseServiceInbound.Warehouse> GetWarehouseByNameAsync(string warehouse_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/GetAllWarehouses", ReplyAction="http://tempuri.org/IWarehouse/GetAllWarehousesResponse")]
        InboundClient.WarehouseServiceInbound.Warehouse[] GetAllWarehouses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/GetAllWarehouses", ReplyAction="http://tempuri.org/IWarehouse/GetAllWarehousesResponse")]
        System.Threading.Tasks.Task<InboundClient.WarehouseServiceInbound.Warehouse[]> GetAllWarehousesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/UpdateWarehouse", ReplyAction="http://tempuri.org/IWarehouse/UpdateWarehouseResponse")]
        InboundClient.WarehouseServiceInbound.UpdateWarehouseResponse UpdateWarehouse(InboundClient.WarehouseServiceInbound.UpdateWarehouseRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/UpdateWarehouse", ReplyAction="http://tempuri.org/IWarehouse/UpdateWarehouseResponse")]
        System.Threading.Tasks.Task<InboundClient.WarehouseServiceInbound.UpdateWarehouseResponse> UpdateWarehouseAsync(InboundClient.WarehouseServiceInbound.UpdateWarehouseRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/CreateWarehouse", ReplyAction="http://tempuri.org/IWarehouse/CreateWarehouseResponse")]
        InboundClient.WarehouseServiceInbound.CreateWarehouseResponse CreateWarehouse(InboundClient.WarehouseServiceInbound.CreateWarehouseRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouse/CreateWarehouse", ReplyAction="http://tempuri.org/IWarehouse/CreateWarehouseResponse")]
        System.Threading.Tasks.Task<InboundClient.WarehouseServiceInbound.CreateWarehouseResponse> CreateWarehouseAsync(InboundClient.WarehouseServiceInbound.CreateWarehouseRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateWarehouse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateWarehouseRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public InboundClient.WarehouseServiceInbound.Warehouse warehouse;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public UpdateWarehouseRequest() {
        }
        
        public UpdateWarehouseRequest(InboundClient.WarehouseServiceInbound.Warehouse warehouse, string message) {
            this.warehouse = warehouse;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateWarehouseResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateWarehouseResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool UpdateWarehouseResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public UpdateWarehouseResponse() {
        }
        
        public UpdateWarehouseResponse(bool UpdateWarehouseResult, string message) {
            this.UpdateWarehouseResult = UpdateWarehouseResult;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateWarehouse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateWarehouseRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public InboundClient.WarehouseServiceInbound.Warehouse warehouse;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public CreateWarehouseRequest() {
        }
        
        public CreateWarehouseRequest(InboundClient.WarehouseServiceInbound.Warehouse warehouse, string message) {
            this.warehouse = warehouse;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateWarehouseResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateWarehouseResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool CreateWarehouseResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public CreateWarehouseResponse() {
        }
        
        public CreateWarehouseResponse(bool CreateWarehouseResult, string message) {
            this.CreateWarehouseResult = CreateWarehouseResult;
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWarehouseChannel : InboundClient.WarehouseServiceInbound.IWarehouse, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WarehouseClient : System.ServiceModel.ClientBase<InboundClient.WarehouseServiceInbound.IWarehouse>, InboundClient.WarehouseServiceInbound.IWarehouse {
        
        public WarehouseClient() {
        }
        
        public WarehouseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WarehouseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public InboundClient.WarehouseServiceInbound.Warehouse GetWarehouse(int id) {
            return base.Channel.GetWarehouse(id);
        }
        
        public System.Threading.Tasks.Task<InboundClient.WarehouseServiceInbound.Warehouse> GetWarehouseAsync(int id) {
            return base.Channel.GetWarehouseAsync(id);
        }
        
        public InboundClient.WarehouseServiceInbound.Warehouse GetWarehouseByName(string warehouse_Name) {
            return base.Channel.GetWarehouseByName(warehouse_Name);
        }
        
        public System.Threading.Tasks.Task<InboundClient.WarehouseServiceInbound.Warehouse> GetWarehouseByNameAsync(string warehouse_Name) {
            return base.Channel.GetWarehouseByNameAsync(warehouse_Name);
        }
        
        public InboundClient.WarehouseServiceInbound.Warehouse[] GetAllWarehouses() {
            return base.Channel.GetAllWarehouses();
        }
        
        public System.Threading.Tasks.Task<InboundClient.WarehouseServiceInbound.Warehouse[]> GetAllWarehousesAsync() {
            return base.Channel.GetAllWarehousesAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InboundClient.WarehouseServiceInbound.UpdateWarehouseResponse InboundClient.WarehouseServiceInbound.IWarehouse.UpdateWarehouse(InboundClient.WarehouseServiceInbound.UpdateWarehouseRequest request) {
            return base.Channel.UpdateWarehouse(request);
        }
        
        public bool UpdateWarehouse(InboundClient.WarehouseServiceInbound.Warehouse warehouse, ref string message) {
            InboundClient.WarehouseServiceInbound.UpdateWarehouseRequest inValue = new InboundClient.WarehouseServiceInbound.UpdateWarehouseRequest();
            inValue.warehouse = warehouse;
            inValue.message = message;
            InboundClient.WarehouseServiceInbound.UpdateWarehouseResponse retVal = ((InboundClient.WarehouseServiceInbound.IWarehouse)(this)).UpdateWarehouse(inValue);
            message = retVal.message;
            return retVal.UpdateWarehouseResult;
        }
        
        public System.Threading.Tasks.Task<InboundClient.WarehouseServiceInbound.UpdateWarehouseResponse> UpdateWarehouseAsync(InboundClient.WarehouseServiceInbound.UpdateWarehouseRequest request) {
            return base.Channel.UpdateWarehouseAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InboundClient.WarehouseServiceInbound.CreateWarehouseResponse InboundClient.WarehouseServiceInbound.IWarehouse.CreateWarehouse(InboundClient.WarehouseServiceInbound.CreateWarehouseRequest request) {
            return base.Channel.CreateWarehouse(request);
        }
        
        public bool CreateWarehouse(InboundClient.WarehouseServiceInbound.Warehouse warehouse, ref string message) {
            InboundClient.WarehouseServiceInbound.CreateWarehouseRequest inValue = new InboundClient.WarehouseServiceInbound.CreateWarehouseRequest();
            inValue.warehouse = warehouse;
            inValue.message = message;
            InboundClient.WarehouseServiceInbound.CreateWarehouseResponse retVal = ((InboundClient.WarehouseServiceInbound.IWarehouse)(this)).CreateWarehouse(inValue);
            message = retVal.message;
            return retVal.CreateWarehouseResult;
        }
        
        public System.Threading.Tasks.Task<InboundClient.WarehouseServiceInbound.CreateWarehouseResponse> CreateWarehouseAsync(InboundClient.WarehouseServiceInbound.CreateWarehouseRequest request) {
            return base.Channel.CreateWarehouseAsync(request);
        }
    }
}