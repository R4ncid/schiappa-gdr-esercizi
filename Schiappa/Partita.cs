using System;

namespace Schiappa
{
    public class Partita
    {
        private static int ENERGIA_INIZIALE = 20;

        private Stanza stanzaCorrente;

        private Stanza stanzaVincente;
        private int energia;
        private bool finita;

        public Partita()
        {
            CreaStanze();
            finita = false;
            energia = ENERGIA_INIZIALE;
        }

        /**
     * Crea tutte le stanze e le porte di collegamento
     */
        private void CreaStanze()
        {
            /* crea gli attrezzi */
            Attrezzo lanterna = new Attrezzo("lanterna", 3);
            Attrezzo osso = new Attrezzo("osso", 1);

            var atrio = new Stanza("Atrio");
            var aulaN11 = new Stanza("Aula N11");
            var aulaN10 = new Stanza("Aula N10");
            var laboratorio = new Stanza("Laboratorio Campus");
            var biblioteca = new Stanza("Biblioteca");

            /* pone gli attrezzi nelle stanze */
            aulaN10.AddAttrezzo(lanterna);
            atrio.AddAttrezzo(osso);

            /* collega le stanze */
            atrio.ImpostaStanzaAdiacente("nord", biblioteca);
            atrio.ImpostaStanzaAdiacente("est", aulaN11);
            atrio.ImpostaStanzaAdiacente("sud", aulaN10);
            atrio.ImpostaStanzaAdiacente("ovest", laboratorio);
            aulaN11.ImpostaStanzaAdiacente("est", laboratorio);
            aulaN11.ImpostaStanzaAdiacente("ovest", atrio);
            aulaN10.ImpostaStanzaAdiacente("nord", atrio);
            aulaN10.ImpostaStanzaAdiacente("est", aulaN11);
            aulaN10.ImpostaStanzaAdiacente("ovest", laboratorio);
            laboratorio.ImpostaStanzaAdiacente("est", atrio);
            laboratorio.ImpostaStanzaAdiacente("ovest", aulaN11);
            biblioteca.ImpostaStanzaAdiacente("sud", atrio);


            // il gioco comincia nell'atrio
            stanzaCorrente = atrio;
            stanzaVincente = biblioteca;
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
            return stanzaCorrente == stanzaVincente;
        }

        /**
	 * Imposta la partita come finita
	 *
	 */
        public void SetFinita()
        {
            this.finita = true;
        }

        public Stanza GetStanzaCorrente()
        {
            return stanzaCorrente;
        }

        public void SetStanzaCorrente(Stanza nuovaStanzaCorrente)
        {
            stanzaCorrente = nuovaStanzaCorrente;
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