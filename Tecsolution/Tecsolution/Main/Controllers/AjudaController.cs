namespace ChatBotProjeto.Controllers
{
    public class AjudaController : IChatController
    {
        public string Responder(string texto)
        {
            if (texto.Contains("ajuda"))
            {
                return "Estou aqui para ajudar! Pode explicar melhor?";
            }

            return null;
        }
    }
}
