using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_FitCard_Helena_Azevedo
{
    class Estabelecimento
    {
        public int id { get; set; }

        public string nomeFantasia { get; set; }

        public string CNPJ { get; set; }

        public string Email { get; set; }

        public string Endereço { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Telefone { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Categoria { get; set; }

        public string statusEstabelecimento { get; set; }

        public string Agencia { get; set; }

        public string Conta { get; set; }

    }
}
