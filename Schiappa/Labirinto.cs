namespace Schiappa
{
    public class Labirinto
    {
        private Stanza stanzaCorrente;

        private Stanza stanzaVincente;

        public Labirinto()
        {
            Init();
        }

        public Stanza GetStanzaCorrente()
        {
            return stanzaCorrente;
        }

        public void SetStanzaCorrente(Stanza nuovaStanzaCorrente)
        {
            stanzaCorrente = nuovaStanzaCorrente;
        }

        public bool IsInStanzaVncente()
        {
            return stanzaCorrente.Equals(stanzaVincente);
        }

        private void Init()
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
    }
}