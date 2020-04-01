using System;

namespace Schiappa
{
    public class Partita
    {
        private static int ENERGIA_INIZIALE = 20;
        private Labirinto labirinto;

        private int energia;
        private bool finita;

        public Partita()
        {
            finita = false;
            energia = ENERGIA_INIZIALE;
            labirinto = new Labirinto();
        }

  

        /**
	 * Restituisce vero se e solo se la partita e' finita
	 * @return vero se partita finita
	 */
        public bool IsFinita()
        {
            return finita || Vinta() || (energia == 0);
        }

        /**
	 * Restituisce vero se e solo se la partita e' stata vinta
	 * @return vero se partita vinta
	 */
        public bool Vinta()
        {
            return labirinto.IsInStanzaVncente();
        }

        /**
	 * Imposta la partita come finita
	 *
	 */
        public void SetFinita()
        {
            this.finita = true;
        }

        public Labirinto GetLabirinto()
        {
            return labirinto;
        }

        public int GetEnergia()
        {
            return energia;
        }

        public void SetEnergia(int energia)
        {
            this.energia = energia;
        }
    }
}