using System;
using System.ComponentModel.DataAnnotations;

namespace aspnet_core___Copia.Models
{
    public class Chamado
    {
        public Chamado(){
            
        }
        public Chamado(int id, string situacao, DateTime horaIncio,DateTime horaFim, string descProblema)
        {
            this.id = id;
            this.descProblema = descProblema;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
        }
        public int id { get; set; }
        public string situacao { get; set; }
        public string descProblema { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFim { get; set; } 

        public Cliente cliente {get; set;}  
    }    
}