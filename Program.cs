// See https://aka.ms/new-console-template for more information
using BridgeDP.Platforms;
using BridgeDP.Transmissions;

StartLive(new Dlive());

void StartLive(IPlatform platform) 
{
    Console.WriteLine("Aguarde...");

    var live = new AdvancedLive(platform);

    live.BroadCasting();
    live.SubTitle();
    live.Comments();
    live.Record();
    live.Result();
}
