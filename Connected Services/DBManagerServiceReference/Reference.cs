﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeltaManager.DBManagerServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Booking", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaDBManager.BookingNS")]
    [System.SerializableAttribute()]
    public partial class Booking : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DeltaManager.DBManagerServiceReference.Car BookedCarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DeltaManager.DBManagerServiceReference.User BookerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ReturnedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartField;
        
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
        public DeltaManager.DBManagerServiceReference.Car BookedCar {
            get {
                return this.BookedCarField;
            }
            set {
                if ((object.ReferenceEquals(this.BookedCarField, value) != true)) {
                    this.BookedCarField = value;
                    this.RaisePropertyChanged("BookedCar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DeltaManager.DBManagerServiceReference.User Booker {
            get {
                return this.BookerField;
            }
            set {
                if ((object.ReferenceEquals(this.BookerField, value) != true)) {
                    this.BookerField = value;
                    this.RaisePropertyChanged("Booker");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime End {
            get {
                return this.EndField;
            }
            set {
                if ((this.EndField.Equals(value) != true)) {
                    this.EndField = value;
                    this.RaisePropertyChanged("End");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Returned {
            get {
                return this.ReturnedField;
            }
            set {
                if ((this.ReturnedField.Equals(value) != true)) {
                    this.ReturnedField = value;
                    this.RaisePropertyChanged("Returned");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Start {
            get {
                return this.StartField;
            }
            set {
                if ((this.StartField.Equals(value) != true)) {
                    this.StartField = value;
                    this.RaisePropertyChanged("Start");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaDBManager.CarNS")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BurnedLitersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KilometersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlateNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public int BurnedLiters {
            get {
                return this.BurnedLitersField;
            }
            set {
                if ((this.BurnedLitersField.Equals(value) != true)) {
                    this.BurnedLitersField = value;
                    this.RaisePropertyChanged("BurnedLiters");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Kilometers {
            get {
                return this.KilometersField;
            }
            set {
                if ((this.KilometersField.Equals(value) != true)) {
                    this.KilometersField = value;
                    this.RaisePropertyChanged("Kilometers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Make {
            get {
                return this.MakeField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeField, value) != true)) {
                    this.MakeField = value;
                    this.RaisePropertyChanged("Make");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlateNumber {
            get {
                return this.PlateNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PlateNumberField, value) != true)) {
                    this.PlateNumberField = value;
                    this.RaisePropertyChanged("PlateNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaDBManager.UserNS")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LicenseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LicenseExpirationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short LicensePointsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordHashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isAdminField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string License {
            get {
                return this.LicenseField;
            }
            set {
                if ((object.ReferenceEquals(this.LicenseField, value) != true)) {
                    this.LicenseField = value;
                    this.RaisePropertyChanged("License");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LicenseExpiration {
            get {
                return this.LicenseExpirationField;
            }
            set {
                if ((this.LicenseExpirationField.Equals(value) != true)) {
                    this.LicenseExpirationField = value;
                    this.RaisePropertyChanged("LicenseExpiration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short LicensePoints {
            get {
                return this.LicensePointsField;
            }
            set {
                if ((this.LicensePointsField.Equals(value) != true)) {
                    this.LicensePointsField = value;
                    this.RaisePropertyChanged("LicensePoints");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordHash {
            get {
                return this.PasswordHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordHashField, value) != true)) {
                    this.PasswordHashField = value;
                    this.RaisePropertyChanged("PasswordHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isAdmin {
            get {
                return this.isAdminField;
            }
            set {
                if ((this.isAdminField.Equals(value) != true)) {
                    this.isAdminField = value;
                    this.RaisePropertyChanged("isAdmin");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Report", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaDBManager.ReportNS")]
    [System.SerializableAttribute()]
    public partial class Report : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DeltaManager.DBManagerServiceReference.Booking ReportedBookingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DeltaManager.DBManagerServiceReference.Booking ReportedBooking {
            get {
                return this.ReportedBookingField;
            }
            set {
                if ((object.ReferenceEquals(this.ReportedBookingField, value) != true)) {
                    this.ReportedBookingField = value;
                    this.RaisePropertyChanged("ReportedBooking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Service", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaDBManager.ServiceNS")]
    [System.SerializableAttribute()]
    public partial class Service : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KilometersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DeltaManager.DBManagerServiceReference.Car ServicedCarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float TotalSpentField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Kilometers {
            get {
                return this.KilometersField;
            }
            set {
                if ((this.KilometersField.Equals(value) != true)) {
                    this.KilometersField = value;
                    this.RaisePropertyChanged("Kilometers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DeltaManager.DBManagerServiceReference.Car ServicedCar {
            get {
                return this.ServicedCarField;
            }
            set {
                if ((object.ReferenceEquals(this.ServicedCarField, value) != true)) {
                    this.ServicedCarField = value;
                    this.RaisePropertyChanged("ServicedCar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float TotalSpent {
            get {
                return this.TotalSpentField;
            }
            set {
                if ((this.TotalSpentField.Equals(value) != true)) {
                    this.TotalSpentField = value;
                    this.RaisePropertyChanged("TotalSpent");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="Delta.DeltaDBManager", ConfigurationName="DBManagerServiceReference.DBManagerInterface")]
    public interface DBManagerInterface {
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/BookCar", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/BookCarResponse")]
        bool BookCar(DeltaManager.DBManagerServiceReference.Booking booking);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/DeleteBooking", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/DeleteBookingResponse")]
        bool DeleteBooking(DeltaManager.DBManagerServiceReference.Booking booking);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/UpdateBooking", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/UpdateBookingResponse")]
        bool UpdateBooking(DeltaManager.DBManagerServiceReference.Booking NewBooking);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/GetBookingByID", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/GetBookingByIDResponse")]
        DeltaManager.DBManagerServiceReference.Booking GetBookingByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/AddCar", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/AddCarResponse")]
        bool AddCar(DeltaManager.DBManagerServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/DeleteCar", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/DeleteCarResponse")]
        bool DeleteCar(DeltaManager.DBManagerServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/GetCars", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/GetCarsResponse")]
        DeltaManager.DBManagerServiceReference.Car[] GetCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/UpdateCar", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/UpdateCarResponse")]
        bool UpdateCar(DeltaManager.DBManagerServiceReference.Car updatableCar);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/GetAvailableCars", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/GetAvailableCarsResponse")]
        DeltaManager.DBManagerServiceReference.Car[] GetAvailableCars(System.DateTime Start, System.DateTime End);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/AddReport", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/AddReportResponse")]
        bool AddReport(DeltaManager.DBManagerServiceReference.Report report);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/DeleteReport", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/DeleteReportResponse")]
        bool DeleteReport(DeltaManager.DBManagerServiceReference.Report report);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/GetReportByID", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/GetReportByIDResponse")]
        DeltaManager.DBManagerServiceReference.Report GetReportByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/GetReportsForCar", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/GetReportsForCarResponse")]
        DeltaManager.DBManagerServiceReference.Report[] GetReportsForCar(DeltaManager.DBManagerServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/GetUserByEmail", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/GetUserByEmailResponse")]
        DeltaManager.DBManagerServiceReference.User GetUserByEmail(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/AddUser", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/AddUserResponse")]
        bool AddUser(DeltaManager.DBManagerServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/DeleteUser", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/DeleteUserResponse")]
        bool DeleteUser(DeltaManager.DBManagerServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/GetUsers", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/GetUsersResponse")]
        DeltaManager.DBManagerServiceReference.User[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/AddService", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/AddServiceResponse")]
        bool AddService(DeltaManager.DBManagerServiceReference.Service service);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/DeleteService", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/DeleteServiceResponse")]
        bool DeleteService(DeltaManager.DBManagerServiceReference.Service service);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaDBManager/DBManagerInterface/UpdateService", ReplyAction="Delta.DeltaDBManager/DBManagerInterface/UpdateServiceResponse")]
        bool UpdateService(DeltaManager.DBManagerServiceReference.Service service);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DBManagerInterfaceChannel : DeltaManager.DBManagerServiceReference.DBManagerInterface, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBManagerInterfaceClient : System.ServiceModel.ClientBase<DeltaManager.DBManagerServiceReference.DBManagerInterface>, DeltaManager.DBManagerServiceReference.DBManagerInterface {
        
        public DBManagerInterfaceClient() {
        }
        
        public DBManagerInterfaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBManagerInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBManagerInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBManagerInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool BookCar(DeltaManager.DBManagerServiceReference.Booking booking) {
            return base.Channel.BookCar(booking);
        }
        
        public bool DeleteBooking(DeltaManager.DBManagerServiceReference.Booking booking) {
            return base.Channel.DeleteBooking(booking);
        }
        
        public bool UpdateBooking(DeltaManager.DBManagerServiceReference.Booking NewBooking) {
            return base.Channel.UpdateBooking(NewBooking);
        }
        
        public DeltaManager.DBManagerServiceReference.Booking GetBookingByID(int ID) {
            return base.Channel.GetBookingByID(ID);
        }
        
        public bool AddCar(DeltaManager.DBManagerServiceReference.Car car) {
            return base.Channel.AddCar(car);
        }
        
        public bool DeleteCar(DeltaManager.DBManagerServiceReference.Car car) {
            return base.Channel.DeleteCar(car);
        }
        
        public DeltaManager.DBManagerServiceReference.Car[] GetCars() {
            return base.Channel.GetCars();
        }
        
        public bool UpdateCar(DeltaManager.DBManagerServiceReference.Car updatableCar) {
            return base.Channel.UpdateCar(updatableCar);
        }
        
        public DeltaManager.DBManagerServiceReference.Car[] GetAvailableCars(System.DateTime Start, System.DateTime End) {
            return base.Channel.GetAvailableCars(Start, End);
        }
        
        public bool AddReport(DeltaManager.DBManagerServiceReference.Report report) {
            return base.Channel.AddReport(report);
        }
        
        public bool DeleteReport(DeltaManager.DBManagerServiceReference.Report report) {
            return base.Channel.DeleteReport(report);
        }
        
        public DeltaManager.DBManagerServiceReference.Report GetReportByID(int ID) {
            return base.Channel.GetReportByID(ID);
        }
        
        public DeltaManager.DBManagerServiceReference.Report[] GetReportsForCar(DeltaManager.DBManagerServiceReference.Car car) {
            return base.Channel.GetReportsForCar(car);
        }
        
        public DeltaManager.DBManagerServiceReference.User GetUserByEmail(string Email) {
            return base.Channel.GetUserByEmail(Email);
        }
        
        public bool AddUser(DeltaManager.DBManagerServiceReference.User user) {
            return base.Channel.AddUser(user);
        }
        
        public bool DeleteUser(DeltaManager.DBManagerServiceReference.User user) {
            return base.Channel.DeleteUser(user);
        }
        
        public DeltaManager.DBManagerServiceReference.User[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public bool AddService(DeltaManager.DBManagerServiceReference.Service service) {
            return base.Channel.AddService(service);
        }
        
        public bool DeleteService(DeltaManager.DBManagerServiceReference.Service service) {
            return base.Channel.DeleteService(service);
        }
        
        public bool UpdateService(DeltaManager.DBManagerServiceReference.Service service) {
            return base.Channel.UpdateService(service);
        }
    }
}