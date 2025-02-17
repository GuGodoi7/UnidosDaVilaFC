﻿

namespace UnidosDaVilaFC.Models
{
    public class Jogador : Funcionario
    {
        public Jogador(int id, string nome, DateTime dataNascimento, double salario, string nacionalidade, string posicao, string especialidade, string status) : base(nome, dataNascimento, salario, nacionalidade)
        {
            Id = id;
            Posicao = posicao ?? throw new ArgumentNullException(nameof(posicao));
            Especialidade = especialidade ?? throw new ArgumentNullException(nameof(especialidade));
            Status = status ?? throw new ArgumentNullException(nameof(status));
        }

        public int Id { get; set; }
        public string Posicao { get; set; }
        public string Especialidade { get; set; }
        public string Status { get; set; }

 

        public string GetPosicao()
        {
            return Posicao;
        }

        public string GetEspecialidade()
        {
            return Especialidade;
        }

        internal string TipoTreino()
        {
            switch (Especialidade.ToLower())
            {
                case "ataque":
                        return  "O jogador " + GetNome() + "está realizando treino de Finalização.";
                    break;
                case "defesa":
                        return "O jogador " + GetNome() + "está realizando treino de defesa.";
                    break;
                case "meio-campo":
                        return "O jogador " + GetNome() + "está realizando treino de Passe.";
                    break;
                default:
                        return "O jogador " + GetNome() + " está realizando treino específico para sua especialidade.";
                    break;
            }
        }

        public override string Logar()
        {
            Console.WriteLine($"O Jogador {GetNome()} fez login no sistema.");
            return "Login - Jogador: " + GetNome();
        }

    }
}
