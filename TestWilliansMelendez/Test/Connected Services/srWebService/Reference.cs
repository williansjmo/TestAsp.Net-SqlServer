﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.srWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CORRESPONSALES", Namespace="http://schemas.datacontract.org/2004/07/NCapas")]
    [System.SerializableAttribute()]
    public partial class CORRESPONSALES : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int COR_CORRESPONSAL_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string COR_NOMBREField;
        
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
        public int COR_CORRESPONSAL_ID {
            get {
                return this.COR_CORRESPONSAL_IDField;
            }
            set {
                if ((this.COR_CORRESPONSAL_IDField.Equals(value) != true)) {
                    this.COR_CORRESPONSAL_IDField = value;
                    this.RaisePropertyChanged("COR_CORRESPONSAL_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string COR_NOMBRE {
            get {
                return this.COR_NOMBREField;
            }
            set {
                if ((object.ReferenceEquals(this.COR_NOMBREField, value) != true)) {
                    this.COR_NOMBREField = value;
                    this.RaisePropertyChanged("COR_NOMBRE");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OFICINAS", Namespace="http://schemas.datacontract.org/2004/07/NCapas")]
    [System.SerializableAttribute()]
    public partial class OFICINAS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OFI_CORRESPONSAL_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OFI_NOMBREField;
        
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
        public int OFI_CORRESPONSAL_ID {
            get {
                return this.OFI_CORRESPONSAL_IDField;
            }
            set {
                if ((this.OFI_CORRESPONSAL_IDField.Equals(value) != true)) {
                    this.OFI_CORRESPONSAL_IDField = value;
                    this.RaisePropertyChanged("OFI_CORRESPONSAL_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OFI_NOMBRE {
            get {
                return this.OFI_NOMBREField;
            }
            set {
                if ((object.ReferenceEquals(this.OFI_NOMBREField, value) != true)) {
                    this.OFI_NOMBREField = value;
                    this.RaisePropertyChanged("OFI_NOMBRE");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srWebService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CORRESPONSALES", ReplyAction="http://tempuri.org/IService1/CORRESPONSALESResponse")]
        Test.srWebService.CORRESPONSALES[] CORRESPONSALES();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CORRESPONSALES", ReplyAction="http://tempuri.org/IService1/CORRESPONSALESResponse")]
        System.Threading.Tasks.Task<Test.srWebService.CORRESPONSALES[]> CORRESPONSALESAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OFICINAS", ReplyAction="http://tempuri.org/IService1/OFICINASResponse")]
        Test.srWebService.OFICINAS[] OFICINAS(int OFI_CORRESPONSAL_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/OFICINAS", ReplyAction="http://tempuri.org/IService1/OFICINASResponse")]
        System.Threading.Tasks.Task<Test.srWebService.OFICINAS[]> OFICINASAsync(int OFI_CORRESPONSAL_ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Test.srWebService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Test.srWebService.IService1>, Test.srWebService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Test.srWebService.CORRESPONSALES[] CORRESPONSALES() {
            return base.Channel.CORRESPONSALES();
        }
        
        public System.Threading.Tasks.Task<Test.srWebService.CORRESPONSALES[]> CORRESPONSALESAsync() {
            return base.Channel.CORRESPONSALESAsync();
        }
        
        public Test.srWebService.OFICINAS[] OFICINAS(int OFI_CORRESPONSAL_ID) {
            return base.Channel.OFICINAS(OFI_CORRESPONSAL_ID);
        }
        
        public System.Threading.Tasks.Task<Test.srWebService.OFICINAS[]> OFICINASAsync(int OFI_CORRESPONSAL_ID) {
            return base.Channel.OFICINASAsync(OFI_CORRESPONSAL_ID);
        }
    }
}
