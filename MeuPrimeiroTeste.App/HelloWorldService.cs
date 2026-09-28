public class HelloWorldService
{
    public string GerarSaudacao(string? nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            return "Olá, Mundo!";
        }
        return $"Olá, {nome}!";
    }
}