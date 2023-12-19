namespace Relictify.Backend.Constants;

public static class GlobalConstants
{
    public static string Env { get; }

    static GlobalConstants()
    {
        Env = Environment.GetEnvironmentVariable("ENVIRONMENT") ?? "dev";
    }
}