using System;

namespace Bandeira.RelogioBlinds.Business
{
    public class Break : NivelBase
    {
        public string Mensagem
        { get; set; }

        public Break(int numero, TimeSpan tempo, string mensagem)
            : base(numero, tempo)
        {
            this.Mensagem = mensagem;
        }

        public Break(int numero, int minutos, string mensagem)
            : base(numero, minutos)
        {
            this.Mensagem = mensagem;
        }

        public override string ToString()
        {
            return string.Format("Nivel {0} - {1}", this.Numero, this.Mensagem);
        }
    }
}
