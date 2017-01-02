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

        public Nivel(int numero, TimeSpan tempo, int anti, int smallBlind, int bigBlind, byte[] imagemSmallBlind = null, byte[] imagemBigBlind = null)
            : base(numero, tempo)
        {
            this.Anti = anti;
            this.SmallBlind = smallBlind;
            this.BigBlind = bigBlind;
            this.ImagemSmallBlind = imagemSmallBlind;
            this.ImagemBigBlind = imagemBigBlind;
        }

        public Nivel(int numero, int minutos, int anti, int smallBlind, int bigBlind, byte[] imagemSmallBlind = null, byte[] imagemBigBlind = null)
            : base(numero, minutos)
        {
            this.Anti = anti;
            this.SmallBlind = smallBlind;
            this.BigBlind = bigBlind;
            this.ImagemSmallBlind = imagemSmallBlind;
            this.ImagemBigBlind = imagemBigBlind;
        }

        public override string ToString()
        {
            return string.Format("Nivel {0} - SB: {1} - BB: {2} - Anti: {3}", this.Numero, this.SmallBlind, this.BigBlind, this.Anti);
        }
    }
}
