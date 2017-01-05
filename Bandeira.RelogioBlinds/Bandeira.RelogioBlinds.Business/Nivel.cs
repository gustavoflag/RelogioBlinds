using System;

namespace Bandeira.RelogioBlinds.Business
{
    public class Nivel : NivelBase
    {
        public int Anti
        { get; set; }

        public int SmallBlind
        { get; set; }

        public int BigBlind
        { get; set; }

        public byte[] ImagemSmallBlind
        { get; set; }

        public byte[] ImagemBigBlind
        { get; set; }

        public Nivel(int numero, TimeSpan tempo, int anti, int smallBlind, int bigBlind, string mensagem, byte[] imagemSmallBlind = null, byte[] imagemBigBlind = null)
            : base(numero, tempo, mensagem)
        {
            this.Anti = anti;
            this.SmallBlind = smallBlind;
            this.BigBlind = bigBlind;
            this.ImagemSmallBlind = imagemSmallBlind;
            this.ImagemBigBlind = imagemBigBlind;
        }

        public Nivel(int numero, int minutos, int anti, int smallBlind, int bigBlind, string mensagem, byte[] imagemSmallBlind = null, byte[] imagemBigBlind = null)
            : base(numero, minutos, mensagem)
        {
            this.Anti = anti;
            this.SmallBlind = smallBlind;
            this.BigBlind = bigBlind;
            this.ImagemSmallBlind = imagemSmallBlind;
            this.ImagemBigBlind = imagemBigBlind;
        }

        public override string ToString()
        {
            string blind = string.Format("{0} - {1}", this.SmallBlind, this.BigBlind);

            if (this.Anti > 0)
            {
                blind = string.Format("{0} Anti: {1}", blind, this.Anti);
            }

            return blind;
        }
    }
}
