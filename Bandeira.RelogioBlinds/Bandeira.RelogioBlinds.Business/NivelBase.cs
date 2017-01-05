using System;
using System.Threading;

namespace Bandeira.RelogioBlinds.Business
{
    public abstract class NivelBase
    {
        public int Numero
        { get; set; }

        public TimeSpan Tempo
        { get; private set; }

        private TimeSpan TempoOriginal
        { get; set; }

        public string Mensagem
        { get; set; }

        public bool AtBeginning
        {
            get
            { 
                if (TempoOriginal.Subtract(Tempo).TotalSeconds <= 2)
                {
                    return true;
                }

                return false;
            }
        }

        public bool AtEnd
        {
            get
            {
                if (Tempo.TotalSeconds <= 10)
                {
                    return true;
                }

                return false;
            }           
        }

        public NivelBase(int numero, TimeSpan tempo)
            :this(numero, tempo, "")
        {
        }

        public NivelBase(int numero, TimeSpan tempo, string mensagem)
        {
            this.Numero = numero;
            this.Tempo = tempo;
            this.TempoOriginal = tempo;
            this.Mensagem = mensagem;
        }

        public NivelBase(int numero, int minutos)
           : this(numero, minutos, "")
        {
        }

        public NivelBase(int numero, int minutos, string mensagem)
        {
            this.Numero = numero;
            this.Tempo = new TimeSpan(0, minutos, 0);
            this.TempoOriginal = new TimeSpan(0, minutos, 0);
            this.Mensagem = mensagem;
        }

        public void Tick()
        {
            Tempo = Tempo.Subtract(new TimeSpan(0, 0, 1));

            Thread.Sleep(1000);
        }

        public string GetStringTempo()
        {
            return Tempo.ToString(@"mm\:ss");
        }

        public void Reset()
        {
            Tempo = TempoOriginal;
        }
    }
}
