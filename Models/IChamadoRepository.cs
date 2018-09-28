using System.Collections.Generic;
namespace aspnet_core___Copia.Models
{
    public interface IChamadoRepository
    {        
        Chamado GetById(int id);
        void Create(Chamado chamado);

        void Delete(int id);

        List<Chamado>GetAll();

        void Update(Chamado chamado);
    }
}