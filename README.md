# Agendamento Odonto

Sistema de agendamento de consultas para clínica odontológica, feito em C# como aplicação de console. Pensado para o uso de um atendente da clínica.

## Funcionalidades

- Cadastrar paciente (nome, CPF, data de nascimento e telefone)
- Consultar paciente cadastrado
- Alterar nome e CPF do paciente
- Agendar consulta: busca o paciente pelo CPF, escolhe o especialista e informa data e hora
- Listar todos os pacientes cadastrados

## Especialistas disponíveis

| Nome   | Especialidade |
|--------|---------------|
| Cleber | Ortodontia    |
| Joao   | Cirurgia      |

## Como rodar

1. Instale o [.NET SDK](https://dotnet.microsoft.com/download)
2. Baixe o projeto: botão verde **Code** → **Download ZIP**, e extraia
3. Abra o terminal na pasta do projeto e rode:

````
dotnet run
````

Também é possível abrir o arquivo `OdontoClinica.csproj` no Visual Studio e executar.

## Regras de validação

- Nome não pode ser vazio
- CPF deve ter 11 dígitos
- Telefone deve ter 10 ou 11 dígitos
- Data de nascimento não pode estar no futuro
- Data da consulta deve estar no futuro, no formato `dd/MM/aaaa HH:mm`

## Estrutura

- `Program.cs`: menu principal e fluxo do sistema
- `Pessoa.cs`: classe base com validações
- `Paciente.cs` e `Especialista.cs`: herdam de `Pessoa`
- `Agenda.cs`: modelo de agendamento

## Em desenvolvimento

- Tratamento de erros com try/catch nas entradas do usuário
- Salvar os agendamentos (hoje a consulta é só exibida na tela)
````
````

Se preferir, posso gerar o README como arquivo para você baixar.
