class Pessoa
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Fone { get; set; }
    public string? Email { get; set; }

    public string GetPessoa(){
        return $"Pessoa:{Id},{Nome},{Fone},{Email}";
    }
}