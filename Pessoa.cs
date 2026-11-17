

namespace SistemaOdontologico
{
    public class Pessoa
    {
        private string nome;
        private string cpf;
        private DateTime data_nascimento;
        private string telefone;

        public Pessoa(string nome, string cpf, DateTime data_nascimento, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Data_nascimento = data_nascimento;
            Telefone = telefone;
        }
        public string Nome
        {
            get
            { return nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nome = value;
                }
                else
                {
                    throw new ArgumentException("O nome não pode ser vazio ou ter espaços!");
                }

            }
        }
        public string CPF
        {
            get
            { return cpf; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 11)
                {
                    cpf = value;
                }
                else
                {
                    throw new ArgumentException(" O CPF deve ter 11 dígitos!");
                }
            }
        }
        public DateTime Data_nascimento
        {
            get
            {
                return data_nascimento;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    data_nascimento = value;
                }
                else
                {
                    throw new ArgumentException(" A data de nascimento não pode ser no futuro!");
                }
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && (value.Length == 10 || value.Length == 11))
                {
                    telefone = value;
                }
                else
                {
                    throw new ArgumentException("Não pode ser vazio e com menos de 10 ou 11 dígitos!");
                }
            }

        }
        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} ");
        }
    }
}