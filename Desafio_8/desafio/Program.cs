﻿List<Veiculo> veiculos = new List<Veiculo>();

Carro c1 = new Carro();
c1.velocidade = 100;

Moto m1 = new Moto();
m1.velocidade = 80;

veiculos.Add(c1);
veiculos.Add(m1);

foreach(var veiculo in veiculos)
{
    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Frear();
    veiculo.ExibirVelocidade();
    

}
