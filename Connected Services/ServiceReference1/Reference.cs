﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", ConfigurationName="ServiceReference1.Z_ABRANTES_SERVICES")]
    public interface Z_ABRANTES_SERVICES {
        
        // CODEGEN: Gerando contrato de mensagem porque a operação ZRemotListsample não é RPC nem documento codificado.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:soap:functions:mc-style:Z_ABRANTES_SERVICES:ZRemotListsa" +
            "mpleRequest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebApplication3.ServiceReference1.ZRemotListsampleResponse1 ZRemotListsample(WebApplication3.ServiceReference1.ZRemotListsampleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:soap:functions:mc-style:Z_ABRANTES_SERVICES:ZRemotListsa" +
            "mpleRequest", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication3.ServiceReference1.ZRemotListsampleResponse1> ZRemotListsampleAsync(WebApplication3.ServiceReference1.ZRemotListsampleRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque a operação ZUpdateSyncSample não é RPC nem documento codificado.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:soap:functions:mc-style:Z_ABRANTES_SERVICES:ZUpdateSyncS" +
            "ampleRequest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebApplication3.ServiceReference1.ZUpdateSyncSampleResponse1 ZUpdateSyncSample(WebApplication3.ServiceReference1.ZUpdateSyncSampleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:soap:functions:mc-style:Z_ABRANTES_SERVICES:ZUpdateSyncS" +
            "ampleRequest", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication3.ServiceReference1.ZUpdateSyncSampleResponse1> ZUpdateSyncSampleAsync(WebApplication3.ServiceReference1.ZUpdateSyncSampleRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZRemotListsample : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zsamples : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int regIdField;
        
        private string loteField;
        
        private string codProdutoField;
        
        private byte isSyncField;
        
        private string dataSyncField;
        
        private string dataRegistroField;
        
        private int qtdElementsField;
        
        private decimal priceAnalysisField;
        
        private string moedaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int RegId {
            get {
                return this.regIdField;
            }
            set {
                this.regIdField = value;
                this.RaisePropertyChanged("RegId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Lote {
            get {
                return this.loteField;
            }
            set {
                this.loteField = value;
                this.RaisePropertyChanged("Lote");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CodProduto {
            get {
                return this.codProdutoField;
            }
            set {
                this.codProdutoField = value;
                this.RaisePropertyChanged("CodProduto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public byte IsSync {
            get {
                return this.isSyncField;
            }
            set {
                this.isSyncField = value;
                this.RaisePropertyChanged("IsSync");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string DataSync {
            get {
                return this.dataSyncField;
            }
            set {
                this.dataSyncField = value;
                this.RaisePropertyChanged("DataSync");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string DataRegistro {
            get {
                return this.dataRegistroField;
            }
            set {
                this.dataRegistroField = value;
                this.RaisePropertyChanged("DataRegistro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int QtdElements {
            get {
                return this.qtdElementsField;
            }
            set {
                this.qtdElementsField = value;
                this.RaisePropertyChanged("QtdElements");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public decimal PriceAnalysis {
            get {
                return this.priceAnalysisField;
            }
            set {
                this.priceAnalysisField = value;
                this.RaisePropertyChanged("PriceAnalysis");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string Moeda {
            get {
                return this.moedaField;
            }
            set {
                this.moedaField = value;
                this.RaisePropertyChanged("Moeda");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZRemotListsampleResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Zsamples[] outField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zsamples[] Out {
            get {
                return this.outField;
            }
            set {
                this.outField = value;
                this.RaisePropertyChanged("Out");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZRemotListsampleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", Order=0)]
        public WebApplication3.ServiceReference1.ZRemotListsample ZRemotListsample;
        
        public ZRemotListsampleRequest() {
        }
        
        public ZRemotListsampleRequest(WebApplication3.ServiceReference1.ZRemotListsample ZRemotListsample) {
            this.ZRemotListsample = ZRemotListsample;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZRemotListsampleResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", Order=0)]
        public WebApplication3.ServiceReference1.ZRemotListsampleResponse ZRemotListsampleResponse;
        
        public ZRemotListsampleResponse1() {
        }
        
        public ZRemotListsampleResponse1(WebApplication3.ServiceReference1.ZRemotListsampleResponse ZRemotListsampleResponse) {
            this.ZRemotListsampleResponse = ZRemotListsampleResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZUpdateSyncSample : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string loteField;
        
        private int regIdField;
        
        private byte syncField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Lote {
            get {
                return this.loteField;
            }
            set {
                this.loteField = value;
                this.RaisePropertyChanged("Lote");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int RegId {
            get {
                return this.regIdField;
            }
            set {
                this.regIdField = value;
                this.RaisePropertyChanged("RegId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public byte Sync {
            get {
                return this.syncField;
            }
            set {
                this.syncField = value;
                this.RaisePropertyChanged("Sync");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZUpdateSyncSampleResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte doneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public byte Done {
            get {
                return this.doneField;
            }
            set {
                this.doneField = value;
                this.RaisePropertyChanged("Done");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZUpdateSyncSampleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", Order=0)]
        public WebApplication3.ServiceReference1.ZUpdateSyncSample ZUpdateSyncSample;
        
        public ZUpdateSyncSampleRequest() {
        }
        
        public ZUpdateSyncSampleRequest(WebApplication3.ServiceReference1.ZUpdateSyncSample ZUpdateSyncSample) {
            this.ZUpdateSyncSample = ZUpdateSyncSample;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZUpdateSyncSampleResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", Order=0)]
        public WebApplication3.ServiceReference1.ZUpdateSyncSampleResponse ZUpdateSyncSampleResponse;
        
        public ZUpdateSyncSampleResponse1() {
        }
        
        public ZUpdateSyncSampleResponse1(WebApplication3.ServiceReference1.ZUpdateSyncSampleResponse ZUpdateSyncSampleResponse) {
            this.ZUpdateSyncSampleResponse = ZUpdateSyncSampleResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Z_ABRANTES_SERVICESChannel : WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Z_ABRANTES_SERVICESClient : System.ServiceModel.ClientBase<WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES>, WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES {
        
        public Z_ABRANTES_SERVICESClient() {
        }
        
        public Z_ABRANTES_SERVICESClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Z_ABRANTES_SERVICESClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Z_ABRANTES_SERVICESClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Z_ABRANTES_SERVICESClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication3.ServiceReference1.ZRemotListsampleResponse1 WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES.ZRemotListsample(WebApplication3.ServiceReference1.ZRemotListsampleRequest request) {
            return base.Channel.ZRemotListsample(request);
        }
        
        public WebApplication3.ServiceReference1.ZRemotListsampleResponse ZRemotListsample(WebApplication3.ServiceReference1.ZRemotListsample ZRemotListsample1) {
            WebApplication3.ServiceReference1.ZRemotListsampleRequest inValue = new WebApplication3.ServiceReference1.ZRemotListsampleRequest();
            inValue.ZRemotListsample = ZRemotListsample1;
            WebApplication3.ServiceReference1.ZRemotListsampleResponse1 retVal = ((WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES)(this)).ZRemotListsample(inValue);
            return retVal.ZRemotListsampleResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication3.ServiceReference1.ZRemotListsampleResponse1> WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES.ZRemotListsampleAsync(WebApplication3.ServiceReference1.ZRemotListsampleRequest request) {
            return base.Channel.ZRemotListsampleAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication3.ServiceReference1.ZRemotListsampleResponse1> ZRemotListsampleAsync(WebApplication3.ServiceReference1.ZRemotListsample ZRemotListsample) {
            WebApplication3.ServiceReference1.ZRemotListsampleRequest inValue = new WebApplication3.ServiceReference1.ZRemotListsampleRequest();
            inValue.ZRemotListsample = ZRemotListsample;
            return ((WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES)(this)).ZRemotListsampleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication3.ServiceReference1.ZUpdateSyncSampleResponse1 WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES.ZUpdateSyncSample(WebApplication3.ServiceReference1.ZUpdateSyncSampleRequest request) {
            return base.Channel.ZUpdateSyncSample(request);
        }
        
        public WebApplication3.ServiceReference1.ZUpdateSyncSampleResponse ZUpdateSyncSample(WebApplication3.ServiceReference1.ZUpdateSyncSample ZUpdateSyncSample1) {
            WebApplication3.ServiceReference1.ZUpdateSyncSampleRequest inValue = new WebApplication3.ServiceReference1.ZUpdateSyncSampleRequest();
            inValue.ZUpdateSyncSample = ZUpdateSyncSample1;
            WebApplication3.ServiceReference1.ZUpdateSyncSampleResponse1 retVal = ((WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES)(this)).ZUpdateSyncSample(inValue);
            return retVal.ZUpdateSyncSampleResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication3.ServiceReference1.ZUpdateSyncSampleResponse1> WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES.ZUpdateSyncSampleAsync(WebApplication3.ServiceReference1.ZUpdateSyncSampleRequest request) {
            return base.Channel.ZUpdateSyncSampleAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication3.ServiceReference1.ZUpdateSyncSampleResponse1> ZUpdateSyncSampleAsync(WebApplication3.ServiceReference1.ZUpdateSyncSample ZUpdateSyncSample) {
            WebApplication3.ServiceReference1.ZUpdateSyncSampleRequest inValue = new WebApplication3.ServiceReference1.ZUpdateSyncSampleRequest();
            inValue.ZUpdateSyncSample = ZUpdateSyncSample;
            return ((WebApplication3.ServiceReference1.Z_ABRANTES_SERVICES)(this)).ZUpdateSyncSampleAsync(inValue);
        }
    }
}
