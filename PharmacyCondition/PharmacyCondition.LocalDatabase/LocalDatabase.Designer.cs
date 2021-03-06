﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("LocalDatabaseModel", "FromBadProductsToSession", "Session", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(PharmacyCondition.LocalDatabase.Session), "BadProduct", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PharmacyCondition.LocalDatabase.BadProduct), true)]
[assembly: EdmRelationshipAttribute("LocalDatabaseModel", "FromGoodProductsToSession", "Session", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(PharmacyCondition.LocalDatabase.Session), "GoodProduct", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PharmacyCondition.LocalDatabase.GoodProduct), true)]

#endregion

namespace PharmacyCondition.LocalDatabase
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LocalDatabaseEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LocalDatabaseEntities object using the connection string found in the 'LocalDatabaseEntities' section of the application configuration file.
        /// </summary>
        public LocalDatabaseEntities() : base("name=LocalDatabaseEntities", "LocalDatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LocalDatabaseEntities object.
        /// </summary>
        public LocalDatabaseEntities(string connectionString) : base(connectionString, "LocalDatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LocalDatabaseEntities object.
        /// </summary>
        public LocalDatabaseEntities(EntityConnection connection) : base(connection, "LocalDatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<BadProduct> BadProducts
        {
            get
            {
                if ((_BadProducts == null))
                {
                    _BadProducts = base.CreateObjectSet<BadProduct>("BadProducts");
                }
                return _BadProducts;
            }
        }
        private ObjectSet<BadProduct> _BadProducts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<GoodProduct> GoodProducts
        {
            get
            {
                if ((_GoodProducts == null))
                {
                    _GoodProducts = base.CreateObjectSet<GoodProduct>("GoodProducts");
                }
                return _GoodProducts;
            }
        }
        private ObjectSet<GoodProduct> _GoodProducts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Session> Sessions
        {
            get
            {
                if ((_Sessions == null))
                {
                    _Sessions = base.CreateObjectSet<Session>("Sessions");
                }
                return _Sessions;
            }
        }
        private ObjectSet<Session> _Sessions;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the BadProducts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBadProducts(BadProduct badProduct)
        {
            base.AddObject("BadProducts", badProduct);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the GoodProducts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToGoodProducts(GoodProduct goodProduct)
        {
            base.AddObject("GoodProducts", goodProduct);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Sessions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSessions(Session session)
        {
            base.AddObject("Sessions", session);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LocalDatabaseModel", Name="BadProduct")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class BadProduct : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new BadProduct object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="sessionID">Initial value of the SessionID property.</param>
        public static BadProduct CreateBadProduct(global::System.Guid id, global::System.Guid sessionID)
        {
            BadProduct badProduct = new BadProduct();
            badProduct.ID = id;
            badProduct.SessionID = sessionID;
            return badProduct;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Guid _ID;
        partial void OnIDChanging(global::System.Guid value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid SessionID
        {
            get
            {
                return _SessionID;
            }
            set
            {
                OnSessionIDChanging(value);
                ReportPropertyChanging("SessionID");
                _SessionID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SessionID");
                OnSessionIDChanged();
            }
        }
        private global::System.Guid _SessionID;
        partial void OnSessionIDChanging(global::System.Guid value);
        partial void OnSessionIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductId
        {
            get
            {
                return _ProductId;
            }
            set
            {
                OnProductIdChanging(value);
                ReportPropertyChanging("ProductId");
                _ProductId = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductId");
                OnProductIdChanged();
            }
        }
        private global::System.String _ProductId;
        partial void OnProductIdChanging(global::System.String value);
        partial void OnProductIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductDirtyBarcode
        {
            get
            {
                return _ProductDirtyBarcode;
            }
            set
            {
                OnProductDirtyBarcodeChanging(value);
                ReportPropertyChanging("ProductDirtyBarcode");
                _ProductDirtyBarcode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductDirtyBarcode");
                OnProductDirtyBarcodeChanged();
            }
        }
        private global::System.String _ProductDirtyBarcode;
        partial void OnProductDirtyBarcodeChanging(global::System.String value);
        partial void OnProductDirtyBarcodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductCleanBarcode
        {
            get
            {
                return _ProductCleanBarcode;
            }
            set
            {
                OnProductCleanBarcodeChanging(value);
                ReportPropertyChanging("ProductCleanBarcode");
                _ProductCleanBarcode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductCleanBarcode");
                OnProductCleanBarcodeChanged();
            }
        }
        private global::System.String _ProductCleanBarcode;
        partial void OnProductCleanBarcodeChanging(global::System.String value);
        partial void OnProductCleanBarcodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductBarcodeType
        {
            get
            {
                return _ProductBarcodeType;
            }
            set
            {
                OnProductBarcodeTypeChanging(value);
                ReportPropertyChanging("ProductBarcodeType");
                _ProductBarcodeType = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductBarcodeType");
                OnProductBarcodeTypeChanged();
            }
        }
        private global::System.String _ProductBarcodeType;
        partial void OnProductBarcodeTypeChanging(global::System.String value);
        partial void OnProductBarcodeTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductQuantityCounted
        {
            get
            {
                return _ProductQuantityCounted;
            }
            set
            {
                OnProductQuantityCountedChanging(value);
                ReportPropertyChanging("ProductQuantityCounted");
                _ProductQuantityCounted = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductQuantityCounted");
                OnProductQuantityCountedChanged();
            }
        }
        private global::System.String _ProductQuantityCounted;
        partial void OnProductQuantityCountedChanging(global::System.String value);
        partial void OnProductQuantityCountedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductConnectedWithProduct
        {
            get
            {
                return _ProductConnectedWithProduct;
            }
            set
            {
                OnProductConnectedWithProductChanging(value);
                ReportPropertyChanging("ProductConnectedWithProduct");
                _ProductConnectedWithProduct = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductConnectedWithProduct");
                OnProductConnectedWithProductChanged();
            }
        }
        private global::System.String _ProductConnectedWithProduct;
        partial void OnProductConnectedWithProductChanging(global::System.String value);
        partial void OnProductConnectedWithProductChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductClientAdded
        {
            get
            {
                return _ProductClientAdded;
            }
            set
            {
                OnProductClientAddedChanging(value);
                ReportPropertyChanging("ProductClientAdded");
                _ProductClientAdded = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductClientAdded");
                OnProductClientAddedChanged();
            }
        }
        private global::System.String _ProductClientAdded;
        partial void OnProductClientAddedChanging(global::System.String value);
        partial void OnProductClientAddedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductClientConnected
        {
            get
            {
                return _ProductClientConnected;
            }
            set
            {
                OnProductClientConnectedChanging(value);
                ReportPropertyChanging("ProductClientConnected");
                _ProductClientConnected = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductClientConnected");
                OnProductClientConnectedChanged();
            }
        }
        private global::System.String _ProductClientConnected;
        partial void OnProductClientConnectedChanging(global::System.String value);
        partial void OnProductClientConnectedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductDateAdded
        {
            get
            {
                return _ProductDateAdded;
            }
            set
            {
                OnProductDateAddedChanging(value);
                ReportPropertyChanging("ProductDateAdded");
                _ProductDateAdded = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductDateAdded");
                OnProductDateAddedChanged();
            }
        }
        private global::System.String _ProductDateAdded;
        partial void OnProductDateAddedChanging(global::System.String value);
        partial void OnProductDateAddedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductDateConnected
        {
            get
            {
                return _ProductDateConnected;
            }
            set
            {
                OnProductDateConnectedChanging(value);
                ReportPropertyChanging("ProductDateConnected");
                _ProductDateConnected = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductDateConnected");
                OnProductDateConnectedChanged();
            }
        }
        private global::System.String _ProductDateConnected;
        partial void OnProductDateConnectedChanging(global::System.String value);
        partial void OnProductDateConnectedChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LocalDatabaseModel", "FromBadProductsToSession", "Session")]
        public Session Session
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Session>("LocalDatabaseModel.FromBadProductsToSession", "Session").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Session>("LocalDatabaseModel.FromBadProductsToSession", "Session").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Session> SessionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Session>("LocalDatabaseModel.FromBadProductsToSession", "Session");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Session>("LocalDatabaseModel.FromBadProductsToSession", "Session", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LocalDatabaseModel", Name="GoodProduct")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class GoodProduct : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new GoodProduct object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="sessionID">Initial value of the SessionID property.</param>
        public static GoodProduct CreateGoodProduct(global::System.Guid id, global::System.Guid sessionID)
        {
            GoodProduct goodProduct = new GoodProduct();
            goodProduct.ID = id;
            goodProduct.SessionID = sessionID;
            return goodProduct;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Guid _ID;
        partial void OnIDChanging(global::System.Guid value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid SessionID
        {
            get
            {
                return _SessionID;
            }
            set
            {
                OnSessionIDChanging(value);
                ReportPropertyChanging("SessionID");
                _SessionID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SessionID");
                OnSessionIDChanged();
            }
        }
        private global::System.Guid _SessionID;
        partial void OnSessionIDChanging(global::System.Guid value);
        partial void OnSessionIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                OnProductIDChanging(value);
                ReportPropertyChanging("ProductID");
                _ProductID = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductID");
                OnProductIDChanged();
            }
        }
        private global::System.String _ProductID;
        partial void OnProductIDChanging(global::System.String value);
        partial void OnProductIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductDirtyBarcode
        {
            get
            {
                return _ProductDirtyBarcode;
            }
            set
            {
                OnProductDirtyBarcodeChanging(value);
                ReportPropertyChanging("ProductDirtyBarcode");
                _ProductDirtyBarcode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductDirtyBarcode");
                OnProductDirtyBarcodeChanged();
            }
        }
        private global::System.String _ProductDirtyBarcode;
        partial void OnProductDirtyBarcodeChanging(global::System.String value);
        partial void OnProductDirtyBarcodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductCleanBarcode
        {
            get
            {
                return _ProductCleanBarcode;
            }
            set
            {
                OnProductCleanBarcodeChanging(value);
                ReportPropertyChanging("ProductCleanBarcode");
                _ProductCleanBarcode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductCleanBarcode");
                OnProductCleanBarcodeChanged();
            }
        }
        private global::System.String _ProductCleanBarcode;
        partial void OnProductCleanBarcodeChanging(global::System.String value);
        partial void OnProductCleanBarcodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                OnProductNameChanging(value);
                ReportPropertyChanging("ProductName");
                _ProductName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductName");
                OnProductNameChanged();
            }
        }
        private global::System.String _ProductName;
        partial void OnProductNameChanging(global::System.String value);
        partial void OnProductNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductBarcodeType
        {
            get
            {
                return _ProductBarcodeType;
            }
            set
            {
                OnProductBarcodeTypeChanging(value);
                ReportPropertyChanging("ProductBarcodeType");
                _ProductBarcodeType = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductBarcodeType");
                OnProductBarcodeTypeChanged();
            }
        }
        private global::System.String _ProductBarcodeType;
        partial void OnProductBarcodeTypeChanging(global::System.String value);
        partial void OnProductBarcodeTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductQuantityCounted
        {
            get
            {
                return _ProductQuantityCounted;
            }
            set
            {
                OnProductQuantityCountedChanging(value);
                ReportPropertyChanging("ProductQuantityCounted");
                _ProductQuantityCounted = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductQuantityCounted");
                OnProductQuantityCountedChanged();
            }
        }
        private global::System.String _ProductQuantityCounted;
        partial void OnProductQuantityCountedChanging(global::System.String value);
        partial void OnProductQuantityCountedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductQuantityFromDatabase
        {
            get
            {
                return _ProductQuantityFromDatabase;
            }
            set
            {
                OnProductQuantityFromDatabaseChanging(value);
                ReportPropertyChanging("ProductQuantityFromDatabase");
                _ProductQuantityFromDatabase = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductQuantityFromDatabase");
                OnProductQuantityFromDatabaseChanged();
            }
        }
        private global::System.String _ProductQuantityFromDatabase;
        partial void OnProductQuantityFromDatabaseChanging(global::System.String value);
        partial void OnProductQuantityFromDatabaseChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductQuantityFromBeginning
        {
            get
            {
                return _ProductQuantityFromBeginning;
            }
            set
            {
                OnProductQuantityFromBeginningChanging(value);
                ReportPropertyChanging("ProductQuantityFromBeginning");
                _ProductQuantityFromBeginning = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductQuantityFromBeginning");
                OnProductQuantityFromBeginningChanged();
            }
        }
        private global::System.String _ProductQuantityFromBeginning;
        partial void OnProductQuantityFromBeginningChanging(global::System.String value);
        partial void OnProductQuantityFromBeginningChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductAddedClient
        {
            get
            {
                return _ProductAddedClient;
            }
            set
            {
                OnProductAddedClientChanging(value);
                ReportPropertyChanging("ProductAddedClient");
                _ProductAddedClient = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductAddedClient");
                OnProductAddedClientChanged();
            }
        }
        private global::System.String _ProductAddedClient;
        partial void OnProductAddedClientChanging(global::System.String value);
        partial void OnProductAddedClientChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductModifiedClient
        {
            get
            {
                return _ProductModifiedClient;
            }
            set
            {
                OnProductModifiedClientChanging(value);
                ReportPropertyChanging("ProductModifiedClient");
                _ProductModifiedClient = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductModifiedClient");
                OnProductModifiedClientChanged();
            }
        }
        private global::System.String _ProductModifiedClient;
        partial void OnProductModifiedClientChanging(global::System.String value);
        partial void OnProductModifiedClientChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductDateAdded
        {
            get
            {
                return _ProductDateAdded;
            }
            set
            {
                OnProductDateAddedChanging(value);
                ReportPropertyChanging("ProductDateAdded");
                _ProductDateAdded = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductDateAdded");
                OnProductDateAddedChanged();
            }
        }
        private global::System.String _ProductDateAdded;
        partial void OnProductDateAddedChanging(global::System.String value);
        partial void OnProductDateAddedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductDateModified
        {
            get
            {
                return _ProductDateModified;
            }
            set
            {
                OnProductDateModifiedChanging(value);
                ReportPropertyChanging("ProductDateModified");
                _ProductDateModified = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductDateModified");
                OnProductDateModifiedChanged();
            }
        }
        private global::System.String _ProductDateModified;
        partial void OnProductDateModifiedChanging(global::System.String value);
        partial void OnProductDateModifiedChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LocalDatabaseModel", "FromGoodProductsToSession", "Session")]
        public Session Session
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Session>("LocalDatabaseModel.FromGoodProductsToSession", "Session").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Session>("LocalDatabaseModel.FromGoodProductsToSession", "Session").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Session> SessionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Session>("LocalDatabaseModel.FromGoodProductsToSession", "Session");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Session>("LocalDatabaseModel.FromGoodProductsToSession", "Session", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LocalDatabaseModel", Name="Session")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Session : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Session object.
        /// </summary>
        /// <param name="dateAdded">Initial value of the DateAdded property.</param>
        /// <param name="id">Initial value of the ID property.</param>
        public static Session CreateSession(global::System.DateTime dateAdded, global::System.Guid id)
        {
            Session session = new Session();
            session.DateAdded = dateAdded;
            session.ID = id;
            return session;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateAdded
        {
            get
            {
                return _DateAdded;
            }
            set
            {
                OnDateAddedChanging(value);
                ReportPropertyChanging("DateAdded");
                _DateAdded = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateAdded");
                OnDateAddedChanged();
            }
        }
        private global::System.DateTime _DateAdded;
        partial void OnDateAddedChanging(global::System.DateTime value);
        partial void OnDateAddedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Guid _ID;
        partial void OnIDChanging(global::System.Guid value);
        partial void OnIDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LocalDatabaseModel", "FromBadProductsToSession", "BadProduct")]
        public EntityCollection<BadProduct> BadProducts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BadProduct>("LocalDatabaseModel.FromBadProductsToSession", "BadProduct");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BadProduct>("LocalDatabaseModel.FromBadProductsToSession", "BadProduct", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LocalDatabaseModel", "FromGoodProductsToSession", "GoodProduct")]
        public EntityCollection<GoodProduct> GoodProducts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<GoodProduct>("LocalDatabaseModel.FromGoodProductsToSession", "GoodProduct");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<GoodProduct>("LocalDatabaseModel.FromGoodProductsToSession", "GoodProduct", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
