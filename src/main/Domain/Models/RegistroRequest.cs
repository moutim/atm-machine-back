namespace Domain.Models;

public class RegistroRequest
{
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Senha { get; set; }
}