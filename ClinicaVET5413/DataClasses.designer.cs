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

namespace ClinicaVET5413
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ClinicaDB5413")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    partial void InsertConsulta(Consulta instance);
    partial void UpdateConsulta(Consulta instance);
    partial void DeleteConsulta(Consulta instance);
    partial void InsertMedico(Medico instance);
    partial void UpdateMedico(Medico instance);
    partial void DeleteMedico(Medico instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::ClinicaVET5413.Properties.Settings.Default.ClinicaDB5413ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Animal> Animals
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
		
		public System.Data.Linq.Table<Cliente> Clientes
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public System.Data.Linq.Table<Consulta> Consultas
		{
			get
			{
				return this.GetTable<Consulta>();
			}
		}
		
		public System.Data.Linq.Table<Medico> Medicos
		{
			get
			{
				return this.GetTable<Medico>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animal")]
	public partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Nome;
		
		private string _Especie;
		
		private string _Raca;
		
		private string _Genero;
		
		private string _Peso;
		
		private string _Esterilizacao;
		
		private string _DataNascimento;
		
		private EntitySet<Consulta> _Consultas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnEspecieChanging(string value);
    partial void OnEspecieChanged();
    partial void OnRacaChanging(string value);
    partial void OnRacaChanged();
    partial void OnGeneroChanging(string value);
    partial void OnGeneroChanged();
    partial void OnPesoChanging(string value);
    partial void OnPesoChanged();
    partial void OnEsterilizacaoChanging(string value);
    partial void OnEsterilizacaoChanged();
    partial void OnDataNascimentoChanging(string value);
    partial void OnDataNascimentoChanged();
    #endregion
		
		public Animal()
		{
			this._Consultas = new EntitySet<Consulta>(new Action<Consulta>(this.attach_Consultas), new Action<Consulta>(this.detach_Consultas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Especie", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Especie
		{
			get
			{
				return this._Especie;
			}
			set
			{
				if ((this._Especie != value))
				{
					this.OnEspecieChanging(value);
					this.SendPropertyChanging();
					this._Especie = value;
					this.SendPropertyChanged("Especie");
					this.OnEspecieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Raca", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Raca
		{
			get
			{
				return this._Raca;
			}
			set
			{
				if ((this._Raca != value))
				{
					this.OnRacaChanging(value);
					this.SendPropertyChanging();
					this._Raca = value;
					this.SendPropertyChanged("Raca");
					this.OnRacaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this.OnGeneroChanging(value);
					this.SendPropertyChanging();
					this._Genero = value;
					this.SendPropertyChanged("Genero");
					this.OnGeneroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Peso", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Peso
		{
			get
			{
				return this._Peso;
			}
			set
			{
				if ((this._Peso != value))
				{
					this.OnPesoChanging(value);
					this.SendPropertyChanging();
					this._Peso = value;
					this.SendPropertyChanged("Peso");
					this.OnPesoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Esterilizacao", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Esterilizacao
		{
			get
			{
				return this._Esterilizacao;
			}
			set
			{
				if ((this._Esterilizacao != value))
				{
					this.OnEsterilizacaoChanging(value);
					this.SendPropertyChanging();
					this._Esterilizacao = value;
					this.SendPropertyChanged("Esterilizacao");
					this.OnEsterilizacaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataNascimento", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DataNascimento
		{
			get
			{
				return this._DataNascimento;
			}
			set
			{
				if ((this._DataNascimento != value))
				{
					this.OnDataNascimentoChanging(value);
					this.SendPropertyChanging();
					this._DataNascimento = value;
					this.SendPropertyChanged("DataNascimento");
					this.OnDataNascimentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_Consulta", Storage="_Consultas", ThisKey="ID", OtherKey="Animal")]
		public EntitySet<Consulta> Consultas
		{
			get
			{
				return this._Consultas;
			}
			set
			{
				this._Consultas.Assign(value);
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
		
		private void attach_Consultas(Consulta entity)
		{
			this.SendPropertyChanging();
			entity.Animal1 = this;
		}
		
		private void detach_Consultas(Consulta entity)
		{
			this.SendPropertyChanging();
			entity.Animal1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cliente")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Nome;
		
		private string _NIF;
		
		private string _Telemovel;
		
		private string _Email;
		
		private string _Animal;
		
		private EntitySet<Consulta> _Consultas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnNIFChanging(string value);
    partial void OnNIFChanged();
    partial void OnTelemovelChanging(string value);
    partial void OnTelemovelChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAnimalChanging(string value);
    partial void OnAnimalChanged();
    #endregion
		
		public Cliente()
		{
			this._Consultas = new EntitySet<Consulta>(new Action<Consulta>(this.attach_Consultas), new Action<Consulta>(this.detach_Consultas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NIF", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NIF
		{
			get
			{
				return this._NIF;
			}
			set
			{
				if ((this._NIF != value))
				{
					this.OnNIFChanging(value);
					this.SendPropertyChanging();
					this._NIF = value;
					this.SendPropertyChanged("NIF");
					this.OnNIFChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telemovel", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string Telemovel
		{
			get
			{
				return this._Telemovel;
			}
			set
			{
				if ((this._Telemovel != value))
				{
					this.OnTelemovelChanging(value);
					this.SendPropertyChanging();
					this._Telemovel = value;
					this.SendPropertyChanged("Telemovel");
					this.OnTelemovelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Animal", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Animal
		{
			get
			{
				return this._Animal;
			}
			set
			{
				if ((this._Animal != value))
				{
					this.OnAnimalChanging(value);
					this.SendPropertyChanging();
					this._Animal = value;
					this.SendPropertyChanged("Animal");
					this.OnAnimalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Consulta", Storage="_Consultas", ThisKey="ID", OtherKey="Cliente")]
		public EntitySet<Consulta> Consultas
		{
			get
			{
				return this._Consultas;
			}
			set
			{
				this._Consultas.Assign(value);
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
		
		private void attach_Consultas(Consulta entity)
		{
			this.SendPropertyChanging();
			entity.Cliente1 = this;
		}
		
		private void detach_Consultas(Consulta entity)
		{
			this.SendPropertyChanging();
			entity.Cliente1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Consulta")]
	public partial class Consulta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _Medico;
		
		private int _Cliente;
		
		private int _Animal;
		
		private string _Tratamento;
		
		private string _DiaConsulta;
		
		private string _HoraConsulta;
		
		private string _Notas;
		
		private EntityRef<Animal> _Animal1;
		
		private EntityRef<Cliente> _Cliente1;
		
		private EntityRef<Medico> _Medico11;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMedicoChanging(int value);
    partial void OnMedicoChanged();
    partial void OnClienteChanging(int value);
    partial void OnClienteChanged();
    partial void OnAnimalChanging(int value);
    partial void OnAnimalChanged();
    partial void OnTratamentoChanging(string value);
    partial void OnTratamentoChanged();
    partial void OnDiaConsultaChanging(string value);
    partial void OnDiaConsultaChanged();
    partial void OnHoraConsultaChanging(string value);
    partial void OnHoraConsultaChanged();
    partial void OnNotasChanging(string value);
    partial void OnNotasChanged();
    #endregion
		
		public Consulta()
		{
			this._Animal1 = default(EntityRef<Animal>);
			this._Cliente1 = default(EntityRef<Cliente>);
			this._Medico11 = default(EntityRef<Medico>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medico", DbType="Int NOT NULL")]
		public int Medico
		{
			get
			{
				return this._Medico;
			}
			set
			{
				if ((this._Medico != value))
				{
					if (this._Medico11.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMedicoChanging(value);
					this.SendPropertyChanging();
					this._Medico = value;
					this.SendPropertyChanged("Medico");
					this.OnMedicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente", DbType="Int NOT NULL")]
		public int Cliente
		{
			get
			{
				return this._Cliente;
			}
			set
			{
				if ((this._Cliente != value))
				{
					if (this._Cliente1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClienteChanging(value);
					this.SendPropertyChanging();
					this._Cliente = value;
					this.SendPropertyChanged("Cliente");
					this.OnClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Animal", DbType="Int NOT NULL")]
		public int Animal
		{
			get
			{
				return this._Animal;
			}
			set
			{
				if ((this._Animal != value))
				{
					if (this._Animal1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAnimalChanging(value);
					this.SendPropertyChanging();
					this._Animal = value;
					this.SendPropertyChanged("Animal");
					this.OnAnimalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tratamento", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Tratamento
		{
			get
			{
				return this._Tratamento;
			}
			set
			{
				if ((this._Tratamento != value))
				{
					this.OnTratamentoChanging(value);
					this.SendPropertyChanging();
					this._Tratamento = value;
					this.SendPropertyChanged("Tratamento");
					this.OnTratamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaConsulta", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DiaConsulta
		{
			get
			{
				return this._DiaConsulta;
			}
			set
			{
				if ((this._DiaConsulta != value))
				{
					this.OnDiaConsultaChanging(value);
					this.SendPropertyChanging();
					this._DiaConsulta = value;
					this.SendPropertyChanged("DiaConsulta");
					this.OnDiaConsultaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoraConsulta", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string HoraConsulta
		{
			get
			{
				return this._HoraConsulta;
			}
			set
			{
				if ((this._HoraConsulta != value))
				{
					this.OnHoraConsultaChanging(value);
					this.SendPropertyChanging();
					this._HoraConsulta = value;
					this.SendPropertyChanged("HoraConsulta");
					this.OnHoraConsultaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notas", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Notas
		{
			get
			{
				return this._Notas;
			}
			set
			{
				if ((this._Notas != value))
				{
					this.OnNotasChanging(value);
					this.SendPropertyChanging();
					this._Notas = value;
					this.SendPropertyChanged("Notas");
					this.OnNotasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_Consulta", Storage="_Animal1", ThisKey="Animal", OtherKey="ID", IsForeignKey=true)]
		public Animal Animal1
		{
			get
			{
				return this._Animal1.Entity;
			}
			set
			{
				Animal previousValue = this._Animal1.Entity;
				if (((previousValue != value) 
							|| (this._Animal1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Animal1.Entity = null;
						previousValue.Consultas.Remove(this);
					}
					this._Animal1.Entity = value;
					if ((value != null))
					{
						value.Consultas.Add(this);
						this._Animal = value.ID;
					}
					else
					{
						this._Animal = default(int);
					}
					this.SendPropertyChanged("Animal1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Consulta", Storage="_Cliente1", ThisKey="Cliente", OtherKey="ID", IsForeignKey=true)]
		public Cliente Cliente1
		{
			get
			{
				return this._Cliente1.Entity;
			}
			set
			{
				Cliente previousValue = this._Cliente1.Entity;
				if (((previousValue != value) 
							|| (this._Cliente1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cliente1.Entity = null;
						previousValue.Consultas.Remove(this);
					}
					this._Cliente1.Entity = value;
					if ((value != null))
					{
						value.Consultas.Add(this);
						this._Cliente = value.ID;
					}
					else
					{
						this._Cliente = default(int);
					}
					this.SendPropertyChanged("Cliente1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Medico1_Consulta", Storage="_Medico11", ThisKey="Medico", OtherKey="ID", IsForeignKey=true)]
		public Medico Medico11
		{
			get
			{
				return this._Medico11.Entity;
			}
			set
			{
				Medico previousValue = this._Medico11.Entity;
				if (((previousValue != value) 
							|| (this._Medico11.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Medico11.Entity = null;
						previousValue.Consultas.Remove(this);
					}
					this._Medico11.Entity = value;
					if ((value != null))
					{
						value.Consultas.Add(this);
						this._Medico = value.ID;
					}
					else
					{
						this._Medico = default(int);
					}
					this.SendPropertyChanged("Medico11");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Medico")]
	public partial class Medico : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Nome;
		
		private string _TipoAnimal;
		
		private string _NIF;
		
		private string _Telemovel;
		
		private string _Email;
		
		private string _SalaObs;
		
		private EntitySet<Consulta> _Consultas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnTipoAnimalChanging(string value);
    partial void OnTipoAnimalChanged();
    partial void OnNIFChanging(string value);
    partial void OnNIFChanged();
    partial void OnTelemovelChanging(string value);
    partial void OnTelemovelChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSalaObsChanging(string value);
    partial void OnSalaObsChanged();
    #endregion
		
		public Medico()
		{
			this._Consultas = new EntitySet<Consulta>(new Action<Consulta>(this.attach_Consultas), new Action<Consulta>(this.detach_Consultas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoAnimal", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TipoAnimal
		{
			get
			{
				return this._TipoAnimal;
			}
			set
			{
				if ((this._TipoAnimal != value))
				{
					this.OnTipoAnimalChanging(value);
					this.SendPropertyChanging();
					this._TipoAnimal = value;
					this.SendPropertyChanged("TipoAnimal");
					this.OnTipoAnimalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NIF", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NIF
		{
			get
			{
				return this._NIF;
			}
			set
			{
				if ((this._NIF != value))
				{
					this.OnNIFChanging(value);
					this.SendPropertyChanging();
					this._NIF = value;
					this.SendPropertyChanged("NIF");
					this.OnNIFChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telemovel", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Telemovel
		{
			get
			{
				return this._Telemovel;
			}
			set
			{
				if ((this._Telemovel != value))
				{
					this.OnTelemovelChanging(value);
					this.SendPropertyChanging();
					this._Telemovel = value;
					this.SendPropertyChanged("Telemovel");
					this.OnTelemovelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalaObs", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SalaObs
		{
			get
			{
				return this._SalaObs;
			}
			set
			{
				if ((this._SalaObs != value))
				{
					this.OnSalaObsChanging(value);
					this.SendPropertyChanging();
					this._SalaObs = value;
					this.SendPropertyChanged("SalaObs");
					this.OnSalaObsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Medico1_Consulta", Storage="_Consultas", ThisKey="ID", OtherKey="Medico")]
		public EntitySet<Consulta> Consultas
		{
			get
			{
				return this._Consultas;
			}
			set
			{
				this._Consultas.Assign(value);
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
		
		private void attach_Consultas(Consulta entity)
		{
			this.SendPropertyChanging();
			entity.Medico11 = this;
		}
		
		private void detach_Consultas(Consulta entity)
		{
			this.SendPropertyChanging();
			entity.Medico11 = null;
		}
	}
}
#pragma warning restore 1591
