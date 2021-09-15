class Nacionais : Carro {

  public Nacionais( string cor, string marca, string modelo, double anoFrabricacao ) : base( cor, marca, modelo, anoFrabricacao ){
    
  }

  public override void definirValorVeiculo(double custoFixo){
    this.valor = custoFixo * 1.5 + 0.2 * custoFixo + custoFixo / 10;
  }

}