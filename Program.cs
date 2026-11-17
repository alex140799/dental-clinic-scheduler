using SistemaOdontologico;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace ClinicaOdonto
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            int opcao;
            Paciente pacienteCadastrado = null;
            List<Paciente> pacientes = new List<Paciente>();
            List<Especialista> especialistas = new List<Especialista>();
            especialistas.Add(new Especialista("Cleber", "03216549871", new DateTime(2005, 05, 08), "54996297222", "Ortodontia"));
            especialistas.Add(new Especialista("Joao", "00668616083", new DateTime(1983, 08, 29), "54996297222", "Cirurgia"));


            do
            {

                Console.WriteLine(" ***********MENU PRINCIPAL*********\n");

                Console.WriteLine("1-Cadastrar Paciente:\n");
                Console.WriteLine("2-Consultar Paciente\n");
                Console.WriteLine("3-Alterar dados do Paciente\n ");
                Console.WriteLine("4- Agendar:\n ");
                Console.WriteLine("5- Lista de Pacientes\n\n");

                Console.WriteLine("6- Sair");

                Console.WriteLine("Selecione uma opção:");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("=== CADASTRAR PACIENTE ====");
                            Console.Write("Digite o nome do Paciente:");
                            string nome = Console.ReadLine();

                            Console.Write("Digite o CPF do Paciente:");
                            string cpf = Console.ReadLine();

                            Console.Write("Digite a data de nascimento do Paciente: ");
                            DateTime data_nascimento = DateTime.Parse(Console.ReadLine());

                            Console.Write("Digite o telefone do cliente: ");
                            string telefone = Console.ReadLine();



                            pacienteCadastrado = new Paciente(nome, cpf, data_nascimento, telefone);
                            pacientes.Add(pacienteCadastrado);

                            Console.WriteLine("Paciente cadastrado com Sucesso!");

                            pacienteCadastrado.ExibirDados();

                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("=== CONSULTAR PACIENTE===");
                            if (pacienteCadastrado != null)
                            {
                                Console.WriteLine("Paciente encontrado!");

                                pacienteCadastrado.ExibirDados();
                            }
                            else
                            {
                                Console.WriteLine("Nenhum paciente Cadastrado!");
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("=== ALTERAR DADOS DO PACIENTE ===");
                            if (pacienteCadastrado != null)
                            {
                                Console.WriteLine("Digite o novo nome:");
                                string novoNome = Console.ReadLine();

                                Console.WriteLine("Digite o novo CPF: ");
                                string novoCpf = Console.ReadLine();

                                pacienteCadastrado.Nome = novoNome;
                                pacienteCadastrado.CPF = novoCpf;

                                Console.WriteLine("Dados alterados com sucesso");

                                pacienteCadastrado.ExibirDados();
                            }
                            else
                            {
                                Console.WriteLine("Nenhum paciente cadastrado!");
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Digite o CPF do paciente que irá agendar:");
                            string cpf_digitado = Console.ReadLine();

                            Paciente pacienteEncontrado = null;
                            foreach (Paciente paciente in pacientes)
                            {
                                if (paciente.CPF == cpf_digitado)
                                {
                                    pacienteEncontrado = paciente;
                                }
                            }

                            if (pacienteEncontrado == null)
                            {
                                Console.WriteLine("CPF não encontrado!");
                                break;
                            }

                            Console.WriteLine("Paciente encontrado:");
                            pacienteEncontrado.ExibirDados();

                            Console.WriteLine("******* LISTA DE ESPECIALISTAS ********");
                            foreach (Especialista especialistaExibido in especialistas)
                            {
                                especialistaExibido.ExibirDados();
                            }

                            Console.WriteLine("Digite o nome do especialista:");
                            string especialista_digitado = Console.ReadLine();

                            Especialista especialistaEscolhido = null;
                            foreach (Especialista especialista in especialistas)
                            {
                                if (string.Equals(especialista.Nome, especialista_digitado, StringComparison.OrdinalIgnoreCase))
                                {
                                    especialistaEscolhido = especialista;
                                }
                            }

                            if (especialistaEscolhido == null)
                            {
                                Console.WriteLine("Especialista não encontrado!");
                                break;
                            }

                            Console.WriteLine($"Especialista selecionado: {especialistaEscolhido.Nome}");

                            Console.WriteLine("Digite a data e hora do atendimento (dd/MM/aaaa HH:mm):");
                            string dataHoraDigitada = Console.ReadLine();

                            if (!DateTime.TryParseExact(dataHoraDigitada, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataHora))
                            {
                                Console.WriteLine("Formato inválido! Use dd/MM/aaaa HH:mm");
                                break;
                            }

                            if (dataHora <= DateTime.Now)
                            {
                                Console.WriteLine("A data e o horário devem ser no futuro!");
                                break;
                            }

                            Console.WriteLine($"Consulta agendada: {pacienteEncontrado.Nome} com {especialistaEscolhido.Nome} em {dataHora:dd/MM/yyyy HH:mm}");
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("=== LISTA DE PACIENTES ===");
                            if (pacientes.Count > 0)
                            {
                                foreach (Paciente paciente in pacientes)
                                {
                                    paciente.ExibirDados();
                                    Console.WriteLine("------------------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nenhum paciente cadastrado!");
                            }
                            break;
                        }


                }

            } while (opcao != 6);
        }
    }
}
