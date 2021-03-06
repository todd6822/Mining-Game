#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Scores")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTable(Table instance);
    partial void UpdateTable(Table instance);
    partial void DeleteTable(Table instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApplication1.Properties.Settings.Default.ScoresConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Table> Tables
		{
			get
			{
				return this.GetTable<Table>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FindAllScores")]
		public ISingleResult<FindAllScoresResult> FindAllScores()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<FindAllScoresResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FindScores")]
		public ISingleResult<FindScoresResult> FindScores([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="VarChar(50)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="VarChar(50)")] string lastName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), firstName, lastName);
			return ((ISingleResult<FindScoresResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
	public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _fName;
		
		private string _lName;
		
		private string _score;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnfNameChanging(string value);
    partial void OnfNameChanged();
    partial void OnlNameChanging(string value);
    partial void OnlNameChanged();
    partial void OnscoreChanging(string value);
    partial void OnscoreChanged();
    #endregion
		
		public Table()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fName", DbType="NChar(50)")]
		public string fName
		{
			get
			{
				return this._fName;
			}
			set
			{
				if ((this._fName != value))
				{
					this.OnfNameChanging(value);
					this.SendPropertyChanging();
					this._fName = value;
					this.SendPropertyChanged("fName");
					this.OnfNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lName", DbType="NChar(50)")]
		public string lName
		{
			get
			{
				return this._lName;
			}
			set
			{
				if ((this._lName != value))
				{
					this.OnlNameChanging(value);
					this.SendPropertyChanging();
					this._lName = value;
					this.SendPropertyChanged("lName");
					this.OnlNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_score", DbType="NChar(10)")]
		public string score
		{
			get
			{
				return this._score;
			}
			set
			{
				if ((this._score != value))
				{
					this.OnscoreChanging(value);
					this.SendPropertyChanging();
					this._score = value;
					this.SendPropertyChanged("score");
					this.OnscoreChanged();
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
	
	public partial class FindAllScoresResult
	{
		
		private string _fName;
		
		private string _lName;
		
		private string _Score;
		
		public FindAllScoresResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fName", DbType="NChar(50)")]
		public string fName
		{
			get
			{
				return this._fName;
			}
			set
			{
				if ((this._fName != value))
				{
					this._fName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lName", DbType="NChar(50)")]
		public string lName
		{
			get
			{
				return this._lName;
			}
			set
			{
				if ((this._lName != value))
				{
					this._lName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Score", DbType="NChar(10)")]
		public string Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				if ((this._Score != value))
				{
					this._Score = value;
				}
			}
		}
	}
	
	public partial class FindScoresResult
	{
		
		private string _fName;
		
		private string _lName;
		
		private string _Score;
		
		public FindScoresResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fName", DbType="NChar(50)")]
		public string fName
		{
			get
			{
				return this._fName;
			}
			set
			{
				if ((this._fName != value))
				{
					this._fName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lName", DbType="NChar(50)")]
		public string lName
		{
			get
			{
				return this._lName;
			}
			set
			{
				if ((this._lName != value))
				{
					this._lName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Score", DbType="NChar(10)")]
		public string Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				if ((this._Score != value))
				{
					this._Score = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
