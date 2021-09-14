using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class FilmeRepositorio : IRepositoriof<Filme>
	{
        private List<Filme> listaFilme = new List<Filme>();
		public void AtualizaFilme(int id, Filme objeto)
		{
			listaFilme[id] = objeto;
		}

		public void ExcluiFilme(int id)
		{
			listaFilme[id].Excluir();
		}

		public void InsereFilme(Filme objeto)
		{
			listaFilme.Add(objeto);
		}

		public List<Filme> ListaFilme()
		{
			return listaFilme;
		}

		public int ProximoIdFilme()
		{
			return listaFilme.Count;
		}

		public Filme RetornaPorIdFilme(int id)
		{
			return listaFilme[id];
		}
	}
}