﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace adminlte.TASGestionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TASGestionSet", Namespace="http://schemas.datacontract.org/2004/07/WebObjetos")]
    [System.SerializableAttribute()]
    public partial class TASGestionSet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity> ltTASGestionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity> ltTASGestionEliminadoField;
        
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
        public System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity> ltTASGestion {
            get {
                return this.ltTASGestionField;
            }
            set {
                if ((object.ReferenceEquals(this.ltTASGestionField, value) != true)) {
                    this.ltTASGestionField = value;
                    this.RaisePropertyChanged("ltTASGestion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity> ltTASGestionEliminado {
            get {
                return this.ltTASGestionEliminadoField;
            }
            set {
                if ((object.ReferenceEquals(this.ltTASGestionEliminadoField, value) != true)) {
                    this.ltTASGestionEliminadoField = value;
                    this.RaisePropertyChanged("ltTASGestionEliminado");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TASGestionEntity", Namespace="http://schemas.datacontract.org/2004/07/WebObjetos")]
    [System.SerializableAttribute()]
    public partial class TASGestionEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Decimal1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal Decimal2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long Entero1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long Entero2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaFinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaIniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GestionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Logico1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Logico2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ObservacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubCompaniaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Texto0Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Texto1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Texto2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Texto3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Texto4Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UClaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private adminlte.TASGestionService.Estado UEstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool USelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UUsuarioField;
        
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
        public decimal Decimal1 {
            get {
                return this.Decimal1Field;
            }
            set {
                if ((this.Decimal1Field.Equals(value) != true)) {
                    this.Decimal1Field = value;
                    this.RaisePropertyChanged("Decimal1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Decimal2 {
            get {
                return this.Decimal2Field;
            }
            set {
                if ((this.Decimal2Field.Equals(value) != true)) {
                    this.Decimal2Field = value;
                    this.RaisePropertyChanged("Decimal2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Entero1 {
            get {
                return this.Entero1Field;
            }
            set {
                if ((this.Entero1Field.Equals(value) != true)) {
                    this.Entero1Field = value;
                    this.RaisePropertyChanged("Entero1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Entero2 {
            get {
                return this.Entero2Field;
            }
            set {
                if ((this.Entero2Field.Equals(value) != true)) {
                    this.Entero2Field = value;
                    this.RaisePropertyChanged("Entero2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha1 {
            get {
                return this.Fecha1Field;
            }
            set {
                if ((this.Fecha1Field.Equals(value) != true)) {
                    this.Fecha1Field = value;
                    this.RaisePropertyChanged("Fecha1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha2 {
            get {
                return this.Fecha2Field;
            }
            set {
                if ((this.Fecha2Field.Equals(value) != true)) {
                    this.Fecha2Field = value;
                    this.RaisePropertyChanged("Fecha2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaFin {
            get {
                return this.FechaFinField;
            }
            set {
                if ((this.FechaFinField.Equals(value) != true)) {
                    this.FechaFinField = value;
                    this.RaisePropertyChanged("FechaFin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaIni {
            get {
                return this.FechaIniField;
            }
            set {
                if ((this.FechaIniField.Equals(value) != true)) {
                    this.FechaIniField = value;
                    this.RaisePropertyChanged("FechaIni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gestion {
            get {
                return this.GestionField;
            }
            set {
                if ((object.ReferenceEquals(this.GestionField, value) != true)) {
                    this.GestionField = value;
                    this.RaisePropertyChanged("Gestion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Logico1 {
            get {
                return this.Logico1Field;
            }
            set {
                if ((this.Logico1Field.Equals(value) != true)) {
                    this.Logico1Field = value;
                    this.RaisePropertyChanged("Logico1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Logico2 {
            get {
                return this.Logico2Field;
            }
            set {
                if ((this.Logico2Field.Equals(value) != true)) {
                    this.Logico2Field = value;
                    this.RaisePropertyChanged("Logico2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Observacion {
            get {
                return this.ObservacionField;
            }
            set {
                if ((object.ReferenceEquals(this.ObservacionField, value) != true)) {
                    this.ObservacionField = value;
                    this.RaisePropertyChanged("Observacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubCompania {
            get {
                return this.SubCompaniaField;
            }
            set {
                if ((object.ReferenceEquals(this.SubCompaniaField, value) != true)) {
                    this.SubCompaniaField = value;
                    this.RaisePropertyChanged("SubCompania");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Texto0 {
            get {
                return this.Texto0Field;
            }
            set {
                if ((object.ReferenceEquals(this.Texto0Field, value) != true)) {
                    this.Texto0Field = value;
                    this.RaisePropertyChanged("Texto0");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Texto1 {
            get {
                return this.Texto1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Texto1Field, value) != true)) {
                    this.Texto1Field = value;
                    this.RaisePropertyChanged("Texto1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Texto2 {
            get {
                return this.Texto2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Texto2Field, value) != true)) {
                    this.Texto2Field = value;
                    this.RaisePropertyChanged("Texto2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Texto3 {
            get {
                return this.Texto3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Texto3Field, value) != true)) {
                    this.Texto3Field = value;
                    this.RaisePropertyChanged("Texto3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Texto4 {
            get {
                return this.Texto4Field;
            }
            set {
                if ((object.ReferenceEquals(this.Texto4Field, value) != true)) {
                    this.Texto4Field = value;
                    this.RaisePropertyChanged("Texto4");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UClase {
            get {
                return this.UClaseField;
            }
            set {
                if ((object.ReferenceEquals(this.UClaseField, value) != true)) {
                    this.UClaseField = value;
                    this.RaisePropertyChanged("UClase");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public adminlte.TASGestionService.Estado UEstado {
            get {
                return this.UEstadoField;
            }
            set {
                if ((this.UEstadoField.Equals(value) != true)) {
                    this.UEstadoField = value;
                    this.RaisePropertyChanged("UEstado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool USel {
            get {
                return this.USelField;
            }
            set {
                if ((this.USelField.Equals(value) != true)) {
                    this.USelField = value;
                    this.RaisePropertyChanged("USel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UUsuario {
            get {
                return this.UUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.UUsuarioField, value) != true)) {
                    this.UUsuarioField = value;
                    this.RaisePropertyChanged("UUsuario");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Estado", Namespace="http://schemas.datacontract.org/2004/07/WebObjetos")]
    public enum Estado : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Added = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unchanged = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Modified = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Deleted = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TASGestionService.TASGestionInterface")]
    public interface TASGestionInterface {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebNuevo", ReplyAction="http://tempuri.org/TASGestionInterface/WebNuevoResponse")]
        adminlte.TASGestionService.TASGestionSet WebNuevo(string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebNuevo", ReplyAction="http://tempuri.org/TASGestionInterface/WebNuevoResponse")]
        System.Threading.Tasks.Task<adminlte.TASGestionService.TASGestionSet> WebNuevoAsync(string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebGuardar", ReplyAction="http://tempuri.org/TASGestionInterface/WebGuardarResponse")]
        long WebGuardar(adminlte.TASGestionService.TASGestionSet setTASGestion, bool EsNuevo, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebGuardar", ReplyAction="http://tempuri.org/TASGestionInterface/WebGuardarResponse")]
        System.Threading.Tasks.Task<long> WebGuardarAsync(adminlte.TASGestionService.TASGestionSet setTASGestion, bool EsNuevo, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebEliminar", ReplyAction="http://tempuri.org/TASGestionInterface/WebEliminarResponse")]
        long WebEliminar(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebEliminar", ReplyAction="http://tempuri.org/TASGestionInterface/WebEliminarResponse")]
        System.Threading.Tasks.Task<long> WebEliminarAsync(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebEliminarDetalle", ReplyAction="http://tempuri.org/TASGestionInterface/WebEliminarDetalleResponse")]
        long WebEliminarDetalle(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebEliminarDetalle", ReplyAction="http://tempuri.org/TASGestionInterface/WebEliminarDetalleResponse")]
        System.Threading.Tasks.Task<long> WebEliminarDetalleAsync(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebSeleccionar", ReplyAction="http://tempuri.org/TASGestionInterface/WebSeleccionarResponse")]
        adminlte.TASGestionService.TASGestionSet WebSeleccionar(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebSeleccionar", ReplyAction="http://tempuri.org/TASGestionInterface/WebSeleccionarResponse")]
        System.Threading.Tasks.Task<adminlte.TASGestionService.TASGestionSet> WebSeleccionarAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebRecalcular", ReplyAction="http://tempuri.org/TASGestionInterface/WebRecalcularResponse")]
        adminlte.TASGestionService.TASGestionSet WebRecalcular(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebRecalcular", ReplyAction="http://tempuri.org/TASGestionInterface/WebRecalcularResponse")]
        System.Threading.Tasks.Task<adminlte.TASGestionService.TASGestionSet> WebRecalcularAsync(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionBloquear", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionBloquearResponse")]
        long WebTASGestionBloquear(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionBloquear", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionBloquearResponse")]
        System.Threading.Tasks.Task<long> WebTASGestionBloquearAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionDesbloquear", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionDesbloquearResponse")]
        long WebTASGestionDesbloquear(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionDesbloquear", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionDesbloquearResponse")]
        System.Threading.Tasks.Task<long> WebTASGestionDesbloquearAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionEsBloqueadoPor", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionEsBloqueadoPorResponse")]
        string WebTASGestionEsBloqueadoPor(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionEsBloqueadoPor", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionEsBloqueadoPorResponse")]
        System.Threading.Tasks.Task<string> WebTASGestionEsBloqueadoPorAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionEsBloqueado", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionEsBloqueadoResponse")]
        bool WebTASGestionEsBloqueado(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionEsBloqueado", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionEsBloqueadoResponse")]
        System.Threading.Tasks.Task<bool> WebTASGestionEsBloqueadoAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionarTodo", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionarTodoResponse")]
        System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity> WebTASGestionSeleccionarTodo(string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionarTodo", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionarTodoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity>> WebTASGestionSeleccionarTodoAsync(string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionar", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionarResponse")]
        System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity> WebTASGestionSeleccionar(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionar", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionarResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity>> WebTASGestionSeleccionarAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionarXSubCompania", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionarXSubCompaniaRespon" +
            "se")]
        System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity> WebTASGestionSeleccionarXSubCompania(string SubCompania, string strAKASesion, string strAKASubCompania);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionarXSubCompania", ReplyAction="http://tempuri.org/TASGestionInterface/WebTASGestionSeleccionarXSubCompaniaRespon" +
            "se")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity>> WebTASGestionSeleccionarXSubCompaniaAsync(string SubCompania, string strAKASesion, string strAKASubCompania);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TASGestionInterfaceChannel : adminlte.TASGestionService.TASGestionInterface, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TASGestionInterfaceClient : System.ServiceModel.ClientBase<adminlte.TASGestionService.TASGestionInterface>, adminlte.TASGestionService.TASGestionInterface {
        
        public TASGestionInterfaceClient() {
        }
        
        public TASGestionInterfaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TASGestionInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TASGestionInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TASGestionInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public adminlte.TASGestionService.TASGestionSet WebNuevo(string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebNuevo(strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<adminlte.TASGestionService.TASGestionSet> WebNuevoAsync(string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebNuevoAsync(strAKASesion, strAKASubCompania);
        }
        
        public long WebGuardar(adminlte.TASGestionService.TASGestionSet setTASGestion, bool EsNuevo, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebGuardar(setTASGestion, EsNuevo, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<long> WebGuardarAsync(adminlte.TASGestionService.TASGestionSet setTASGestion, bool EsNuevo, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebGuardarAsync(setTASGestion, EsNuevo, strAKASesion, strAKASubCompania);
        }
        
        public long WebEliminar(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebEliminar(setTASGestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<long> WebEliminarAsync(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebEliminarAsync(setTASGestion, strAKASesion, strAKASubCompania);
        }
        
        public long WebEliminarDetalle(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebEliminarDetalle(setTASGestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<long> WebEliminarDetalleAsync(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebEliminarDetalleAsync(setTASGestion, strAKASesion, strAKASubCompania);
        }
        
        public adminlte.TASGestionService.TASGestionSet WebSeleccionar(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebSeleccionar(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<adminlte.TASGestionService.TASGestionSet> WebSeleccionarAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebSeleccionarAsync(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public adminlte.TASGestionService.TASGestionSet WebRecalcular(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebRecalcular(setTASGestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<adminlte.TASGestionService.TASGestionSet> WebRecalcularAsync(adminlte.TASGestionService.TASGestionSet setTASGestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebRecalcularAsync(setTASGestion, strAKASesion, strAKASubCompania);
        }
        
        public long WebTASGestionBloquear(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionBloquear(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<long> WebTASGestionBloquearAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionBloquearAsync(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public long WebTASGestionDesbloquear(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionDesbloquear(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<long> WebTASGestionDesbloquearAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionDesbloquearAsync(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public string WebTASGestionEsBloqueadoPor(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionEsBloqueadoPor(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<string> WebTASGestionEsBloqueadoPorAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionEsBloqueadoPorAsync(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public bool WebTASGestionEsBloqueado(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionEsBloqueado(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<bool> WebTASGestionEsBloqueadoAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionEsBloqueadoAsync(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity> WebTASGestionSeleccionarTodo(string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionSeleccionarTodo(strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity>> WebTASGestionSeleccionarTodoAsync(string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionSeleccionarTodoAsync(strAKASesion, strAKASubCompania);
        }
        
        public System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity> WebTASGestionSeleccionar(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionSeleccionar(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity>> WebTASGestionSeleccionarAsync(string SubCompania, string Gestion, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionSeleccionarAsync(SubCompania, Gestion, strAKASesion, strAKASubCompania);
        }
        
        public System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity> WebTASGestionSeleccionarXSubCompania(string SubCompania, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionSeleccionarXSubCompania(SubCompania, strAKASesion, strAKASubCompania);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<adminlte.TASGestionService.TASGestionEntity>> WebTASGestionSeleccionarXSubCompaniaAsync(string SubCompania, string strAKASesion, string strAKASubCompania) {
            return base.Channel.WebTASGestionSeleccionarXSubCompaniaAsync(SubCompania, strAKASesion, strAKASubCompania);
        }
    }
}
