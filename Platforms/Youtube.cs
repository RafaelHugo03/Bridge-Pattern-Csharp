namespace BridgeDP.Platforms
{
    public class Youtube : IPlatform
    {
        public string Name { get; private set; }
        public Youtube()
        {
            Name = "Youtube";
            ConfigureRMTP();
            Console.WriteLine("Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP");
        }
        string IPlatform.GetName()
        {
            return Name;
        }
    }
}
