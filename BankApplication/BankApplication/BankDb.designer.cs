﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankApplication
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BankDb")]
	public partial class BankDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertAccountType(AccountType instance);
    partial void UpdateAccountType(AccountType instance);
    partial void DeleteAccountType(AccountType instance);
    partial void InsertTransactionType(TransactionType instance);
    partial void UpdateTransactionType(TransactionType instance);
    partial void DeleteTransactionType(TransactionType instance);
    partial void InsertTransactionAccount(TransactionAccount instance);
    partial void UpdateTransactionAccount(TransactionAccount instance);
    partial void DeleteTransactionAccount(TransactionAccount instance);
    #endregion
		
		public BankDbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BankDbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BankDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<AccountType> AccountTypes
		{
			get
			{
				return this.GetTable<AccountType>();
			}
		}
		
		public System.Data.Linq.Table<TransactionType> TransactionTypes
		{
			get
			{
				return this.GetTable<TransactionType>();
			}
		}
		
		public System.Data.Linq.Table<TransactionAccount> TransactionAccounts
		{
			get
			{
				return this.GetTable<TransactionAccount>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IBAN;
		
		private string _AccountTypeCode;
		
		private string _Firstname;
		
		private string _Lastname;
		
		private string _Address;
		
		private string _Mobile;
		
		private decimal _Balance;
		
		private System.Nullable<System.DateTime> _TransactionDate;
		
		private EntitySet<TransactionAccount> _TransactionAccounts;
		
		private EntityRef<AccountType> _AccountType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIBANChanging(string value);
    partial void OnIBANChanged();
    partial void OnAccountTypeCodeChanging(string value);
    partial void OnAccountTypeCodeChanged();
    partial void OnFirstnameChanging(string value);
    partial void OnFirstnameChanged();
    partial void OnLastnameChanging(string value);
    partial void OnLastnameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnMobileChanging(string value);
    partial void OnMobileChanged();
    partial void OnBalanceChanging(decimal value);
    partial void OnBalanceChanged();
    partial void OnTransactionDateChanging(System.Nullable<System.DateTime> value);
    partial void OnTransactionDateChanged();
    #endregion
		
		public Account()
		{
			this._TransactionAccounts = new EntitySet<TransactionAccount>(new Action<TransactionAccount>(this.attach_TransactionAccounts), new Action<TransactionAccount>(this.detach_TransactionAccounts));
			this._AccountType = default(EntityRef<AccountType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IBAN", DbType="NVarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IBAN
		{
			get
			{
				return this._IBAN;
			}
			set
			{
				if ((this._IBAN != value))
				{
					this.OnIBANChanging(value);
					this.SendPropertyChanging();
					this._IBAN = value;
					this.SendPropertyChanged("IBAN");
					this.OnIBANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountTypeCode", DbType="NVarChar(1)")]
		public string AccountTypeCode
		{
			get
			{
				return this._AccountTypeCode;
			}
			set
			{
				if ((this._AccountTypeCode != value))
				{
					if (this._AccountType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAccountTypeCodeChanging(value);
					this.SendPropertyChanging();
					this._AccountTypeCode = value;
					this.SendPropertyChanged("AccountTypeCode");
					this.OnAccountTypeCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="NVarChar(50)")]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this.OnFirstnameChanging(value);
					this.SendPropertyChanging();
					this._Firstname = value;
					this.SendPropertyChanged("Firstname");
					this.OnFirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="NVarChar(50)")]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this.OnLastnameChanging(value);
					this.SendPropertyChanging();
					this._Lastname = value;
					this.SendPropertyChanged("Lastname");
					this.OnLastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(200)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile", DbType="NVarChar(20)")]
		public string Mobile
		{
			get
			{
				return this._Mobile;
			}
			set
			{
				if ((this._Mobile != value))
				{
					this.OnMobileChanging(value);
					this.SendPropertyChanging();
					this._Mobile = value;
					this.SendPropertyChanged("Mobile");
					this.OnMobileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Money NOT NULL")]
		public decimal Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> TransactionDate
		{
			get
			{
				return this._TransactionDate;
			}
			set
			{
				if ((this._TransactionDate != value))
				{
					this.OnTransactionDateChanging(value);
					this.SendPropertyChanging();
					this._TransactionDate = value;
					this.SendPropertyChanged("TransactionDate");
					this.OnTransactionDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_TransactionAccount", Storage="_TransactionAccounts", ThisKey="IBAN", OtherKey="ToIBAN")]
		public EntitySet<TransactionAccount> TransactionAccounts
		{
			get
			{
				return this._TransactionAccounts;
			}
			set
			{
				this._TransactionAccounts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AccountType_Account", Storage="_AccountType", ThisKey="AccountTypeCode", OtherKey="AccountTypeCode", IsForeignKey=true)]
		public AccountType AccountType
		{
			get
			{
				return this._AccountType.Entity;
			}
			set
			{
				AccountType previousValue = this._AccountType.Entity;
				if (((previousValue != value) 
							|| (this._AccountType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AccountType.Entity = null;
						previousValue.Accounts.Remove(this);
					}
					this._AccountType.Entity = value;
					if ((value != null))
					{
						value.Accounts.Add(this);
						this._AccountTypeCode = value.AccountTypeCode;
					}
					else
					{
						this._AccountTypeCode = default(string);
					}
					this.SendPropertyChanged("AccountType");
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
		
		private void attach_TransactionAccounts(TransactionAccount entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_TransactionAccounts(TransactionAccount entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AccountType")]
	public partial class AccountType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _AccountTypeCode;
		
		private string _AccountTypeName;
		
		private EntitySet<Account> _Accounts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccountTypeCodeChanging(string value);
    partial void OnAccountTypeCodeChanged();
    partial void OnAccountTypeNameChanging(string value);
    partial void OnAccountTypeNameChanged();
    #endregion
		
		public AccountType()
		{
			this._Accounts = new EntitySet<Account>(new Action<Account>(this.attach_Accounts), new Action<Account>(this.detach_Accounts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountTypeCode", DbType="NVarChar(1) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string AccountTypeCode
		{
			get
			{
				return this._AccountTypeCode;
			}
			set
			{
				if ((this._AccountTypeCode != value))
				{
					this.OnAccountTypeCodeChanging(value);
					this.SendPropertyChanging();
					this._AccountTypeCode = value;
					this.SendPropertyChanged("AccountTypeCode");
					this.OnAccountTypeCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountTypeName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AccountTypeName
		{
			get
			{
				return this._AccountTypeName;
			}
			set
			{
				if ((this._AccountTypeName != value))
				{
					this.OnAccountTypeNameChanging(value);
					this.SendPropertyChanging();
					this._AccountTypeName = value;
					this.SendPropertyChanged("AccountTypeName");
					this.OnAccountTypeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AccountType_Account", Storage="_Accounts", ThisKey="AccountTypeCode", OtherKey="AccountTypeCode")]
		public EntitySet<Account> Accounts
		{
			get
			{
				return this._Accounts;
			}
			set
			{
				this._Accounts.Assign(value);
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
		
		private void attach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.AccountType = this;
		}
		
		private void detach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.AccountType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TransactionType")]
	public partial class TransactionType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TransactionTypeCode;
		
		private string _TransactionTypeName;
		
		private EntitySet<TransactionAccount> _TransactionAccounts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionTypeCodeChanging(string value);
    partial void OnTransactionTypeCodeChanged();
    partial void OnTransactionTypeNameChanging(string value);
    partial void OnTransactionTypeNameChanged();
    #endregion
		
		public TransactionType()
		{
			this._TransactionAccounts = new EntitySet<TransactionAccount>(new Action<TransactionAccount>(this.attach_TransactionAccounts), new Action<TransactionAccount>(this.detach_TransactionAccounts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionTypeCode", DbType="NVarChar(1) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TransactionTypeCode
		{
			get
			{
				return this._TransactionTypeCode;
			}
			set
			{
				if ((this._TransactionTypeCode != value))
				{
					this.OnTransactionTypeCodeChanging(value);
					this.SendPropertyChanging();
					this._TransactionTypeCode = value;
					this.SendPropertyChanged("TransactionTypeCode");
					this.OnTransactionTypeCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionTypeName", DbType="NVarChar(50)")]
		public string TransactionTypeName
		{
			get
			{
				return this._TransactionTypeName;
			}
			set
			{
				if ((this._TransactionTypeName != value))
				{
					this.OnTransactionTypeNameChanging(value);
					this.SendPropertyChanging();
					this._TransactionTypeName = value;
					this.SendPropertyChanged("TransactionTypeName");
					this.OnTransactionTypeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TransactionType_TransactionAccount", Storage="_TransactionAccounts", ThisKey="TransactionTypeCode", OtherKey="TransactionTypeCode")]
		public EntitySet<TransactionAccount> TransactionAccounts
		{
			get
			{
				return this._TransactionAccounts;
			}
			set
			{
				this._TransactionAccounts.Assign(value);
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
		
		private void attach_TransactionAccounts(TransactionAccount entity)
		{
			this.SendPropertyChanging();
			entity.TransactionType = this;
		}
		
		private void detach_TransactionAccounts(TransactionAccount entity)
		{
			this.SendPropertyChanging();
			entity.TransactionType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TransactionAccount")]
	public partial class TransactionAccount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _TransactionId;
		
		private string _FromIBAN;
		
		private string _ToIBAN;
		
		private decimal _Amount;
		
		private string _TransactionTypeCode;
		
		private System.DateTime _TransactionDate;
		
		private EntityRef<Account> _Account;
		
		private EntityRef<TransactionType> _TransactionType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionIdChanging(long value);
    partial void OnTransactionIdChanged();
    partial void OnFromIBANChanging(string value);
    partial void OnFromIBANChanged();
    partial void OnToIBANChanging(string value);
    partial void OnToIBANChanged();
    partial void OnAmountChanging(decimal value);
    partial void OnAmountChanged();
    partial void OnTransactionTypeCodeChanging(string value);
    partial void OnTransactionTypeCodeChanged();
    partial void OnTransactionDateChanging(System.DateTime value);
    partial void OnTransactionDateChanged();
    #endregion
		
		public TransactionAccount()
		{
			this._Account = default(EntityRef<Account>);
			this._TransactionType = default(EntityRef<TransactionType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long TransactionId
		{
			get
			{
				return this._TransactionId;
			}
			set
			{
				if ((this._TransactionId != value))
				{
					this.OnTransactionIdChanging(value);
					this.SendPropertyChanging();
					this._TransactionId = value;
					this.SendPropertyChanged("TransactionId");
					this.OnTransactionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromIBAN", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string FromIBAN
		{
			get
			{
				return this._FromIBAN;
			}
			set
			{
				if ((this._FromIBAN != value))
				{
					this.OnFromIBANChanging(value);
					this.SendPropertyChanging();
					this._FromIBAN = value;
					this.SendPropertyChanged("FromIBAN");
					this.OnFromIBANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToIBAN", DbType="NVarChar(30)")]
		public string ToIBAN
		{
			get
			{
				return this._ToIBAN;
			}
			set
			{
				if ((this._ToIBAN != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnToIBANChanging(value);
					this.SendPropertyChanging();
					this._ToIBAN = value;
					this.SendPropertyChanged("ToIBAN");
					this.OnToIBANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Money NOT NULL")]
		public decimal Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionTypeCode", DbType="NVarChar(1) NOT NULL", CanBeNull=false)]
		public string TransactionTypeCode
		{
			get
			{
				return this._TransactionTypeCode;
			}
			set
			{
				if ((this._TransactionTypeCode != value))
				{
					if (this._TransactionType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTransactionTypeCodeChanging(value);
					this.SendPropertyChanging();
					this._TransactionTypeCode = value;
					this.SendPropertyChanged("TransactionTypeCode");
					this.OnTransactionTypeCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionDate", DbType="DateTime NOT NULL")]
		public System.DateTime TransactionDate
		{
			get
			{
				return this._TransactionDate;
			}
			set
			{
				if ((this._TransactionDate != value))
				{
					this.OnTransactionDateChanging(value);
					this.SendPropertyChanging();
					this._TransactionDate = value;
					this.SendPropertyChanged("TransactionDate");
					this.OnTransactionDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_TransactionAccount", Storage="_Account", ThisKey="ToIBAN", OtherKey="IBAN", IsForeignKey=true)]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.TransactionAccounts.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.TransactionAccounts.Add(this);
						this._ToIBAN = value.IBAN;
					}
					else
					{
						this._ToIBAN = default(string);
					}
					this.SendPropertyChanged("Account");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TransactionType_TransactionAccount", Storage="_TransactionType", ThisKey="TransactionTypeCode", OtherKey="TransactionTypeCode", IsForeignKey=true)]
		public TransactionType TransactionType
		{
			get
			{
				return this._TransactionType.Entity;
			}
			set
			{
				TransactionType previousValue = this._TransactionType.Entity;
				if (((previousValue != value) 
							|| (this._TransactionType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TransactionType.Entity = null;
						previousValue.TransactionAccounts.Remove(this);
					}
					this._TransactionType.Entity = value;
					if ((value != null))
					{
						value.TransactionAccounts.Add(this);
						this._TransactionTypeCode = value.TransactionTypeCode;
					}
					else
					{
						this._TransactionTypeCode = default(string);
					}
					this.SendPropertyChanged("TransactionType");
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
