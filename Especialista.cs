namespace SistemaOdontologico
{
    public class Especialista : Pessoa
    {
        private string especialidade;

        public Especialista(string nome, string cpf, DateTime data_nascimento, string telefone, string especialidade) : base(nome, cpf, data_nascimento, telefone)
        {
            Especialidade = especialidade;
        }
        public string Especialidade
        {
            get
            {
                return especialidade;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    especialidade = value;
                }
                else
                {
                    throw new ArgumentException("A especialidade não pode ser vazia ou ter espaços!");
                }


            }

        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Nome : {Nome}\nEspecialidade: {Especialidade}\n");
        }
    }
}
