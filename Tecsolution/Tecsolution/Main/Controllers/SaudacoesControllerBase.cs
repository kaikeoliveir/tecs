using System;
using System.Collections.Generic;

namespace ChatBotProjeto.Controllers
{
    public class SaudacoesController : IChatController
    {
        public string Responder(string texto)
        {
            if (texto.Contains("oi") || texto.Contains("olá"))
            {
                var respostas = new List<string>
                {
                    "Oi, tudo bem?",
                    "Olá! Como posso ajudar?",
                    "E aí, beleza?"
                };

                Random rnd = new Random();
                return respostas[rnd.Next(respostas.Count)];
            }

            return null;
        }
    }
}
