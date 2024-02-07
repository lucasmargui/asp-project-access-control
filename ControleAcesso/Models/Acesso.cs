
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControleAcesso.Models
{


	public class ACESSO
	{
		[Key]
		public int ID_LOGIN { get; set; }
		public string EMAIL { get; set; }
		public string SENHA { get; set; }
		public string ATIVO { get; set; }
		public string PERFIL { get; set; }
		public string NOME { get; set; }
		public string SOBRENOME { get; set; }
	}
}