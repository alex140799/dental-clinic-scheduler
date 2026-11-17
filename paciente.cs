namespace SistemaOdontologico
{
    public class Paciente : Pessoa
    {
        public Paciente(string nome, string cpf, DateTime data_nascimento, string telefone)
            : base(nome, cpf, data_nascimento, telefone) { }
        public override void ExibirDados()


        {
            Console.WriteLine($"Nome do paciente: {Nome} \nCPF: {CPF}\nData de Nascimento:{Data_nascimento.ToString("dd/MM/yyyy")} \nTelefone:{Telefone}");
        }
    }
}
