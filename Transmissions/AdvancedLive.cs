using BridgeDP.Platforms;

namespace BridgeDP.Transmissions
{
    public class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform)
        {
        }
        public void SubTitle() 
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Comments() 
        {
            Console.WriteLine("Comentários liberados na live!");
        }

        public void Record() 
        {
            Console.WriteLine("Essa live será gravada. Você poderá acessar a qualquer momento.");
        }
    }
}
