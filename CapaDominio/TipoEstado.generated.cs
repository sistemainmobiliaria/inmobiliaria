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
	public partial class TipoEstado
	{
		private int idTipoEstado;
		public virtual int IdTipoEstado
		{
			get
			{
				return this.idTipoEstado;
			}
			set
			{
				this.idTipoEstado = value;
			}
		}
		
		private string tipoEstado1;
		public virtual string TipoEstado1
		{
			get
			{
				return this.tipoEstado1;
			}
			set
			{
				this.tipoEstado1 = value;
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
