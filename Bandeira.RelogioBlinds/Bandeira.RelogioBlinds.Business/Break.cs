using System;

namespace Bandeira.RelogioBlinds.Business
{
    public class Break : NivelBase
    {
        public Break(int numero, TimeSpan tempo, string mensagem)
            : base(numero, tempo, mensagem)
        {
        }

        public Break(int numero, int minutos, string mensagem)
            : base(numero, minutos, mensagem)
        {
        }

        public override string ToString()
        {
            return string.Format("Nivel {0} - {1}", this.Numero, this.Mensagem);
        }
    }
}
