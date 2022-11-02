﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Ventas")]
	public partial class VentasDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    partial void InsertProducto(Producto instance);
    partial void UpdateProducto(Producto instance);
    partial void DeleteProducto(Producto instance);
    partial void InsertTipoDocumento(TipoDocumento instance);
    partial void UpdateTipoDocumento(TipoDocumento instance);
    partial void DeleteTipoDocumento(TipoDocumento instance);
    partial void InsertVenta(Venta instance);
    partial void UpdateVenta(Venta instance);
    partial void DeleteVenta(Venta instance);
    partial void InsertVentaProducto(VentaProducto instance);
    partial void UpdateVentaProducto(VentaProducto instance);
    partial void DeleteVentaProducto(VentaProducto instance);
    #endregion
		
		public VentasDataContext() : 
				base(global::Repositorio.Properties.Settings.Default.VentasConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VentasDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cliente> Cliente
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public System.Data.Linq.Table<Producto> Producto
		{
			get
			{
				return this.GetTable<Producto>();
			}
		}
		
		public System.Data.Linq.Table<TipoDocumento> TipoDocumento
		{
			get
			{
				return this.GetTable<TipoDocumento>();
			}
		}
		
		public System.Data.Linq.Table<Venta> Venta
		{
			get
			{
				return this.GetTable<Venta>();
			}
		}
		
		public System.Data.Linq.Table<VentaProducto> VentaProducto
		{
			get
			{
				return this.GetTable<VentaProducto>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cliente")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Cliente_Id;
		
		private string _Cliente_Nombre;
		
		private string _Cliente_Apellido;
		
		private string _Cliente_Telefono;
		
		private System.Nullable<int> _TipoDocumento_Id;
		
		private string _Cliente_Documento;
		
		private System.Nullable<bool> _Cliente_Estado;
		
		private System.Nullable<System.DateTime> _Cliente_FechaCreacion;
		
		private System.Nullable<System.DateTime> _Cliente_FechaActualizacion;
		
		private EntitySet<Venta> _Venta;
		
		private EntityRef<TipoDocumento> _TipoDocumento;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCliente_IdChanging(int value);
    partial void OnCliente_IdChanged();
    partial void OnCliente_NombreChanging(string value);
    partial void OnCliente_NombreChanged();
    partial void OnCliente_ApellidoChanging(string value);
    partial void OnCliente_ApellidoChanged();
    partial void OnCliente_TelefonoChanging(string value);
    partial void OnCliente_TelefonoChanged();
    partial void OnTipoDocumento_IdChanging(System.Nullable<int> value);
    partial void OnTipoDocumento_IdChanged();
    partial void OnCliente_DocumentoChanging(string value);
    partial void OnCliente_DocumentoChanged();
    partial void OnCliente_EstadoChanging(System.Nullable<bool> value);
    partial void OnCliente_EstadoChanged();
    partial void OnCliente_FechaCreacionChanging(System.Nullable<System.DateTime> value);
    partial void OnCliente_FechaCreacionChanged();
    partial void OnCliente_FechaActualizacionChanging(System.Nullable<System.DateTime> value);
    partial void OnCliente_FechaActualizacionChanged();
    #endregion
		
		public Cliente()
		{
			this._Venta = new EntitySet<Venta>(new Action<Venta>(this.attach_Venta), new Action<Venta>(this.detach_Venta));
			this._TipoDocumento = default(EntityRef<TipoDocumento>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Cliente_Id
		{
			get
			{
				return this._Cliente_Id;
			}
			set
			{
				if ((this._Cliente_Id != value))
				{
					this.OnCliente_IdChanging(value);
					this.SendPropertyChanging();
					this._Cliente_Id = value;
					this.SendPropertyChanged("Cliente_Id");
					this.OnCliente_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente_Nombre", DbType="NVarChar(100)")]
		public string Cliente_Nombre
		{
			get
			{
				return this._Cliente_Nombre;
			}
			set
			{
				if ((this._Cliente_Nombre != value))
				{
					this.OnCliente_NombreChanging(value);
					this.SendPropertyChanging();
					this._Cliente_Nombre = value;
					this.SendPropertyChanged("Cliente_Nombre");
					this.OnCliente_NombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente_Apellido", DbType="NVarChar(100)")]
		public string Cliente_Apellido
		{
			get
			{
				return this._Cliente_Apellido;
			}
			set
			{
				if ((this._Cliente_Apellido != value))
				{
					this.OnCliente_ApellidoChanging(value);
					this.SendPropertyChanging();
					this._Cliente_Apellido = value;
					this.SendPropertyChanged("Cliente_Apellido");
					this.OnCliente_ApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente_Telefono", DbType="NVarChar(50)")]
		public string Cliente_Telefono
		{
			get
			{
				return this._Cliente_Telefono;
			}
			set
			{
				if ((this._Cliente_Telefono != value))
				{
					this.OnCliente_TelefonoChanging(value);
					this.SendPropertyChanging();
					this._Cliente_Telefono = value;
					this.SendPropertyChanged("Cliente_Telefono");
					this.OnCliente_TelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDocumento_Id", DbType="Int")]
		public System.Nullable<int> TipoDocumento_Id
		{
			get
			{
				return this._TipoDocumento_Id;
			}
			set
			{
				if ((this._TipoDocumento_Id != value))
				{
					if (this._TipoDocumento.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTipoDocumento_IdChanging(value);
					this.SendPropertyChanging();
					this._TipoDocumento_Id = value;
					this.SendPropertyChanged("TipoDocumento_Id");
					this.OnTipoDocumento_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente_Documento", DbType="NVarChar(100)")]
		public string Cliente_Documento
		{
			get
			{
				return this._Cliente_Documento;
			}
			set
			{
				if ((this._Cliente_Documento != value))
				{
					this.OnCliente_DocumentoChanging(value);
					this.SendPropertyChanging();
					this._Cliente_Documento = value;
					this.SendPropertyChanged("Cliente_Documento");
					this.OnCliente_DocumentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente_Estado", DbType="Bit")]
		public System.Nullable<bool> Cliente_Estado
		{
			get
			{
				return this._Cliente_Estado;
			}
			set
			{
				if ((this._Cliente_Estado != value))
				{
					this.OnCliente_EstadoChanging(value);
					this.SendPropertyChanging();
					this._Cliente_Estado = value;
					this.SendPropertyChanged("Cliente_Estado");
					this.OnCliente_EstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente_FechaCreacion", DbType="Date")]
		public System.Nullable<System.DateTime> Cliente_FechaCreacion
		{
			get
			{
				return this._Cliente_FechaCreacion;
			}
			set
			{
				if ((this._Cliente_FechaCreacion != value))
				{
					this.OnCliente_FechaCreacionChanging(value);
					this.SendPropertyChanging();
					this._Cliente_FechaCreacion = value;
					this.SendPropertyChanged("Cliente_FechaCreacion");
					this.OnCliente_FechaCreacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente_FechaActualizacion", DbType="Date")]
		public System.Nullable<System.DateTime> Cliente_FechaActualizacion
		{
			get
			{
				return this._Cliente_FechaActualizacion;
			}
			set
			{
				if ((this._Cliente_FechaActualizacion != value))
				{
					this.OnCliente_FechaActualizacionChanging(value);
					this.SendPropertyChanging();
					this._Cliente_FechaActualizacion = value;
					this.SendPropertyChanged("Cliente_FechaActualizacion");
					this.OnCliente_FechaActualizacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Venta", Storage="_Venta", ThisKey="Cliente_Id", OtherKey="Cliente_Id")]
		public EntitySet<Venta> Venta
		{
			get
			{
				return this._Venta;
			}
			set
			{
				this._Venta.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TipoDocumento_Cliente", Storage="_TipoDocumento", ThisKey="TipoDocumento_Id", OtherKey="TipoDocumento_Id", IsForeignKey=true)]
		public TipoDocumento TipoDocumento
		{
			get
			{
				return this._TipoDocumento.Entity;
			}
			set
			{
				TipoDocumento previousValue = this._TipoDocumento.Entity;
				if (((previousValue != value) 
							|| (this._TipoDocumento.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TipoDocumento.Entity = null;
						previousValue.Cliente.Remove(this);
					}
					this._TipoDocumento.Entity = value;
					if ((value != null))
					{
						value.Cliente.Add(this);
						this._TipoDocumento_Id = value.TipoDocumento_Id;
					}
					else
					{
						this._TipoDocumento_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("TipoDocumento");
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
		
		private void attach_Venta(Venta entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = this;
		}
		
		private void detach_Venta(Venta entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Producto")]
	public partial class Producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Producto_Id;
		
		private string _Producto_Nombre;
		
		private string _Producto_Descripcion;
		
		private System.Nullable<decimal> _Producto_ValorUnitario;
		
		private System.Nullable<bool> _Producto_Estado;
		
		private System.Nullable<System.DateTime> _Producto_FechaCreacion;
		
		private System.Nullable<System.DateTime> _Producto_FechaActualizacion;
		
		private EntitySet<VentaProducto> _VentaProducto;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProducto_IdChanging(int value);
    partial void OnProducto_IdChanged();
    partial void OnProducto_NombreChanging(string value);
    partial void OnProducto_NombreChanged();
    partial void OnProducto_DescripcionChanging(string value);
    partial void OnProducto_DescripcionChanged();
    partial void OnProducto_ValorUnitarioChanging(System.Nullable<decimal> value);
    partial void OnProducto_ValorUnitarioChanged();
    partial void OnProducto_EstadoChanging(System.Nullable<bool> value);
    partial void OnProducto_EstadoChanged();
    partial void OnProducto_FechaCreacionChanging(System.Nullable<System.DateTime> value);
    partial void OnProducto_FechaCreacionChanged();
    partial void OnProducto_FechaActualizacionChanging(System.Nullable<System.DateTime> value);
    partial void OnProducto_FechaActualizacionChanged();
    #endregion
		
		public Producto()
		{
			this._VentaProducto = new EntitySet<VentaProducto>(new Action<VentaProducto>(this.attach_VentaProducto), new Action<VentaProducto>(this.detach_VentaProducto));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Producto_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Producto_Id
		{
			get
			{
				return this._Producto_Id;
			}
			set
			{
				if ((this._Producto_Id != value))
				{
					this.OnProducto_IdChanging(value);
					this.SendPropertyChanging();
					this._Producto_Id = value;
					this.SendPropertyChanged("Producto_Id");
					this.OnProducto_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Producto_Nombre", DbType="NVarChar(150)")]
		public string Producto_Nombre
		{
			get
			{
				return this._Producto_Nombre;
			}
			set
			{
				if ((this._Producto_Nombre != value))
				{
					this.OnProducto_NombreChanging(value);
					this.SendPropertyChanging();
					this._Producto_Nombre = value;
					this.SendPropertyChanged("Producto_Nombre");
					this.OnProducto_NombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Producto_Descripcion", DbType="NVarChar(500)")]
		public string Producto_Descripcion
		{
			get
			{
				return this._Producto_Descripcion;
			}
			set
			{
				if ((this._Producto_Descripcion != value))
				{
					this.OnProducto_DescripcionChanging(value);
					this.SendPropertyChanging();
					this._Producto_Descripcion = value;
					this.SendPropertyChanged("Producto_Descripcion");
					this.OnProducto_DescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Producto_ValorUnitario", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Producto_ValorUnitario
		{
			get
			{
				return this._Producto_ValorUnitario;
			}
			set
			{
				if ((this._Producto_ValorUnitario != value))
				{
					this.OnProducto_ValorUnitarioChanging(value);
					this.SendPropertyChanging();
					this._Producto_ValorUnitario = value;
					this.SendPropertyChanged("Producto_ValorUnitario");
					this.OnProducto_ValorUnitarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Producto_Estado", DbType="Bit")]
		public System.Nullable<bool> Producto_Estado
		{
			get
			{
				return this._Producto_Estado;
			}
			set
			{
				if ((this._Producto_Estado != value))
				{
					this.OnProducto_EstadoChanging(value);
					this.SendPropertyChanging();
					this._Producto_Estado = value;
					this.SendPropertyChanged("Producto_Estado");
					this.OnProducto_EstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Producto_FechaCreacion", DbType="Date")]
		public System.Nullable<System.DateTime> Producto_FechaCreacion
		{
			get
			{
				return this._Producto_FechaCreacion;
			}
			set
			{
				if ((this._Producto_FechaCreacion != value))
				{
					this.OnProducto_FechaCreacionChanging(value);
					this.SendPropertyChanging();
					this._Producto_FechaCreacion = value;
					this.SendPropertyChanged("Producto_FechaCreacion");
					this.OnProducto_FechaCreacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Producto_FechaActualizacion", DbType="Date")]
		public System.Nullable<System.DateTime> Producto_FechaActualizacion
		{
			get
			{
				return this._Producto_FechaActualizacion;
			}
			set
			{
				if ((this._Producto_FechaActualizacion != value))
				{
					this.OnProducto_FechaActualizacionChanging(value);
					this.SendPropertyChanging();
					this._Producto_FechaActualizacion = value;
					this.SendPropertyChanged("Producto_FechaActualizacion");
					this.OnProducto_FechaActualizacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_VentaProducto", Storage="_VentaProducto", ThisKey="Producto_Id", OtherKey="Producto_Id")]
		public EntitySet<VentaProducto> VentaProducto
		{
			get
			{
				return this._VentaProducto;
			}
			set
			{
				this._VentaProducto.Assign(value);
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
		
		private void attach_VentaProducto(VentaProducto entity)
		{
			this.SendPropertyChanging();
			entity.Producto = this;
		}
		
		private void detach_VentaProducto(VentaProducto entity)
		{
			this.SendPropertyChanging();
			entity.Producto = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TipoDocumento")]
	public partial class TipoDocumento : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TipoDocumento_Id;
		
		private string _TipoDocumento_Nombre;
		
		private string _TipoDocumento_Descripcion;
		
		private System.Nullable<bool> _TipoDocumento_Estado;
		
		private EntitySet<Cliente> _Cliente;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTipoDocumento_IdChanging(int value);
    partial void OnTipoDocumento_IdChanged();
    partial void OnTipoDocumento_NombreChanging(string value);
    partial void OnTipoDocumento_NombreChanged();
    partial void OnTipoDocumento_DescripcionChanging(string value);
    partial void OnTipoDocumento_DescripcionChanged();
    partial void OnTipoDocumento_EstadoChanging(System.Nullable<bool> value);
    partial void OnTipoDocumento_EstadoChanged();
    #endregion
		
		public TipoDocumento()
		{
			this._Cliente = new EntitySet<Cliente>(new Action<Cliente>(this.attach_Cliente), new Action<Cliente>(this.detach_Cliente));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDocumento_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int TipoDocumento_Id
		{
			get
			{
				return this._TipoDocumento_Id;
			}
			set
			{
				if ((this._TipoDocumento_Id != value))
				{
					this.OnTipoDocumento_IdChanging(value);
					this.SendPropertyChanging();
					this._TipoDocumento_Id = value;
					this.SendPropertyChanged("TipoDocumento_Id");
					this.OnTipoDocumento_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDocumento_Nombre", DbType="NVarChar(50)")]
		public string TipoDocumento_Nombre
		{
			get
			{
				return this._TipoDocumento_Nombre;
			}
			set
			{
				if ((this._TipoDocumento_Nombre != value))
				{
					this.OnTipoDocumento_NombreChanging(value);
					this.SendPropertyChanging();
					this._TipoDocumento_Nombre = value;
					this.SendPropertyChanged("TipoDocumento_Nombre");
					this.OnTipoDocumento_NombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDocumento_Descripcion", DbType="NVarChar(100)")]
		public string TipoDocumento_Descripcion
		{
			get
			{
				return this._TipoDocumento_Descripcion;
			}
			set
			{
				if ((this._TipoDocumento_Descripcion != value))
				{
					this.OnTipoDocumento_DescripcionChanging(value);
					this.SendPropertyChanging();
					this._TipoDocumento_Descripcion = value;
					this.SendPropertyChanged("TipoDocumento_Descripcion");
					this.OnTipoDocumento_DescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDocumento_Estado", DbType="Bit")]
		public System.Nullable<bool> TipoDocumento_Estado
		{
			get
			{
				return this._TipoDocumento_Estado;
			}
			set
			{
				if ((this._TipoDocumento_Estado != value))
				{
					this.OnTipoDocumento_EstadoChanging(value);
					this.SendPropertyChanging();
					this._TipoDocumento_Estado = value;
					this.SendPropertyChanged("TipoDocumento_Estado");
					this.OnTipoDocumento_EstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TipoDocumento_Cliente", Storage="_Cliente", ThisKey="TipoDocumento_Id", OtherKey="TipoDocumento_Id")]
		public EntitySet<Cliente> Cliente
		{
			get
			{
				return this._Cliente;
			}
			set
			{
				this._Cliente.Assign(value);
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
		
		private void attach_Cliente(Cliente entity)
		{
			this.SendPropertyChanging();
			entity.TipoDocumento = this;
		}
		
		private void detach_Cliente(Cliente entity)
		{
			this.SendPropertyChanging();
			entity.TipoDocumento = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Venta")]
	public partial class Venta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Venta_Id;
		
		private int _Cliente_Id;
		
		private System.Nullable<System.DateTime> _Venta_FechaCreacion;
		
		private System.Nullable<bool> _Venta_Estado;
		
		private EntitySet<VentaProducto> _VentaProducto;
		
		private EntityRef<Cliente> _Cliente;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVenta_IdChanging(int value);
    partial void OnVenta_IdChanged();
    partial void OnCliente_IdChanging(int value);
    partial void OnCliente_IdChanged();
    partial void OnVenta_FechaCreacionChanging(System.Nullable<System.DateTime> value);
    partial void OnVenta_FechaCreacionChanged();
    partial void OnVenta_EstadoChanging(System.Nullable<bool> value);
    partial void OnVenta_EstadoChanged();
    #endregion
		
		public Venta()
		{
			this._VentaProducto = new EntitySet<VentaProducto>(new Action<VentaProducto>(this.attach_VentaProducto), new Action<VentaProducto>(this.detach_VentaProducto));
			this._Cliente = default(EntityRef<Cliente>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Venta_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Venta_Id
		{
			get
			{
				return this._Venta_Id;
			}
			set
			{
				if ((this._Venta_Id != value))
				{
					this.OnVenta_IdChanging(value);
					this.SendPropertyChanging();
					this._Venta_Id = value;
					this.SendPropertyChanged("Venta_Id");
					this.OnVenta_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cliente_Id", DbType="Int NOT NULL")]
		public int Cliente_Id
		{
			get
			{
				return this._Cliente_Id;
			}
			set
			{
				if ((this._Cliente_Id != value))
				{
					if (this._Cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCliente_IdChanging(value);
					this.SendPropertyChanging();
					this._Cliente_Id = value;
					this.SendPropertyChanged("Cliente_Id");
					this.OnCliente_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Venta_FechaCreacion", DbType="Date")]
		public System.Nullable<System.DateTime> Venta_FechaCreacion
		{
			get
			{
				return this._Venta_FechaCreacion;
			}
			set
			{
				if ((this._Venta_FechaCreacion != value))
				{
					this.OnVenta_FechaCreacionChanging(value);
					this.SendPropertyChanging();
					this._Venta_FechaCreacion = value;
					this.SendPropertyChanged("Venta_FechaCreacion");
					this.OnVenta_FechaCreacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Venta_Estado", DbType="Bit")]
		public System.Nullable<bool> Venta_Estado
		{
			get
			{
				return this._Venta_Estado;
			}
			set
			{
				if ((this._Venta_Estado != value))
				{
					this.OnVenta_EstadoChanging(value);
					this.SendPropertyChanging();
					this._Venta_Estado = value;
					this.SendPropertyChanged("Venta_Estado");
					this.OnVenta_EstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Venta_VentaProducto", Storage="_VentaProducto", ThisKey="Venta_Id", OtherKey="Venta_Id")]
		public EntitySet<VentaProducto> VentaProducto
		{
			get
			{
				return this._VentaProducto;
			}
			set
			{
				this._VentaProducto.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Venta", Storage="_Cliente", ThisKey="Cliente_Id", OtherKey="Cliente_Id", IsForeignKey=true)]
		public Cliente Cliente
		{
			get
			{
				return this._Cliente.Entity;
			}
			set
			{
				Cliente previousValue = this._Cliente.Entity;
				if (((previousValue != value) 
							|| (this._Cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cliente.Entity = null;
						previousValue.Venta.Remove(this);
					}
					this._Cliente.Entity = value;
					if ((value != null))
					{
						value.Venta.Add(this);
						this._Cliente_Id = value.Cliente_Id;
					}
					else
					{
						this._Cliente_Id = default(int);
					}
					this.SendPropertyChanged("Cliente");
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
		
		private void attach_VentaProducto(VentaProducto entity)
		{
			this.SendPropertyChanging();
			entity.Venta = this;
		}
		
		private void detach_VentaProducto(VentaProducto entity)
		{
			this.SendPropertyChanging();
			entity.Venta = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VentaProducto")]
	public partial class VentaProducto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _VentaProducto_Id;
		
		private int _Venta_Id;
		
		private int _Producto_Id;
		
		private decimal _VentaProducto_ValorUnitario;
		
		private int _VentaProducto_Cantidad;
		
		private EntityRef<Producto> _Producto;
		
		private EntityRef<Venta> _Venta;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVentaProducto_IdChanging(int value);
    partial void OnVentaProducto_IdChanged();
    partial void OnVenta_IdChanging(int value);
    partial void OnVenta_IdChanged();
    partial void OnProducto_IdChanging(int value);
    partial void OnProducto_IdChanged();
    partial void OnVentaProducto_ValorUnitarioChanging(decimal value);
    partial void OnVentaProducto_ValorUnitarioChanged();
    partial void OnVentaProducto_CantidadChanging(int value);
    partial void OnVentaProducto_CantidadChanged();
    #endregion
		
		public VentaProducto()
		{
			this._Producto = default(EntityRef<Producto>);
			this._Venta = default(EntityRef<Venta>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VentaProducto_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int VentaProducto_Id
		{
			get
			{
				return this._VentaProducto_Id;
			}
			set
			{
				if ((this._VentaProducto_Id != value))
				{
					this.OnVentaProducto_IdChanging(value);
					this.SendPropertyChanging();
					this._VentaProducto_Id = value;
					this.SendPropertyChanged("VentaProducto_Id");
					this.OnVentaProducto_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Venta_Id", DbType="Int NOT NULL")]
		public int Venta_Id
		{
			get
			{
				return this._Venta_Id;
			}
			set
			{
				if ((this._Venta_Id != value))
				{
					if (this._Venta.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnVenta_IdChanging(value);
					this.SendPropertyChanging();
					this._Venta_Id = value;
					this.SendPropertyChanged("Venta_Id");
					this.OnVenta_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Producto_Id", DbType="Int NOT NULL")]
		public int Producto_Id
		{
			get
			{
				return this._Producto_Id;
			}
			set
			{
				if ((this._Producto_Id != value))
				{
					if (this._Producto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProducto_IdChanging(value);
					this.SendPropertyChanging();
					this._Producto_Id = value;
					this.SendPropertyChanged("Producto_Id");
					this.OnProducto_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VentaProducto_ValorUnitario", DbType="Decimal(18,2) NOT NULL")]
		public decimal VentaProducto_ValorUnitario
		{
			get
			{
				return this._VentaProducto_ValorUnitario;
			}
			set
			{
				if ((this._VentaProducto_ValorUnitario != value))
				{
					this.OnVentaProducto_ValorUnitarioChanging(value);
					this.SendPropertyChanging();
					this._VentaProducto_ValorUnitario = value;
					this.SendPropertyChanged("VentaProducto_ValorUnitario");
					this.OnVentaProducto_ValorUnitarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VentaProducto_Cantidad", DbType="Int NOT NULL")]
		public int VentaProducto_Cantidad
		{
			get
			{
				return this._VentaProducto_Cantidad;
			}
			set
			{
				if ((this._VentaProducto_Cantidad != value))
				{
					this.OnVentaProducto_CantidadChanging(value);
					this.SendPropertyChanging();
					this._VentaProducto_Cantidad = value;
					this.SendPropertyChanged("VentaProducto_Cantidad");
					this.OnVentaProducto_CantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_VentaProducto", Storage="_Producto", ThisKey="Producto_Id", OtherKey="Producto_Id", IsForeignKey=true)]
		public Producto Producto
		{
			get
			{
				return this._Producto.Entity;
			}
			set
			{
				Producto previousValue = this._Producto.Entity;
				if (((previousValue != value) 
							|| (this._Producto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producto.Entity = null;
						previousValue.VentaProducto.Remove(this);
					}
					this._Producto.Entity = value;
					if ((value != null))
					{
						value.VentaProducto.Add(this);
						this._Producto_Id = value.Producto_Id;
					}
					else
					{
						this._Producto_Id = default(int);
					}
					this.SendPropertyChanged("Producto");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Venta_VentaProducto", Storage="_Venta", ThisKey="Venta_Id", OtherKey="Venta_Id", IsForeignKey=true)]
		public Venta Venta
		{
			get
			{
				return this._Venta.Entity;
			}
			set
			{
				Venta previousValue = this._Venta.Entity;
				if (((previousValue != value) 
							|| (this._Venta.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Venta.Entity = null;
						previousValue.VentaProducto.Remove(this);
					}
					this._Venta.Entity = value;
					if ((value != null))
					{
						value.VentaProducto.Add(this);
						this._Venta_Id = value.Venta_Id;
					}
					else
					{
						this._Venta_Id = default(int);
					}
					this.SendPropertyChanged("Venta");
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