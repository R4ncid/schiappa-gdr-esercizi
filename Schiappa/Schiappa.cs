using System;

namespace Schiappa
{
    /**
 * Classe principale di Schiappa, un semplice gioco di ruolo ambientato al dia.
 * Per giocare crea un'istanza di questa classe e invoca il metodo gioca
 *
 * Questa e' la classe principale crea e istanzia tutte le altre
 *
 * @author  yuri passamonti
 *         (da un'idea di Michael Kolling and David J. Barnes) 
 *          
 * @version base
 */
    public class Schiappa
    {
        private static string MESSAGGIO_BENVENUTO = "" +
                                                    "Ti trovi nell'Universita', ma oggi e' diversa dal solito...\n" +
                                                    "Meglio andare al piu' presto in biblioteca a studiare. Ma dov'e'?\n" +
                                                    "I locali sono popolati da strani personaggi, " +
                                                    "alcuni amici, altri... chissa!\n" +
                                                    "Ci sono attrezzi che potrebbero servirti nell'impresa:\n" +
                                                    "puoi raccoglierli, usarli, posarli quando ti sembrano inutili\n" +
                                                    "o regalarli se pensi che possano ingraziarti qualcuno.\n\n" +
                                                    "Per conoscere le istruzioni usa il comando 'aiuto'.";

        private static string[] elencoComandi = {"vai", "aiuto", "fine"};
        
        
        private Partita partita;
        
        public Schiappa()
        {
            partita = new Partita();
        }

        private void Gioca()
        {
            string istruzione;
            Console.WriteLine(MESSAGGIO_BENVENUTO);
            do
            {
                istruzione = Console.ReadLine();
            } while (!ProcessaIstruzione(istruzione));
        }
        /**
	 * Processa una istruzione 
	 *
	 * @return true se l'istruzione e' eseguita e il gioco continua, false altrimenti
	 */
        private bool ProcessaIstruzione(string istruzione)
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
                int energia = partita.GetEnergia();
                partita.SetEnergia(energia--);
            }
            Console.WriteLine(partita.GetLabirinto().GetStanzaCorrente().GetDescrizione());
        }
        
        /**
	 * Comando "Fine".
	 */
        private void Fine()
        {
            Console.WriteLine("Ciao grazie per aver giocato");
        }

        public static void Main(string[] args)
        {
            var schiappa = new Schiappa();
            schiappa.Gioca();
        }
    }
}