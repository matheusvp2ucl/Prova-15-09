class Importados : Carro {

  public Importados( string cor, string marca, string modelo, double anoFrabricacao ) : base( cor, marca, modelo, anoFrabricacao ){
    
  }

  public override void definirValorVeiculo(double custoFixo){
    this.valor = custoFixo * 3.0 + 0.6 * custoFixo + custoFixo / 5;
  }

}