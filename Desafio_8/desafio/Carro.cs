public class Carro : Veiculo
{
    public override void Acelerar()
    {
        velocidade = velocidade + 10;
        Console.WriteLine("Acelerando carro...");
    }
    public override void Frear()
    {
        velocidade = velocidade - 5;
        Console.WriteLine("Freando carro...");
    }
}
