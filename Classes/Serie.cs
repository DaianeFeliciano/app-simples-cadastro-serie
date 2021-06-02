using DIO.SERIES.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.SERIES
{
   public class Serie : EntidadeBase // classe serie herda do entidade base
    {   //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //Metodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
     {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;  // metodo de construtor id ta na classe entidadebase
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false; // toma cuidado com exclusão que vc vai excluir de vez a informação


                
     }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio" + this.Ano;
            retorno += "Excluido" + this.Excluido;
            return retorno; // retornar essas informações 

        }

        // encapsulamento

        public string retornaTitulo()
        {
            return this.Titulo; // retorna do objeto titulo para não ficar alterando
        }

        internal int retornaId()
        {
            return this.Id;
        }

        internal bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir() {

            this.Excluido = true;
        }
    }
}
