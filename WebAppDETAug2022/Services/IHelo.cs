using WebAppDETAug2022.Services;

namespace WebAppDETAug2022.Services
{
    public interface IHelo
    {
        string SayHelo (string name );
    }
public class Helo1: IHelo
{
    public string SayHelo (string name)
        {
            return $"Helo{name},Welcome to Asp.Net Core";
        }
}
    public class Helo2 : IHelo
    {
        public string SayHelo(string name)
        {
            return $"Hai, Helo{name},Welcome to Asp.Net Core";
        }
    }
}
