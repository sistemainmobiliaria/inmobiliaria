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
	public partial class Imagen
	{
		private int idImagen;
		public virtual int IdImagen
		{
			get
			{
				return this.idImagen;
			}
			set
			{
				this.idImagen = value;
			}
		}
		
		private int? inmueble;
		public virtual int? Inmueble
		{
			get
			{
				return this.inmueble;
			}
			set
			{
				this.inmueble = value;
			}
		}
		
		private string linkImagen;
		public virtual string LinkImagen
		{
			get
			{
				return this.linkImagen;
			}
			set
			{
				this.linkImagen = value;
			}
		}
		
		private Inmueble inmueble1;
		public virtual Inmueble Inmueble1
		{
			get
			{
				return this.inmueble1;
			}
			set
			{
				this.inmueble1 = value;
			}
		}
		
	}
}
#pragma warning restore 1591