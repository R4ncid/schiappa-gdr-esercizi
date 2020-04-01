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
        
        
        
        private Partita partita;
        private ProcessatoreIstruzioni processatoreIstruzioni;
        
        public Schiappa()
        {
            partita = new Partita();
            processatoreIstruzioni = new ProcessatoreIstruzioni(partita);
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
            return processatoreIstruzioni.Processa(istruzione);
        }
     

        public static void Main(string[] args)
        {
            var schiappa = new Schiappa();
            schiappa.Gioca();
        }
    }
}