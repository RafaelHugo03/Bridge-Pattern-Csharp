namespace BridgeDP.Platforms
{
    public class Facebook : IPlatform
    {
        public string Name { get; private set; }
        public Facebook()
        {
            Name = "Facebook";
            ConfigureRMTP();
            Console.WriteLine("Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando servidor RMTP");
        }

        string IPlatform.GetName()
        {
            return Name;
        }
    }
}
