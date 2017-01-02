using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;

namespace Bandeira.RelogioBlinds.Business
{
    public class Relogio
    {
        private IList<NivelBase> Niveis;
        private IList<Ficha> Fichas;

        private int CurrentNivelIndex;

        private NivelBase CurrentNivel;

        private Thread ThreadClock;

        public Relogio()
        {
            Niveis = new List<NivelBase>();
            Fichas = new List<Ficha>();
            CurrentNivelIndex = 0;
            ThreadClock = new Thread(new ThreadStart(ThreadClockTick));
        }

        public Relogio(string pathConfig)
            : this()
        {
            GetConfig(pathConfig);
        }

        public void AddNivel(NivelBase nivel)
        {
            Niveis.Add(nivel);
        }

        public NivelBase GetCurrentNivel()
        {
            if (CurrentNivelIndex > Niveis.Count - 1)
                return null;

            return Niveis.ElementAt(CurrentNivelIndex);
        }

        private void GetConfig(string pathConfig)
        {
            XmlTextReader reader = new XmlTextReader(pathConfig);
            int i = 1;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "NiveisBlind"
                        || reader.Name == "Fichas"
                        || reader.Name == "Configuracao")
                        continue;

                    switch (reader.Name)
                    {
                        case "Nivel":
                            string sb = reader.GetAttribute("SB") ?? "0";
                            string bb = reader.GetAttribute("BB") ?? "0";
                            string anti = reader.GetAttribute("Anti") ?? "0";
                            string tempo = reader.GetAttribute("Tempo") ?? "0";

                            Niveis.Add(new Nivel(i++, int.Parse(tempo), int.Parse(anti), int.Parse(sb), int.Parse(bb)));
                            break;

                        case "Break":
                            string msg = reader.GetAttribute("Msg") ?? "";
                            string tempoBreak = reader.GetAttribute("Tempo") ?? "0";

                            Niveis.Add(new Break(i++, int.Parse(tempoBreak), msg));
                            break;

                        case "Ficha":
                            string valor = reader.GetAttribute("Valor") ?? "";
                            string cor = reader.GetAttribute("Cor") ?? "0";

                            Fichas.Add(new Ficha(int.Parse(valor), cor));
                            break;
                    }
                }
            }
        }

        private void ThreadClockTick()
        {
            while (CurrentNivel != null)
            {
                while (CurrentNivel != null && CurrentNivel.Tempo.Seconds >= 0)
                {
                    CurrentNivel.Tick();
                }

                NextNivel();
            }
        }

        public string GetCurrentNivelString()
        {
            if (CurrentNivel != null)
                return CurrentNivel.ToString();
            else
                return "";
        }

        public string GetCurrentTempo()
        {
            if (CurrentNivel != null)
                return CurrentNivel.GetStringTempo();
            else
                return "";
        }

        public void Start()
        {
            if (CurrentNivel == null)
            {
                CurrentNivel = GetCurrentNivel();
            }

            if (ThreadClock.IsAlive)
                ThreadClock.Resume();
            else
                ThreadClock.Start();
        }

        public void Stop()
        {
            ThreadClock.Suspend();
        }

        public void NextNivel()
        {
            if (CurrentNivelIndex < Niveis.Count)
            {
                CurrentNivelIndex++;
                CurrentNivel = GetCurrentNivel();
                ResetNivel();
            }
        }

        public void LastNivel()
        {
            if (CurrentNivel.AtBeginning)
            {
                if (CurrentNivelIndex > 0)
                {
                    CurrentNivelIndex--;
                    CurrentNivel = GetCurrentNivel();
                }
            }

            ResetNivel();
        }

        public void ResetNivel()
        {
            if (CurrentNivel != null)
                CurrentNivel.Reset();
        }

        private IList<Ficha> GetFichasByValor(int valor)
        {
            var fichasRetorno = new List<Ficha>();

            var fichasOrdenadas = Fichas.OrderByDescending(f => f.Valor);

            foreach (Ficha ficha in fichasOrdenadas)
            {
                if (ficha.Valor > valor
                        || (valor - ficha.Valor) < 0)
                    continue;

                while (valor > 0 && (valor - ficha.Valor) >= 0)
                {
                    valor -= ficha.Valor;
                    fichasRetorno.Add(ficha);

                    if (valor == 0)
                        break;
                }

                if (valor == 0)
                    break;
            }

            if (valor == 0)
                return fichasRetorno;

            return null;
        }

        private string GetStringFichas(int valor)
        {
            StringBuilder sb = new StringBuilder();

            if (CurrentNivel is Nivel)
            {
                var fichas = GetFichasByValor(valor);

                foreach (Ficha ficha in fichas)
                {
                    sb.Append(ficha.Cor);
                    sb.Append("-");
                }
            }

            return sb.ToString();
        }

        public string GetStringFichasBB()
        {
            if (CurrentNivel != null && CurrentNivel is Nivel)
            { 
                return GetStringFichas(((Nivel)CurrentNivel).BigBlind);
            }
            return "";
        }

        public string GetStringFichasSB()
        {
            if (CurrentNivel != null && CurrentNivel is Nivel)
            {
                return GetStringFichas(((Nivel)CurrentNivel).SmallBlind);
            }
            return "";
        }

        public string GetStringFichasAnti()
        {
            if (CurrentNivel != null && CurrentNivel is Nivel)
            {
                return GetStringFichas(((Nivel)CurrentNivel).Anti);
            }
            return "";
        }

    }
}
