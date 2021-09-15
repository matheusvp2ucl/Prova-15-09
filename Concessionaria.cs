using System.Collections.Generic;

class Concessionaria {
  private string localizacao;
  private string gerentePrincipal;
  private double anoFundacao;
  private List<Carro> carrosDisponiveis;

  public List<Carro> getCarrosDisponiveis(){
    return this.carrosDisponiveis;
  }

  public void setCarrosDisponiveis( List<Carro> carros ){
    this.carrosDisponiveis = carros;
  }

  public double getAnoFundacao(){
    return this.anoFundacao;
  }

  public void setAnoFundacao( double ano ){
    this.anoFundacao = ano;
  }

  public string getGerentePrincipal(){
    return this.gerentePrincipal;
  }

  public void setGerentePrincipal( string gerente ){
    this.gerentePrincipal = gerente;
  }

  public string getLocalizacao(){
    return this.gerentePrincipal;
  }

  public void setLocalizacao( string localiza ){
    this.gerentePrincipal = localiza;
  }

  public Concessionaria(string localizacao, string gerentePrincipal, double anoFundacao){
    this.localizacao = localizacao;
    this.gerentePrincipal = gerentePrincipal;
    this.anoFundacao = anoFundacao;
    this.carrosDisponiveis = new List<Carro>();
  }
  
  public void adicionarCarro(Carro car){
    this.carrosDisponiveis.Add(car);
  }

  public double CalcularPortifolio(){
    double soma = 0;
    for (int i = 0; i < this.carrosDisponiveis.Count; i++){
      soma += this.carrosDisponiveis[i].valor;
    }
    return soma;
  }

}