
namespace Relictify.Backend.Constants;

public static class GlobalConstants
{
    public static string Env { get; }
    public static string ApiUrl { get; }

    static GlobalConstants()
    {
        Env = Environment.GetEnvironmentVariable("ENVIRONMENT") ?? "dev";
        ApiUrl = Env == "dev" ? "https://localhost:8080" : "https://relictify.com/api/v1/";
    }
}