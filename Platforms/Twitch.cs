using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP.Platforms
{
    public class Twitch : IPlatform
    {
        public string Name { get; private set; }
        public Twitch()
        {
            Name = "Twitch";
            ConfigureRMTP();
            Console.WriteLine("Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("Twitch: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Twitch: Configurando servidor RMTP");
        }
        string IPlatform.GetName()
        {
            return Name;
        }
    }
}
