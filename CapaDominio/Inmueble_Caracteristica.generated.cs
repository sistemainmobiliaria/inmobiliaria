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
	public partial class Inmueble_Caracteristica
	{
		private int idInmueble_Caracteristica;
		public virtual int IdInmueble_Caracteristica
		{
			get
			{
				return this.idInmueble_Caracteristica;
			}
			set
			{
				this.idInmueble_Caracteristica = value;
			}
		}
		
		private int? idInmueble;
		public virtual int? IdInmueble
		{
			get
			{
				return this.idInmueble;
			}
			set
			{
				this.idInmueble = value;
			}
		}
		
		private int? idTipoCaracteristica;
		public virtual int? IdTipoCaracteristica
		{
			get
			{
				return this.idTipoCaracteristica;
			}
			set
			{
				this.idTipoCaracteristica = value;
			}
		}
		
		private decimal? valorMedida;
		public virtual decimal? ValorMedida
		{
			get
			{
				return this.valorMedida;
			}
			set
			{
				this.valorMedida = value;
			}
		}
		
		private Inmueble inmueble;
		public virtual Inmueble Inmueble
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
		
		private TipoCaracteristica tipoCaracteristica;
		public virtual TipoCaracteristica TipoCaracteristica
		{
			get
			{
				return this.tipoCaracteristica;
			}
			set
			{
				this.tipoCaracteristica = value;
			}
		}
		
	}
}
#pragma warning restore 1591