using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public abstract class Pessoa
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        #endregion Propriedades

        #region Métodos

        public override string ToString()
        {
            return "Id: " + this.Id + "\nNome: " + this.Nome
                + "\nTelefone: " + this.Telefone;
        }
        #endregion Métodos
    }
}
