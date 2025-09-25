using System.Collections.Generic;

namespace ChatBotProjeto.Controllers
{
    public class BotManager
    {
        private List<IChatController> controllers;

        public BotManager()
        {
            controllers = new List<IChatController>
            {
                new SaudacoesController(),
                new AjudaController(),
                new DesconhecidoController()
            };
        }

        public string ProcessarMensagem(string texto)
        {
            foreach (var controller in controllers)
            {
                var resposta = controller.Responder(texto.ToLower());
                if (resposta != null)
                    return resposta;
            }

            return "Erro: nenhum controller conseguiu responder.";
        }
    }
}
