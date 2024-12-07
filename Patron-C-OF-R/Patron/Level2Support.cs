namespace Patron_C_OF_R.Patron
{
    public class Level2Support : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Intermediate")
            {
                Console.WriteLine("Soporte Nivel 2: Solicitud atendida.");
            }
            else
            {
                Console.WriteLine("Soporte Nivel 2: Pasando al siguiente nivel.");
                NextHandler?.HandleRequest(request);
            }
        }
    }
}
