namespace Bandeira.RelogioBlinds.Business
{
    public class Ficha
    {
        public int Valor
        { get; set; }

        public string Cor
        { get; set; }

        public string NumeroCor
        { get; set; }

        public Ficha(int valor, string cor, string numeroCor)
        {
            this.Valor = valor;
            this.Cor = cor;
            this.NumeroCor = numeroCor;
        }
    }
}
