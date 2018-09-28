namespace aspnet_core___Copia.Models
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public Cliente(int id,string nome, string email, string phone)
        {
            this.id=id;
            this.nome=nome;
            this.email=email;
            this.phone=phone;
        }
        public int id{get;set;}
        public string nome{get;set;}
        public string email{get;set;}
        public string phone{get;set;}
    }
}