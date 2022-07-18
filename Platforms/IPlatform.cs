namespace BridgeDP.Platforms
{
    public interface IPlatform
    {
        void ConfigureRMTP();
        void AuthToken();
        string GetName();
    }
}
