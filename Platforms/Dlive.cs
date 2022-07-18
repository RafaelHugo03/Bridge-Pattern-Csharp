namespace BridgeDP.Platforms
{
    public class Dlive : IPlatform
    {
        public string Name { get; private set; }

        public Dlive()
        {
            Name = "Dlive";
            ConfigureRMTP();
            Console.WriteLine("Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("Dlive: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Dlive: Configurando servidor RMTP");
        }

        string IPlatform.GetName()
        {
            return Name;
        }
    }
}
