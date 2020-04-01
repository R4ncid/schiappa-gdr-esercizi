using System;

namespace Schiappa
{
    public class Partita
    {
        private static int ENERGIA_INIZIALE = 20;
        private Labirinto labirinto;

        private Giocatore giocatore;
        private bool finita;

        public Partita()
        {
            finita = false;
            giocatore = new Giocatore(ENERGIA_INIZIALE);
            labirinto = new Labirinto();
        }

  

        /**
	 * Restituisce vero se e solo se la partita e' finita
	 * @return vero se partita finita
	 */
        public bool IsFinita()
        {
            return finita || Vinta() || !giocatore.IsVivo() ;
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

        public Giocatore GetGiocatore()
        {
            return giocatore;
        }
    }
}