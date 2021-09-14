using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositoriof<F>
    {
        List<F> ListaFilme();
        F RetornaPorIdFilme(int id);        
        void InsereFilme(F entidade);        
        void ExcluiFilme(int id);        
        void AtualizaFilme(int id, F entidade);
        int ProximoIdFilme();
    }
}