namespace Hystrix.Dotnet
{
    public interface IConfigurationProvider
    {
         string GetSetting(string configKey);
    }
}