using System;

namespace Schiappa
{
    public class ProcessatoreIstruzioni
    {
        private readonly Partita partita;
        
        private static string[] elencoComandi = {"vai", "aiuto", "fine"};

        public ProcessatoreIstruzioni(Partita partita)
        {
            this.partita = partita;
        }

        public bool Processa(string istruzione)
        {
            var comandoDaEseguire = new Comando(istruzione);
            
            if (comandoDaEseguire.GetNome().Equals("fine")) {
                Fine(); 
                return true;
            }
            if (comandoDaEseguire.GetNome().Equals("vai"))
                Vai(comandoDaEseguire.GetParametro());
            else if (comandoDaEseguire.GetNome().Equals("aiuto"))
                Aiuto();
            else
                Console.WriteLine("Comando sconosciuto");
            if (!partita.Vinta()) return false;
            
            Console.WriteLine("Hai vinto!");
            return true;
        }
        
        // implementazioni dei comandi dell'utente:

        /**
	 * Stampa informazioni di aiuto.
	 */
        private void Aiuto()
        {
            foreach (var comando in elencoComandi)
            {
                Console.WriteLine(comando);
            }
        }
        /**
	 * Cerca di andare in una direzione. Se c'e' una stanza ci entra 
	 * e ne stampa il nome, altrimenti stampa un messaggio di errore
	 */
        private void Vai(string direzione)
        {
            if (direzione == null)
            {
                Console.WriteLine("Dove vuoi andare?");
            }

            Stanza prossimaStanza = null;
            prossimaStanza = partita.GetLabirinto().GetStanzaCorrente().GetStanzaAdiacente(direzione);
            if (prossimaStanza == null)
            {
                Console.WriteLine("Direzione inesistente");
            }
            else
            {
                partita.GetLabirinto().SetStanzaCorrente(prossimaStanza);
                int energia = partita.GetGiocatore().GetEnergia();
                partita.GetGiocatore().SetEnergia(energia--);
            }
            Console.WriteLine(partita.GetLabirinto().GetStanzaCorrente().GetDescrizione());
        }
        
        /**
	 * Comando "Fine".
	 */
        private void Fine()
        {
            partita.SetFinita();
            Console.WriteLine("Ciao grazie per aver giocato");
        }
    }
}