namespace ChatBotProjeto.Controllers
{
    public class DesconhecidoController : IChatController
    {
        public string Responder(string texto)
        {
            return "Desculpe, não entendi. Pode repetir?";
        }
    }
}
