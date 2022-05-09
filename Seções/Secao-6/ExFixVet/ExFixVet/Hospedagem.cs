
namespace ExFixVet
{
    class Hospedagem
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Hospedagem(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
