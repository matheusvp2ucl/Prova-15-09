class Carro {

  public string cor {get; protected set;}
  public string marca {get; protected set;}
  public string modelo {get; protected set;}
  public double valor {get; protected set;}
  public double anoFrabricacao {get; protected set;} 
  public double combustivel {get; protected set;}

  public Carro( string cor, string marca, string modelo, double anoFrabricacao ){
    this.cor = cor;
    this.marca = marca;
    this.modelo = modelo;
    this.anoFrabricacao = anoFrabricacao;
  }

  public virtual void definirValorVeiculo(double custoFixo){
  }

  public void encherTanque(){
    this.combustivel = 100;
  }

  public void encherTanque(double quantidade){
    this.combustivel = quantidade;
  }

}