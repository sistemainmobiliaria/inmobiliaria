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
	public partial class Rol_Permiso
	{
		private int idRol_Permiso;
		public virtual int IdRol_Permiso
		{
			get
			{
				return this.idRol_Permiso;
			}
			set
			{
				this.idRol_Permiso = value;
			}
		}
		
		private int? idRol;
		public virtual int? IdRol
		{
			get
			{
				return this.idRol;
			}
			set
			{
				this.idRol = value;
			}
		}
		
		private int? idPermiso;
		public virtual int? IdPermiso
		{
			get
			{
				return this.idPermiso;
			}
			set
			{
				this.idPermiso = value;
			}
		}
		
		private Permiso permiso;
		public virtual Permiso Permiso
		{
			get
			{
				return this.permiso;
			}
			set
			{
				this.permiso = value;
			}
		}
		
		private Rol rol;
		public virtual Rol Rol
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
		
	}
}
#pragma warning restore 1591