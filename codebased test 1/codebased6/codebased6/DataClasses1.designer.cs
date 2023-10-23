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

namespace codebased6
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="assignmentdb")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCode_Employe(Code_Employe instance);
    partial void UpdateCode_Employe(Code_Employe instance);
    partial void DeleteCode_Employe(Code_Employe instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::codebased6.Properties.Settings.Default.assignmentdbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Code_Employe> Code_Employes
		{
			get
			{
				return this.GetTable<Code_Employe>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Code_Employes")]
	public partial class Code_Employe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _empno;
		
		private string _empname;
		
		private System.Nullable<decimal> _empsal;
		
		private System.Nullable<char> _emptype;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnempnoChanging(int value);
    partial void OnempnoChanged();
    partial void OnempnameChanging(string value);
    partial void OnempnameChanged();
    partial void OnempsalChanging(System.Nullable<decimal> value);
    partial void OnempsalChanged();
    partial void OnemptypeChanging(System.Nullable<char> value);
    partial void OnemptypeChanged();
    #endregion
		
		public Code_Employe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int empno
		{
			get
			{
				return this._empno;
			}
			set
			{
				if ((this._empno != value))
				{
					this.OnempnoChanging(value);
					this.SendPropertyChanging();
					this._empno = value;
					this.SendPropertyChanged("empno");
					this.OnempnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empname", DbType="VarChar(35) NOT NULL", CanBeNull=false)]
		public string empname
		{
			get
			{
				return this._empname;
			}
			set
			{
				if ((this._empname != value))
				{
					this.OnempnameChanging(value);
					this.SendPropertyChanging();
					this._empname = value;
					this.SendPropertyChanged("empname");
					this.OnempnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empsal", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> empsal
		{
			get
			{
				return this._empsal;
			}
			set
			{
				if ((this._empsal != value))
				{
					this.OnempsalChanging(value);
					this.SendPropertyChanging();
					this._empsal = value;
					this.SendPropertyChanged("empsal");
					this.OnempsalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emptype", DbType="Char(1)")]
		public System.Nullable<char> emptype
		{
			get
			{
				return this._emptype;
			}
			set
			{
				if ((this._emptype != value))
				{
					this.OnemptypeChanging(value);
					this.SendPropertyChanging();
					this._emptype = value;
					this.SendPropertyChanged("emptype");
					this.OnemptypeChanged();
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
