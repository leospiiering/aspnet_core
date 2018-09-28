using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace aspnet_core___Copia.Models
{
    public class ChamadoRepository : IChamadoRepository
    {
        private DataContext context;
        public ChamadoRepository(DataContext context) {
            this.context = context;
        }

        public Chamado GetById(int id) {
            return context.Chamado.SingleOrDefault(x => x.id == id);
        }

        public List<Chamado> GetAll() {
            return context.Chamado.ToList();
        }

        public void Delete(int id)
        {

            context.Chamado.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Chamado chamado)
        {
            context.Entry(chamado).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Create(Chamado chamado)
        {
            throw new System.NotImplementedException();
        }
    }
}
