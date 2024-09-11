using System.ComponentModel.DataAnnotations;

namespace FEAasp.Models
{
    public class RecSenha
    {
        public int Id_Senha { get; set; }
        public string EmailRec { get; set; }
        public string SenhaRec { get; set; }
        public string TokenRecuperacao { get; set; }
        public datetime DataToken { get; set; }
    }
}
