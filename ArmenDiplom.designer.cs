﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArmenDiplom
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ArmenDiplom")]
	public partial class ArmenDiplomDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCounter(Counter instance);
    partial void UpdateCounter(Counter instance);
    partial void DeleteCounter(Counter instance);
    partial void InsertCounterStatement(CounterStatement instance);
    partial void UpdateCounterStatement(CounterStatement instance);
    partial void DeleteCounterStatement(CounterStatement instance);
    partial void InsertShkaf(Shkaf instance);
    partial void UpdateShkaf(Shkaf instance);
    partial void DeleteShkaf(Shkaf instance);
    partial void InsertShkafStatement(ShkafStatement instance);
    partial void UpdateShkafStatement(ShkafStatement instance);
    partial void DeleteShkafStatement(ShkafStatement instance);
    #endregion
		
		public ArmenDiplomDataContext() : 
				base(global::ArmenDiplom.Properties.Settings.Default.ArmenDiplomConnectionString3, mappingSource)
		{
			OnCreated();
		}
		
		public ArmenDiplomDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ArmenDiplomDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ArmenDiplomDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ArmenDiplomDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Counter> Counters
		{
			get
			{
				return this.GetTable<Counter>();
			}
		}
		
		public System.Data.Linq.Table<CounterStatement> CounterStatements
		{
			get
			{
				return this.GetTable<CounterStatement>();
			}
		}
		
		public System.Data.Linq.Table<Shkaf> Shkafs
		{
			get
			{
				return this.GetTable<Shkaf>();
			}
		}
		
		public System.Data.Linq.Table<ShkafStatement> ShkafStatements
		{
			get
			{
				return this.GetTable<ShkafStatement>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Counters")]
	public partial class Counter : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CounterID;
		
		private int _ShkafID;
		
		private string _CounterOwner;
		
		private string _TelephoneOwner;
		
		private System.DateTime _InstallDate;
		
		private System.DateTime _PoverkaDate;
		
		private EntitySet<CounterStatement> _CounterStatements;
		
		private EntityRef<Shkaf> _Shkaf;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCounterIDChanging(int value);
    partial void OnCounterIDChanged();
    partial void OnShkafIDChanging(int value);
    partial void OnShkafIDChanged();
    partial void OnCounterOwnerChanging(string value);
    partial void OnCounterOwnerChanged();
    partial void OnTelephoneOwnerChanging(string value);
    partial void OnTelephoneOwnerChanged();
    partial void OnInstallDateChanging(System.DateTime value);
    partial void OnInstallDateChanged();
    partial void OnPoverkaDateChanging(System.DateTime value);
    partial void OnPoverkaDateChanged();
    #endregion
		
		public Counter()
		{
			this._CounterStatements = new EntitySet<CounterStatement>(new Action<CounterStatement>(this.attach_CounterStatements), new Action<CounterStatement>(this.detach_CounterStatements));
			this._Shkaf = default(EntityRef<Shkaf>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CounterID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CounterID
		{
			get
			{
				return this._CounterID;
			}
			set
			{
				if ((this._CounterID != value))
				{
					this.OnCounterIDChanging(value);
					this.SendPropertyChanging();
					this._CounterID = value;
					this.SendPropertyChanged("CounterID");
					this.OnCounterIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShkafID", DbType="Int NOT NULL")]
		public int ShkafID
		{
			get
			{
				return this._ShkafID;
			}
			set
			{
				if ((this._ShkafID != value))
				{
					if (this._Shkaf.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnShkafIDChanging(value);
					this.SendPropertyChanging();
					this._ShkafID = value;
					this.SendPropertyChanged("ShkafID");
					this.OnShkafIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CounterOwner", DbType="NChar(30)")]
		public string CounterOwner
		{
			get
			{
				return this._CounterOwner;
			}
			set
			{
				if ((this._CounterOwner != value))
				{
					this.OnCounterOwnerChanging(value);
					this.SendPropertyChanging();
					this._CounterOwner = value;
					this.SendPropertyChanged("CounterOwner");
					this.OnCounterOwnerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelephoneOwner", DbType="NChar(20)")]
		public string TelephoneOwner
		{
			get
			{
				return this._TelephoneOwner;
			}
			set
			{
				if ((this._TelephoneOwner != value))
				{
					this.OnTelephoneOwnerChanging(value);
					this.SendPropertyChanging();
					this._TelephoneOwner = value;
					this.SendPropertyChanged("TelephoneOwner");
					this.OnTelephoneOwnerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstallDate", DbType="DateTime NOT NULL")]
		public System.DateTime InstallDate
		{
			get
			{
				return this._InstallDate;
			}
			set
			{
				if ((this._InstallDate != value))
				{
					this.OnInstallDateChanging(value);
					this.SendPropertyChanging();
					this._InstallDate = value;
					this.SendPropertyChanged("InstallDate");
					this.OnInstallDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PoverkaDate", DbType="DateTime NOT NULL")]
		public System.DateTime PoverkaDate
		{
			get
			{
				return this._PoverkaDate;
			}
			set
			{
				if ((this._PoverkaDate != value))
				{
					this.OnPoverkaDateChanging(value);
					this.SendPropertyChanging();
					this._PoverkaDate = value;
					this.SendPropertyChanged("PoverkaDate");
					this.OnPoverkaDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Counter_CounterStatement", Storage="_CounterStatements", ThisKey="CounterID", OtherKey="CounterID")]
		public EntitySet<CounterStatement> CounterStatements
		{
			get
			{
				return this._CounterStatements;
			}
			set
			{
				this._CounterStatements.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Shkaf_Counter", Storage="_Shkaf", ThisKey="ShkafID", OtherKey="ShkafID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Shkaf Shkaf
		{
			get
			{
				return this._Shkaf.Entity;
			}
			set
			{
				Shkaf previousValue = this._Shkaf.Entity;
				if (((previousValue != value) 
							|| (this._Shkaf.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Shkaf.Entity = null;
						previousValue.Counters.Remove(this);
					}
					this._Shkaf.Entity = value;
					if ((value != null))
					{
						value.Counters.Add(this);
						this._ShkafID = value.ShkafID;
					}
					else
					{
						this._ShkafID = default(int);
					}
					this.SendPropertyChanged("Shkaf");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_CounterStatements(CounterStatement entity)
		{
			this.SendPropertyChanging();
			entity.Counter = this;
		}
		
		private void detach_CounterStatements(CounterStatement entity)
		{
			this.SendPropertyChanging();
			entity.Counter = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CounterStatements")]
	public partial class CounterStatement : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CounterStatementID;
		
		private int _CounterID;
		
		private int _Month;
		
		private int _Year;
		
		private decimal _Tarif1;
		
		private decimal _Tarif2;
		
		private decimal _Tarif3;
		
		private decimal _Tarif4;
		
		private EntityRef<Counter> _Counter;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCounterStatementIDChanging(int value);
    partial void OnCounterStatementIDChanged();
    partial void OnCounterIDChanging(int value);
    partial void OnCounterIDChanged();
    partial void OnMonthChanging(int value);
    partial void OnMonthChanged();
    partial void OnYearChanging(int value);
    partial void OnYearChanged();
    partial void OnTarif1Changing(decimal value);
    partial void OnTarif1Changed();
    partial void OnTarif2Changing(decimal value);
    partial void OnTarif2Changed();
    partial void OnTarif3Changing(decimal value);
    partial void OnTarif3Changed();
    partial void OnTarif4Changing(decimal value);
    partial void OnTarif4Changed();
    #endregion
		
		public CounterStatement()
		{
			this._Counter = default(EntityRef<Counter>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CounterStatementID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CounterStatementID
		{
			get
			{
				return this._CounterStatementID;
			}
			set
			{
				if ((this._CounterStatementID != value))
				{
					this.OnCounterStatementIDChanging(value);
					this.SendPropertyChanging();
					this._CounterStatementID = value;
					this.SendPropertyChanged("CounterStatementID");
					this.OnCounterStatementIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CounterID", DbType="Int NOT NULL")]
		public int CounterID
		{
			get
			{
				return this._CounterID;
			}
			set
			{
				if ((this._CounterID != value))
				{
					if (this._Counter.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCounterIDChanging(value);
					this.SendPropertyChanging();
					this._CounterID = value;
					this.SendPropertyChanged("CounterID");
					this.OnCounterIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Month", DbType="Int NOT NULL")]
		public int Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				if ((this._Month != value))
				{
					this.OnMonthChanging(value);
					this.SendPropertyChanging();
					this._Month = value;
					this.SendPropertyChanged("Month");
					this.OnMonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL")]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tarif1", DbType="Decimal(5,1) NOT NULL")]
		public decimal Tarif1
		{
			get
			{
				return this._Tarif1;
			}
			set
			{
				if ((this._Tarif1 != value))
				{
					this.OnTarif1Changing(value);
					this.SendPropertyChanging();
					this._Tarif1 = value;
					this.SendPropertyChanged("Tarif1");
					this.OnTarif1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tarif2", DbType="Decimal(5,1) NOT NULL")]
		public decimal Tarif2
		{
			get
			{
				return this._Tarif2;
			}
			set
			{
				if ((this._Tarif2 != value))
				{
					this.OnTarif2Changing(value);
					this.SendPropertyChanging();
					this._Tarif2 = value;
					this.SendPropertyChanged("Tarif2");
					this.OnTarif2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tarif3", DbType="Decimal(5,1) NOT NULL")]
		public decimal Tarif3
		{
			get
			{
				return this._Tarif3;
			}
			set
			{
				if ((this._Tarif3 != value))
				{
					this.OnTarif3Changing(value);
					this.SendPropertyChanging();
					this._Tarif3 = value;
					this.SendPropertyChanged("Tarif3");
					this.OnTarif3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tarif4", DbType="Decimal(5,1) NOT NULL")]
		public decimal Tarif4
		{
			get
			{
				return this._Tarif4;
			}
			set
			{
				if ((this._Tarif4 != value))
				{
					this.OnTarif4Changing(value);
					this.SendPropertyChanging();
					this._Tarif4 = value;
					this.SendPropertyChanged("Tarif4");
					this.OnTarif4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Counter_CounterStatement", Storage="_Counter", ThisKey="CounterID", OtherKey="CounterID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Counter Counter
		{
			get
			{
				return this._Counter.Entity;
			}
			set
			{
				Counter previousValue = this._Counter.Entity;
				if (((previousValue != value) 
							|| (this._Counter.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Counter.Entity = null;
						previousValue.CounterStatements.Remove(this);
					}
					this._Counter.Entity = value;
					if ((value != null))
					{
						value.CounterStatements.Add(this);
						this._CounterID = value.CounterID;
					}
					else
					{
						this._CounterID = default(int);
					}
					this.SendPropertyChanged("Counter");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Shkafs")]
	public partial class Shkaf : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ShkafID;
		
		private string _Address;
		
		private System.DateTime _InstallDate;
		
		private System.DateTime _PoverkaDate;
		
		private string _Installer;
		
		private int _CountersQuantity;
		
		private string _Password1;
		
		private string _Password2;
		
		private string _Password3;
		
		private EntitySet<Counter> _Counters;
		
		private EntitySet<ShkafStatement> _ShkafStatements;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnShkafIDChanging(int value);
    partial void OnShkafIDChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnInstallDateChanging(System.DateTime value);
    partial void OnInstallDateChanged();
    partial void OnPoverkaDateChanging(System.DateTime value);
    partial void OnPoverkaDateChanged();
    partial void OnInstallerChanging(string value);
    partial void OnInstallerChanged();
    partial void OnCountersQuantityChanging(int value);
    partial void OnCountersQuantityChanged();
    partial void OnPassword1Changing(string value);
    partial void OnPassword1Changed();
    partial void OnPassword2Changing(string value);
    partial void OnPassword2Changed();
    partial void OnPassword3Changing(string value);
    partial void OnPassword3Changed();
    #endregion
		
		public Shkaf()
		{
			this._Counters = new EntitySet<Counter>(new Action<Counter>(this.attach_Counters), new Action<Counter>(this.detach_Counters));
			this._ShkafStatements = new EntitySet<ShkafStatement>(new Action<ShkafStatement>(this.attach_ShkafStatements), new Action<ShkafStatement>(this.detach_ShkafStatements));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShkafID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ShkafID
		{
			get
			{
				return this._ShkafID;
			}
			set
			{
				if ((this._ShkafID != value))
				{
					this.OnShkafIDChanging(value);
					this.SendPropertyChanging();
					this._ShkafID = value;
					this.SendPropertyChanged("ShkafID");
					this.OnShkafIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(40)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstallDate", DbType="DateTime NOT NULL")]
		public System.DateTime InstallDate
		{
			get
			{
				return this._InstallDate;
			}
			set
			{
				if ((this._InstallDate != value))
				{
					this.OnInstallDateChanging(value);
					this.SendPropertyChanging();
					this._InstallDate = value;
					this.SendPropertyChanged("InstallDate");
					this.OnInstallDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PoverkaDate", DbType="DateTime NOT NULL")]
		public System.DateTime PoverkaDate
		{
			get
			{
				return this._PoverkaDate;
			}
			set
			{
				if ((this._PoverkaDate != value))
				{
					this.OnPoverkaDateChanging(value);
					this.SendPropertyChanging();
					this._PoverkaDate = value;
					this.SendPropertyChanged("PoverkaDate");
					this.OnPoverkaDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Installer", DbType="NVarChar(30)")]
		public string Installer
		{
			get
			{
				return this._Installer;
			}
			set
			{
				if ((this._Installer != value))
				{
					this.OnInstallerChanging(value);
					this.SendPropertyChanging();
					this._Installer = value;
					this.SendPropertyChanged("Installer");
					this.OnInstallerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountersQuantity", DbType="Int NOT NULL")]
		public int CountersQuantity
		{
			get
			{
				return this._CountersQuantity;
			}
			set
			{
				if ((this._CountersQuantity != value))
				{
					this.OnCountersQuantityChanging(value);
					this.SendPropertyChanging();
					this._CountersQuantity = value;
					this.SendPropertyChanged("CountersQuantity");
					this.OnCountersQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password1", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string Password1
		{
			get
			{
				return this._Password1;
			}
			set
			{
				if ((this._Password1 != value))
				{
					this.OnPassword1Changing(value);
					this.SendPropertyChanging();
					this._Password1 = value;
					this.SendPropertyChanged("Password1");
					this.OnPassword1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password2", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string Password2
		{
			get
			{
				return this._Password2;
			}
			set
			{
				if ((this._Password2 != value))
				{
					this.OnPassword2Changing(value);
					this.SendPropertyChanging();
					this._Password2 = value;
					this.SendPropertyChanged("Password2");
					this.OnPassword2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password3", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string Password3
		{
			get
			{
				return this._Password3;
			}
			set
			{
				if ((this._Password3 != value))
				{
					this.OnPassword3Changing(value);
					this.SendPropertyChanging();
					this._Password3 = value;
					this.SendPropertyChanged("Password3");
					this.OnPassword3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Shkaf_Counter", Storage="_Counters", ThisKey="ShkafID", OtherKey="ShkafID")]
		public EntitySet<Counter> Counters
		{
			get
			{
				return this._Counters;
			}
			set
			{
				this._Counters.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Shkaf_ShkafStatement", Storage="_ShkafStatements", ThisKey="ShkafID", OtherKey="ShkafID")]
		public EntitySet<ShkafStatement> ShkafStatements
		{
			get
			{
				return this._ShkafStatements;
			}
			set
			{
				this._ShkafStatements.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Counters(Counter entity)
		{
			this.SendPropertyChanging();
			entity.Shkaf = this;
		}
		
		private void detach_Counters(Counter entity)
		{
			this.SendPropertyChanging();
			entity.Shkaf = null;
		}
		
		private void attach_ShkafStatements(ShkafStatement entity)
		{
			this.SendPropertyChanging();
			entity.Shkaf = this;
		}
		
		private void detach_ShkafStatements(ShkafStatement entity)
		{
			this.SendPropertyChanging();
			entity.Shkaf = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ShkafStatements")]
	public partial class ShkafStatement : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ShkafStatementID;
		
		private int _ShkafID;
		
		private int _Year;
		
		private int _Month;
		
		private int _AccessQuantity;
		
		private int _BadAccessQuantity;
		
		private bool _Power;
		
		private EntityRef<Shkaf> _Shkaf;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnShkafStatementIDChanging(int value);
    partial void OnShkafStatementIDChanged();
    partial void OnShkafIDChanging(int value);
    partial void OnShkafIDChanged();
    partial void OnYearChanging(int value);
    partial void OnYearChanged();
    partial void OnMonthChanging(int value);
    partial void OnMonthChanged();
    partial void OnAccessQuantityChanging(int value);
    partial void OnAccessQuantityChanged();
    partial void OnBadAccessQuantityChanging(int value);
    partial void OnBadAccessQuantityChanged();
    partial void OnPowerChanging(bool value);
    partial void OnPowerChanged();
    #endregion
		
		public ShkafStatement()
		{
			this._Shkaf = default(EntityRef<Shkaf>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShkafStatementID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ShkafStatementID
		{
			get
			{
				return this._ShkafStatementID;
			}
			set
			{
				if ((this._ShkafStatementID != value))
				{
					this.OnShkafStatementIDChanging(value);
					this.SendPropertyChanging();
					this._ShkafStatementID = value;
					this.SendPropertyChanged("ShkafStatementID");
					this.OnShkafStatementIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShkafID", DbType="Int NOT NULL")]
		public int ShkafID
		{
			get
			{
				return this._ShkafID;
			}
			set
			{
				if ((this._ShkafID != value))
				{
					if (this._Shkaf.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnShkafIDChanging(value);
					this.SendPropertyChanging();
					this._ShkafID = value;
					this.SendPropertyChanged("ShkafID");
					this.OnShkafIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL")]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Month", DbType="Int NOT NULL")]
		public int Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				if ((this._Month != value))
				{
					this.OnMonthChanging(value);
					this.SendPropertyChanging();
					this._Month = value;
					this.SendPropertyChanged("Month");
					this.OnMonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccessQuantity", DbType="Int NOT NULL")]
		public int AccessQuantity
		{
			get
			{
				return this._AccessQuantity;
			}
			set
			{
				if ((this._AccessQuantity != value))
				{
					this.OnAccessQuantityChanging(value);
					this.SendPropertyChanging();
					this._AccessQuantity = value;
					this.SendPropertyChanged("AccessQuantity");
					this.OnAccessQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BadAccessQuantity", DbType="Int NOT NULL")]
		public int BadAccessQuantity
		{
			get
			{
				return this._BadAccessQuantity;
			}
			set
			{
				if ((this._BadAccessQuantity != value))
				{
					this.OnBadAccessQuantityChanging(value);
					this.SendPropertyChanging();
					this._BadAccessQuantity = value;
					this.SendPropertyChanged("BadAccessQuantity");
					this.OnBadAccessQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Power", DbType="Bit NOT NULL")]
		public bool Power
		{
			get
			{
				return this._Power;
			}
			set
			{
				if ((this._Power != value))
				{
					this.OnPowerChanging(value);
					this.SendPropertyChanging();
					this._Power = value;
					this.SendPropertyChanged("Power");
					this.OnPowerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Shkaf_ShkafStatement", Storage="_Shkaf", ThisKey="ShkafID", OtherKey="ShkafID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Shkaf Shkaf
		{
			get
			{
				return this._Shkaf.Entity;
			}
			set
			{
				Shkaf previousValue = this._Shkaf.Entity;
				if (((previousValue != value) 
							|| (this._Shkaf.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Shkaf.Entity = null;
						previousValue.ShkafStatements.Remove(this);
					}
					this._Shkaf.Entity = value;
					if ((value != null))
					{
						value.ShkafStatements.Add(this);
						this._ShkafID = value.ShkafID;
					}
					else
					{
						this._ShkafID = default(int);
					}
					this.SendPropertyChanged("Shkaf");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591