using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    string continuar="s", marca;
    double consumo;

    Carro aut = new Carro("TESTE", 0);
    List<Carro> listaCarros = new List<Carro>();

    while (continuar="s"){
      Console.WriteLine("Tipo de Carro: ");
      marca = Console.ReadLine();
      Console.WriteLine("Km/l do Carro: ");
      consumo = double.Parse(Console.ReadLine());
      aut = new (marca, consumo);
      listaCarros.Add(aut);

      Console.WriteLine("Deseja continuar? S/N");
      continuar = Console.ReadLine();
    }

    Carro menor_consumo = listaCarros[0];

    for(int i=1; i<listaCarros.Count; i++){
      if(listaCarros[i].getConsumo() > menor_consumo.getConsumo()){
        menor_consumo = listaCarros[i];
      }
    }

    Console.WriteLine("Marca de menor consumo: {0}", menor_consumo.getMarca(), menor_consumo.getConsumo());

    for(int i=0; i<listaCarros.Count; i++){
      Console.WriteLine("Litros gastos em 1000km: {0}", 1000/listaCarros[i].getConsumo());
      Console.WriteLine("Valor gasto em 1000 km: {0}", (1000/listaCarros[i].getConsumo())*4,89);
    }
  }
}