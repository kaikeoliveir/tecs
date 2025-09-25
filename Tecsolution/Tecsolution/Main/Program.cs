using System;
//using System.Windows; // ← IMPORTANTE!
//using System.Windows.Controllers; // ← IMPORTANTE!
// Se precisar de mais funcionalidades, adicione:
//using System.Windows.Media;
//using System.Windows.Shapes;
using ChatBotProjeto.Models;
using ChatBotProjeto.Controllers;
//using System.Runtime.Remoting.Messaging;

class Program
{
    static void Main(string[] args)
    {
        BotManager bot = new BotManager();

        Console.WriteLine("🤖 Bem-vindo ao ChatBot! Digite 'sair' para encerrar.");

        while (true)
        {
            Console.Write("Você: ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
                break;

            Mensagem mensagem = new Mensagem
            {
                Usuario = "Usuário",
                Texto = entrada
            };

            string resposta = bot.ProcessarMensagem(mensagem.Texto);

            Console.WriteLine("Bot: " + resposta);
        }
    }
}