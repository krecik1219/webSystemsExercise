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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="psw_lab_mssql")]
public partial class StockDbDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertcategory(category instance);
  partial void Updatecategory(category instance);
  partial void Deletecategory(category instance);
  partial void Insertorder(order instance);
  partial void Updateorder(order instance);
  partial void Deleteorder(order instance);
  partial void Insertorders_stock(orders_stock instance);
  partial void Updateorders_stock(orders_stock instance);
  partial void Deleteorders_stock(orders_stock instance);
  partial void Insertstock(stock instance);
  partial void Updatestock(stock instance);
  partial void Deletestock(stock instance);
  partial void Insertsubcategory(subcategory instance);
  partial void Updatesubcategory(subcategory instance);
  partial void Deletesubcategory(subcategory instance);
  partial void Insertuser(user instance);
  partial void Updateuser(user instance);
  partial void Deleteuser(user instance);
  #endregion
	
	public StockDbDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["psw_lab_mssqlConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public StockDbDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public StockDbDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public StockDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public StockDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<category> categories
	{
		get
		{
			return this.GetTable<category>();
		}
	}
	
	public System.Data.Linq.Table<order> orders
	{
		get
		{
			return this.GetTable<order>();
		}
	}
	
	public System.Data.Linq.Table<orders_stock> orders_stocks
	{
		get
		{
			return this.GetTable<orders_stock>();
		}
	}
	
	public System.Data.Linq.Table<stock> stocks
	{
		get
		{
			return this.GetTable<stock>();
		}
	}
	
	public System.Data.Linq.Table<subcategory> subcategories
	{
		get
		{
			return this.GetTable<subcategory>();
		}
	}
	
	public System.Data.Linq.Table<user> users
	{
		get
		{
			return this.GetTable<user>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.categories")]
public partial class category : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_category;
	
	private string _category_name;
	
	private EntitySet<subcategory> _subcategories;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_categoryChanging(int value);
    partial void Onid_categoryChanged();
    partial void Oncategory_nameChanging(string value);
    partial void Oncategory_nameChanged();
    #endregion
	
	public category()
	{
		this._subcategories = new EntitySet<subcategory>(new Action<subcategory>(this.attach_subcategories), new Action<subcategory>(this.detach_subcategories));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_category", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_category
	{
		get
		{
			return this._id_category;
		}
		set
		{
			if ((this._id_category != value))
			{
				this.Onid_categoryChanging(value);
				this.SendPropertyChanging();
				this._id_category = value;
				this.SendPropertyChanged("id_category");
				this.Onid_categoryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string category_name
	{
		get
		{
			return this._category_name;
		}
		set
		{
			if ((this._category_name != value))
			{
				this.Oncategory_nameChanging(value);
				this.SendPropertyChanging();
				this._category_name = value;
				this.SendPropertyChanged("category_name");
				this.Oncategory_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="category_subcategory", Storage="_subcategories", ThisKey="id_category", OtherKey="id_category")]
	public EntitySet<subcategory> subcategories
	{
		get
		{
			return this._subcategories;
		}
		set
		{
			this._subcategories.Assign(value);
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
	
	private void attach_subcategories(subcategory entity)
	{
		this.SendPropertyChanging();
		entity.category = this;
	}
	
	private void detach_subcategories(subcategory entity)
	{
		this.SendPropertyChanging();
		entity.category = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.orders")]
public partial class order : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_order;
	
	private System.Nullable<int> _id_user;
	
	private System.DateTime _order_date;
	
	private EntitySet<orders_stock> _orders_stocks;
	
	private EntityRef<user> _user;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_orderChanging(int value);
    partial void Onid_orderChanged();
    partial void Onid_userChanging(System.Nullable<int> value);
    partial void Onid_userChanged();
    partial void Onorder_dateChanging(System.DateTime value);
    partial void Onorder_dateChanged();
    #endregion
	
	public order()
	{
		this._orders_stocks = new EntitySet<orders_stock>(new Action<orders_stock>(this.attach_orders_stocks), new Action<orders_stock>(this.detach_orders_stocks));
		this._user = default(EntityRef<user>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_order", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_order
	{
		get
		{
			return this._id_order;
		}
		set
		{
			if ((this._id_order != value))
			{
				this.Onid_orderChanging(value);
				this.SendPropertyChanging();
				this._id_order = value;
				this.SendPropertyChanged("id_order");
				this.Onid_orderChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_user", DbType="Int")]
	public System.Nullable<int> id_user
	{
		get
		{
			return this._id_user;
		}
		set
		{
			if ((this._id_user != value))
			{
				if (this._user.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_userChanging(value);
				this.SendPropertyChanging();
				this._id_user = value;
				this.SendPropertyChanged("id_user");
				this.Onid_userChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_date", DbType="Date NOT NULL")]
	public System.DateTime order_date
	{
		get
		{
			return this._order_date;
		}
		set
		{
			if ((this._order_date != value))
			{
				this.Onorder_dateChanging(value);
				this.SendPropertyChanging();
				this._order_date = value;
				this.SendPropertyChanged("order_date");
				this.Onorder_dateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="order_orders_stock", Storage="_orders_stocks", ThisKey="id_order", OtherKey="id_order")]
	public EntitySet<orders_stock> orders_stocks
	{
		get
		{
			return this._orders_stocks;
		}
		set
		{
			this._orders_stocks.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_order", Storage="_user", ThisKey="id_user", OtherKey="id", IsForeignKey=true)]
	public user user
	{
		get
		{
			return this._user.Entity;
		}
		set
		{
			user previousValue = this._user.Entity;
			if (((previousValue != value) 
						|| (this._user.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._user.Entity = null;
					previousValue.orders.Remove(this);
				}
				this._user.Entity = value;
				if ((value != null))
				{
					value.orders.Add(this);
					this._id_user = value.id;
				}
				else
				{
					this._id_user = default(Nullable<int>);
				}
				this.SendPropertyChanged("user");
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
	
	private void attach_orders_stocks(orders_stock entity)
	{
		this.SendPropertyChanging();
		entity.order = this;
	}
	
	private void detach_orders_stocks(orders_stock entity)
	{
		this.SendPropertyChanging();
		entity.order = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.orders_stock")]
public partial class orders_stock : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_order;
	
	private int _id_item;
	
	private int _quantity;
	
	private EntityRef<order> _order;
	
	private EntityRef<stock> _stock;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_orderChanging(int value);
    partial void Onid_orderChanged();
    partial void Onid_itemChanging(int value);
    partial void Onid_itemChanged();
    partial void OnquantityChanging(int value);
    partial void OnquantityChanged();
    #endregion
	
	public orders_stock()
	{
		this._order = default(EntityRef<order>);
		this._stock = default(EntityRef<stock>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_order", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int id_order
	{
		get
		{
			return this._id_order;
		}
		set
		{
			if ((this._id_order != value))
			{
				if (this._order.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_orderChanging(value);
				this.SendPropertyChanging();
				this._id_order = value;
				this.SendPropertyChanged("id_order");
				this.Onid_orderChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_item", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int id_item
	{
		get
		{
			return this._id_item;
		}
		set
		{
			if ((this._id_item != value))
			{
				if (this._stock.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_itemChanging(value);
				this.SendPropertyChanging();
				this._id_item = value;
				this.SendPropertyChanged("id_item");
				this.Onid_itemChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int NOT NULL")]
	public int quantity
	{
		get
		{
			return this._quantity;
		}
		set
		{
			if ((this._quantity != value))
			{
				this.OnquantityChanging(value);
				this.SendPropertyChanging();
				this._quantity = value;
				this.SendPropertyChanged("quantity");
				this.OnquantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="order_orders_stock", Storage="_order", ThisKey="id_order", OtherKey="id_order", IsForeignKey=true)]
	public order order
	{
		get
		{
			return this._order.Entity;
		}
		set
		{
			order previousValue = this._order.Entity;
			if (((previousValue != value) 
						|| (this._order.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._order.Entity = null;
					previousValue.orders_stocks.Remove(this);
				}
				this._order.Entity = value;
				if ((value != null))
				{
					value.orders_stocks.Add(this);
					this._id_order = value.id_order;
				}
				else
				{
					this._id_order = default(int);
				}
				this.SendPropertyChanged("order");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="stock_orders_stock", Storage="_stock", ThisKey="id_item", OtherKey="id_item", IsForeignKey=true)]
	public stock stock
	{
		get
		{
			return this._stock.Entity;
		}
		set
		{
			stock previousValue = this._stock.Entity;
			if (((previousValue != value) 
						|| (this._stock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._stock.Entity = null;
					previousValue.orders_stocks.Remove(this);
				}
				this._stock.Entity = value;
				if ((value != null))
				{
					value.orders_stocks.Add(this);
					this._id_item = value.id_item;
				}
				else
				{
					this._id_item = default(int);
				}
				this.SendPropertyChanged("stock");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.stock")]
public partial class stock : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_item;
	
	private string _item_name;
	
	private int _id_subcategory;
	
	private decimal _price;
	
	private string _photo_url;
	
	private string _description;
	
	private int _quantity;
	
	private EntitySet<orders_stock> _orders_stocks;
	
	private EntityRef<subcategory> _subcategory;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_itemChanging(int value);
    partial void Onid_itemChanged();
    partial void Onitem_nameChanging(string value);
    partial void Onitem_nameChanged();
    partial void Onid_subcategoryChanging(int value);
    partial void Onid_subcategoryChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void Onphoto_urlChanging(string value);
    partial void Onphoto_urlChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnquantityChanging(int value);
    partial void OnquantityChanged();
    #endregion
	
	public stock()
	{
		this._orders_stocks = new EntitySet<orders_stock>(new Action<orders_stock>(this.attach_orders_stocks), new Action<orders_stock>(this.detach_orders_stocks));
		this._subcategory = default(EntityRef<subcategory>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_item", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_item
	{
		get
		{
			return this._id_item;
		}
		set
		{
			if ((this._id_item != value))
			{
				this.Onid_itemChanging(value);
				this.SendPropertyChanging();
				this._id_item = value;
				this.SendPropertyChanged("id_item");
				this.Onid_itemChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string item_name
	{
		get
		{
			return this._item_name;
		}
		set
		{
			if ((this._item_name != value))
			{
				this.Onitem_nameChanging(value);
				this.SendPropertyChanging();
				this._item_name = value;
				this.SendPropertyChanged("item_name");
				this.Onitem_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_subcategory", DbType="Int NOT NULL")]
	public int id_subcategory
	{
		get
		{
			return this._id_subcategory;
		}
		set
		{
			if ((this._id_subcategory != value))
			{
				if (this._subcategory.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_subcategoryChanging(value);
				this.SendPropertyChanging();
				this._id_subcategory = value;
				this.SendPropertyChanged("id_subcategory");
				this.Onid_subcategoryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(10,2) NOT NULL")]
	public decimal price
	{
		get
		{
			return this._price;
		}
		set
		{
			if ((this._price != value))
			{
				this.OnpriceChanging(value);
				this.SendPropertyChanging();
				this._price = value;
				this.SendPropertyChanged("price");
				this.OnpriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo_url", DbType="VarChar(100)")]
	public string photo_url
	{
		get
		{
			return this._photo_url;
		}
		set
		{
			if ((this._photo_url != value))
			{
				this.Onphoto_urlChanging(value);
				this.SendPropertyChanging();
				this._photo_url = value;
				this.SendPropertyChanged("photo_url");
				this.Onphoto_urlChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(255)")]
	public string description
	{
		get
		{
			return this._description;
		}
		set
		{
			if ((this._description != value))
			{
				this.OndescriptionChanging(value);
				this.SendPropertyChanging();
				this._description = value;
				this.SendPropertyChanged("description");
				this.OndescriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int NOT NULL")]
	public int quantity
	{
		get
		{
			return this._quantity;
		}
		set
		{
			if ((this._quantity != value))
			{
				this.OnquantityChanging(value);
				this.SendPropertyChanging();
				this._quantity = value;
				this.SendPropertyChanged("quantity");
				this.OnquantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="stock_orders_stock", Storage="_orders_stocks", ThisKey="id_item", OtherKey="id_item")]
	public EntitySet<orders_stock> orders_stocks
	{
		get
		{
			return this._orders_stocks;
		}
		set
		{
			this._orders_stocks.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="subcategory_stock", Storage="_subcategory", ThisKey="id_subcategory", OtherKey="id_subcategory", IsForeignKey=true)]
	public subcategory subcategory
	{
		get
		{
			return this._subcategory.Entity;
		}
		set
		{
			subcategory previousValue = this._subcategory.Entity;
			if (((previousValue != value) 
						|| (this._subcategory.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._subcategory.Entity = null;
					previousValue.stocks.Remove(this);
				}
				this._subcategory.Entity = value;
				if ((value != null))
				{
					value.stocks.Add(this);
					this._id_subcategory = value.id_subcategory;
				}
				else
				{
					this._id_subcategory = default(int);
				}
				this.SendPropertyChanged("subcategory");
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
	
	private void attach_orders_stocks(orders_stock entity)
	{
		this.SendPropertyChanging();
		entity.stock = this;
	}
	
	private void detach_orders_stocks(orders_stock entity)
	{
		this.SendPropertyChanging();
		entity.stock = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.subcategories")]
public partial class subcategory : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_subcategory;
	
	private string _subcategory_name;
	
	private int _id_category;
	
	private EntitySet<stock> _stocks;
	
	private EntityRef<category> _category;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_subcategoryChanging(int value);
    partial void Onid_subcategoryChanged();
    partial void Onsubcategory_nameChanging(string value);
    partial void Onsubcategory_nameChanged();
    partial void Onid_categoryChanging(int value);
    partial void Onid_categoryChanged();
    #endregion
	
	public subcategory()
	{
		this._stocks = new EntitySet<stock>(new Action<stock>(this.attach_stocks), new Action<stock>(this.detach_stocks));
		this._category = default(EntityRef<category>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_subcategory", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_subcategory
	{
		get
		{
			return this._id_subcategory;
		}
		set
		{
			if ((this._id_subcategory != value))
			{
				this.Onid_subcategoryChanging(value);
				this.SendPropertyChanging();
				this._id_subcategory = value;
				this.SendPropertyChanged("id_subcategory");
				this.Onid_subcategoryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subcategory_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string subcategory_name
	{
		get
		{
			return this._subcategory_name;
		}
		set
		{
			if ((this._subcategory_name != value))
			{
				this.Onsubcategory_nameChanging(value);
				this.SendPropertyChanging();
				this._subcategory_name = value;
				this.SendPropertyChanged("subcategory_name");
				this.Onsubcategory_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_category", DbType="Int NOT NULL")]
	public int id_category
	{
		get
		{
			return this._id_category;
		}
		set
		{
			if ((this._id_category != value))
			{
				if (this._category.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_categoryChanging(value);
				this.SendPropertyChanging();
				this._id_category = value;
				this.SendPropertyChanged("id_category");
				this.Onid_categoryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="subcategory_stock", Storage="_stocks", ThisKey="id_subcategory", OtherKey="id_subcategory")]
	public EntitySet<stock> stocks
	{
		get
		{
			return this._stocks;
		}
		set
		{
			this._stocks.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="category_subcategory", Storage="_category", ThisKey="id_category", OtherKey="id_category", IsForeignKey=true)]
	public category category
	{
		get
		{
			return this._category.Entity;
		}
		set
		{
			category previousValue = this._category.Entity;
			if (((previousValue != value) 
						|| (this._category.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._category.Entity = null;
					previousValue.subcategories.Remove(this);
				}
				this._category.Entity = value;
				if ((value != null))
				{
					value.subcategories.Add(this);
					this._id_category = value.id_category;
				}
				else
				{
					this._id_category = default(int);
				}
				this.SendPropertyChanged("category");
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
	
	private void attach_stocks(stock entity)
	{
		this.SendPropertyChanging();
		entity.subcategory = this;
	}
	
	private void detach_stocks(stock entity)
	{
		this.SendPropertyChanging();
		entity.subcategory = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _name;
	
	private string _surname;
	
	private string _email;
	
	private string _password;
	
	private string _mobile;
	
	private System.Nullable<System.DateTime> _birth_date;
	
	private EntitySet<order> _orders;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnsurnameChanging(string value);
    partial void OnsurnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnmobileChanging(string value);
    partial void OnmobileChanged();
    partial void Onbirth_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onbirth_dateChanged();
    #endregion
	
	public user()
	{
		this._orders = new EntitySet<order>(new Action<order>(this.attach_orders), new Action<order>(this.detach_orders));
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_surname", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
	public string surname
	{
		get
		{
			return this._surname;
		}
		set
		{
			if ((this._surname != value))
			{
				this.OnsurnameChanging(value);
				this.SendPropertyChanging();
				this._surname = value;
				this.SendPropertyChanged("surname");
				this.OnsurnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(60) NOT NULL", CanBeNull=false)]
	public string email
	{
		get
		{
			return this._email;
		}
		set
		{
			if ((this._email != value))
			{
				this.OnemailChanging(value);
				this.SendPropertyChanging();
				this._email = value;
				this.SendPropertyChanged("email");
				this.OnemailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string password
	{
		get
		{
			return this._password;
		}
		set
		{
			if ((this._password != value))
			{
				this.OnpasswordChanging(value);
				this.SendPropertyChanging();
				this._password = value;
				this.SendPropertyChanged("password");
				this.OnpasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mobile", DbType="VarChar(20)")]
	public string mobile
	{
		get
		{
			return this._mobile;
		}
		set
		{
			if ((this._mobile != value))
			{
				this.OnmobileChanging(value);
				this.SendPropertyChanging();
				this._mobile = value;
				this.SendPropertyChanged("mobile");
				this.OnmobileChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birth_date", DbType="Date")]
	public System.Nullable<System.DateTime> birth_date
	{
		get
		{
			return this._birth_date;
		}
		set
		{
			if ((this._birth_date != value))
			{
				this.Onbirth_dateChanging(value);
				this.SendPropertyChanging();
				this._birth_date = value;
				this.SendPropertyChanged("birth_date");
				this.Onbirth_dateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_order", Storage="_orders", ThisKey="id", OtherKey="id_user")]
	public EntitySet<order> orders
	{
		get
		{
			return this._orders;
		}
		set
		{
			this._orders.Assign(value);
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
	
	private void attach_orders(order entity)
	{
		this.SendPropertyChanging();
		entity.user = this;
	}
	
	private void detach_orders(order entity)
	{
		this.SendPropertyChanging();
		entity.user = null;
	}
}
#pragma warning restore 1591