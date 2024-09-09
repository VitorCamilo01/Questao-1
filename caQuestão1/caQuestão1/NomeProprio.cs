using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão1
{
    internal class NomeProprio
    {
        private string nome_completo;
        private string nome_paper;

        public string Nome_completo { get => nome_completo; set => nome_completo = value; }
        public string Nome_paper { get => nome_paper; set => nome_paper = value; }

        public NomeProprio()
        {
            nome_completo = string.Empty;
            nome_paper = string.Empty;
        }
        public NomeProprio(string _nome_completo)
        {
            nome_completo = _nome_completo;
            nome_paper = nome_completo_para_nome_paper(nome_completo);
        }
        private string nome_completo_para_nome_paper(string _nome_completo)
        {
            var qnt_nomes = _nome_completo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var nome = qnt_nomes[0];
            var sobrenome = qnt_nomes[qnt_nomes.Length - 1];
            var nome_meio = qnt_nomes.Length > 2 ? qnt_nomes[1] : null;

            if(nome_meio != null)
            {
                string primeira_letra = nome_meio.Length > 1 ? nome_meio[0] + "." : nome_meio;
                return sobrenome + ", " + nome + " " + primeira_letra;
            }
            else
            {
                return sobrenome + ", " + nome;
            }
        }
        public void imprime_nome_paper ()
        {
            Console.WriteLine (nome_paper);
        }
    }
}