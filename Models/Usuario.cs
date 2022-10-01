namespace SistemaBanco.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        private string Cpf { get; }
        private string Rg { get; }

        public Usuario (string cpf, string rg)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Console.WriteLine("Nome com campo nulo ou vázio.");
            }

            Cpf = cpf;
            Rg = rg;
        }
    }
}