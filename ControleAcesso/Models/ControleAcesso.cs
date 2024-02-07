using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace ControleAcesso.Models
{
	public class DEVMEDIAEntities : DbContext
	{
		public DEVMEDIAEntities() : base("DEVMEDIAEntities")
		{

		}

		public DbSet<ACESSO> ACESSOes { get; set; }
	}
}




