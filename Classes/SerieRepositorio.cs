using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO.SERIES.Interfaces;

namespace DIO.SERIES.Classes
{
    class SerieRepositorio : IRepositorio<Serie> // reaprovetando interface

    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
            // poderia implementar email aqui
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);

        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
