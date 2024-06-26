public class Moto : Veiculo
{
    public override void Acelerar()
    {
        velocidade = velocidade + 15;
        Console.WriteLine("Acelerando moto...");
    }
    public override void Frear()
    {
        velocidade = velocidade - 10;
        Console.WriteLine("Freando moto...");
    }
}
