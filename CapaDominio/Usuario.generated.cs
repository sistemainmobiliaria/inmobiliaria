#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using CapaDominio;

namespace CapaDominio	
{
	public partial class Usuario
	{
		private int idUsuario;
		public virtual int IdUsuario
		{
			get
			{
				return this.idUsuario;
			}
			set
			{
				this.idUsuario = value;
			}
		}
		
		private string nombreUsuario;
		public virtual string NombreUsuario
		{
			get
			{
				return this.nombreUsuario;
			}
			set
			{
				this.nombreUsuario = value;
			}
		}
		
		private string password;
		public virtual string Password
		{
			get
			{
				return this.password;
			}
			set
			{
				this.password = value;
			}
		}
		
		private string nombre;
		public virtual string Nombre
		{
			get
			{
				return this.nombre;
			}
			set
			{
				this.nombre = value;
			}
		}
		
		private string apellido;
		public virtual string Apellido
		{
			get
			{
				return this.apellido;
			}
			set
			{
				this.apellido = value;
			}
		}
		
		private int? rol;
		public virtual int? Rol
		{
			get
			{
				return this.rol;
			}
			set
			{
				this.rol = value;
			}
		}
		
		private Rol rol1;
		public virtual Rol Rol1
		{
			get
			{
				return this.rol1;
			}
			set
			{
				this.rol1 = value;
			}
		}
		
		private IList<Inmueble> inmuebles = new List<Inmueble>();
		public virtual IList<Inmueble> Inmuebles
		{
			get
			{
				return this.inmuebles;
			}
		}
		
	}
}
#pragma warning restore 1591