namespace Patron_C_OF_R.Patron
{
    public class Level1Support : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Simple")
            {
                Console.WriteLine("Soporte Nivel 1: Solicitud atendida.");
            }
            else
            {
                Console.WriteLine("Soporte Nivel 1: Pasando al siguiente nivel.");
                NextHandler?.HandleRequest(request);
            }
        }
    }
}
