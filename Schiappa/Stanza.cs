using System;
using System.Text;

namespace Schiappa
{
    /**
 * Classe Stanza - una stanza in un gioco di ruolo.
 * Una stanza e' un luogo fisico nel gioco.
 * E' collegata ad altre stanze attraverso delle uscite.
 * Ogni uscita e' associata ad una direzione.
 * 
 * @author yuri passamonti
 * @see Attrezzo
 * @version base
*/
    public class Stanza
    {
        private static int NUMERO_MASSIMO_DIREZIONI = 4;
        private static int NUMERO_MASSIMO_ATTREZZI = 4;

        private string nome;
        private Stanza[] stanzeAdiacenti;
        private int numeroStanzeAdiacenti;
        private string[] direzioni;

        private Attrezzo[] attrezzi;
        private int numeroAttrezzi;

        /**
        * Crea una stanza. Non ci sono stanze adiacenti, non ci sono attrezzi.
        * @param nome il nome della stanza
     */
        public Stanza(string nome)
        {
            this.nome = nome;
            numeroStanzeAdiacenti = 0;
            direzioni = new string[NUMERO_MASSIMO_DIREZIONI];
            stanzeAdiacenti = new Stanza[NUMERO_MASSIMO_DIREZIONI];
            numeroAttrezzi = 0;
            attrezzi = new Attrezzo[NUMERO_MASSIMO_ATTREZZI];
        }
        

        /**
     * Imposta una stanza adiacente.
     *
     * @param direzione direzione in cui sara' posta la stanza adiacente.
     * @param stanza stanza adiacente nella direzione indicata dal primo parametro.
     */
        public void ImpostaStanzaAdiacente(string direzione, Stanza stanza)
        {
            bool aggiornato = false;
            for (var i = 0; i < direzioni.Length; i++)
            {
                if (direzione.Equals(direzioni[i]))
                {
                    stanzeAdiacenti[i] = stanza;
                    aggiornato = true;
                }
            }

            if (!aggiornato)
            {
                if (numeroStanzeAdiacenti < NUMERO_MASSIMO_DIREZIONI)
                {
                    direzioni[numeroStanzeAdiacenti] = direzione;
                    stanzeAdiacenti[numeroStanzeAdiacenti] = stanza;
                    numeroStanzeAdiacenti++;
                }
            }
        }

        /**
     * Restituisce la stanza adiacente nella direzione specificata
     * @param direzione
     */
        public Stanza GetStanzaAdiacente(string direzione)
        {
            Stanza stanza = null;
            for (var i = 0; i < numeroStanzeAdiacenti; i++)
            {
                if (direzioni[i].Equals(direzione))
                {
                    stanza = stanzeAdiacenti[i];
                }
            }

            return stanza;
        }
        /**
     * Restituisce la nome della stanza.
     * @return il nome della stanza
     */
        public string GetNome()
        {
            return nome;
        }

        
        /**
     * Restituisce la descrizione della stanza.
     * @return la descrizione della stanza
     */
        public string GetDescrizione()
        {
            return ToString();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(nome);
            sb.AppendLine("Uscite:");
            foreach (var direzione in direzioni)
            {
                if (direzione != null)
                {
                    sb.AppendLine(" " + direzione);
                }
            }

            sb.AppendLine("Attrezzi:");
            foreach (var attrezzo in attrezzi)
            {
                if (attrezzo != null)
                {
                    sb.AppendLine(" " + attrezzo);
                }
            }

            return sb.ToString();
        }
        
        public string[] GetDirezioni()
        {
            var direzioni = new string[numeroStanzeAdiacenti];
            for (var i = 0; i < numeroStanzeAdiacenti; i++)
                direzioni[i] = this.direzioni[i];
            return direzioni;
        }

        /**
     * Restituisce la collezione di attrezzi presenti nella stanza.
     * @return la collezione di attrezzi nella stanza.
     */
        public Attrezzo[] GetAttrezzi()
        {
            return attrezzi;
        }

        /**
     * Mette un attrezzo nella stanza.
     * @param attrezzo l'attrezzo da mettere nella stanza.
     * @return true se riesce ad aggiungere l'attrezzo, false atrimenti.
     */
        public bool AddAttrezzo(Attrezzo attrezzo)
        {
            if (numeroAttrezzi < NUMERO_MASSIMO_ATTREZZI)
            {
                attrezzi[numeroAttrezzi] = attrezzo;
                numeroAttrezzi++;
                return true;
            }

            return false;
        }

        /**
	* Controlla se un attrezzo esiste nella stanza (uguaglianza sul nome).
	* @return true se l'attrezzo esiste nella stanza, false altrimenti.
	*/
        public bool HasAttrezzo(string nomeAttrezzo)
        {
            var trovato = false;
            foreach (var attrezzo in attrezzi)
            {
                if (attrezzo.GetNome().Equals(nomeAttrezzo))
                    trovato = true;
            }

            return trovato;
        }

        /**
     * Restituisce l'attrezzo nomeAttrezzo se presente nella stanza.
	 * @param nomeAttrezzo
	 * @return l'attrezzo presente nella stanza.
     * 		   null se l'attrezzo non e' presente.
	 */
        public Attrezzo GetAttrezzo(string nomeAttrezzo)
        {
            Attrezzo attrezzoCercato;
            attrezzoCercato = null;
            foreach (var attrezzo in attrezzi)
            {
                if (attrezzo.GetNome().Equals(nomeAttrezzo))
                    attrezzoCercato = attrezzo;
            }

            return attrezzoCercato;
        }

        /**
	 * Rimuove un attrezzo dalla stanza (ricerca in base al nome).
	 * @param nomeAttrezzo
	 * @return true se l'attrezzo e' stato rimosso, false altrimenti
	 */
        public bool RemoveAttrezzo(string nomeAttrezzo)
        {
            for (int i = 0; i < attrezzi.Length; i++)
            {
                if (attrezzi[i].GetNome().Equals(nomeAttrezzo))
                {
                    attrezzi[i] = null;
                    return true;
                }
            }
            return false;
        }
    }
}