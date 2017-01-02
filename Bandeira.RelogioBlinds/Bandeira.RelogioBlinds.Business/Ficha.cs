namespace Bandeira.RelogioBlinds.Business
{
    internal class Ficha
    {
        public int Valor
        { get; set; }

        public string Cor
        { get; set; }

        public Ficha(int valor, string cor)
        {
            this.Valor = valor;
            this.Cor = cor;
        }
    }
}
