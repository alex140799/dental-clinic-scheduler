namespace SistemaOdontologico
{
    public class Agenda : Pessoa
    {
        private string nome_paciente;
        private string nome_especialista;
        private DateTime data_hora;
        private string status;

        public Agenda(string nome, string cpf, DateTime data_nascimento, string telefone, string nome_paciente, string nome_especialista, DateTime data_hora, string status) : base(nome, cpf, data_nascimento, telefone)
        {


            NomePaciente = nome_paciente;
            NomeEspecialista = nome_especialista;
            DataHora = data_hora;
            Status = status;
        }
        public string NomePaciente
        {
            get
            {
                return nome_paciente;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nome_paciente = value;
                }
                else
                {
                    throw new ArgumentException("O nome do paciente não pode estar vazio ou ter espaços em branco!");
                }
            }

        }
        public string NomeEspecialista
        {
            get
            {
                return nome_especialista;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nome_especialista = value;
                }
                else
                {
                    throw new ArgumentException("O nome do especialista não pode estar vazio ou ter espaços em branco!");
                }

            }

        }
        public DateTime DataHora
        {
            get
            {
                return data_hora;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    data_hora = value;
                }
                else
                {
                    throw new ArgumentException("A data e o horário da consulta devem ser  no mínimo 24 horas antes!");
                }
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                if (value == "Agendada" || value == "Cancelada" || value == "Concluída")
                {
                    status = value;
                }
                else
                {
                    throw new ArgumentException("Status inválido! Use Agendada, Cancelada ou Concluída!");
                }
            }
        }
        public override void ExibirDados()
        {
            Console.WriteLine("Nome do Paciente: {NomePaciente}\n");
        }

    }
}
