using BridgeDP.Platforms;

namespace BridgeDP.Transmissions
{
    public class Live : ITransmission
    {
        protected IPlatform Platform { get; set; }
        public Live(IPlatform platform)
        {
            Platform = platform;
        }
        public void BroadCasting()
        {
            Console.WriteLine($"Iniciando a transmissão na plataforma: {Platform.GetName()}");
        }

        public void Result()
        {
            Console.WriteLine("**** ON AIR ****");
        }
    }
}
