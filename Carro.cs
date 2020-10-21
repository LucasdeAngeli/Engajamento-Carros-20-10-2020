class Carro {
  string marca;
  double consumo_litro;

  public string getMarca(){
    return marca;
  }
  
  public double getConsumo(){
    return consumo_litro;
  }

  public Carro (string m, double c){
    marca = m;
    consumo_litro = c;
  }
}