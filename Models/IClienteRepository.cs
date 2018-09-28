using System.Collections.Generic;

namespace aspnet_core___Copia.Models
{
        public interface IClienteRepository
    {

        Cliente GetById(int id);

        void Create(Cliente cliente);

        void Delete(int id);

        void Update(Cliente cliente);
        
        List<Cliente>GetAll();

        
    }
}
