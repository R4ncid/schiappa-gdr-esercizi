namespace Schiappa
{
    public class Borsa
    {
        private const int MAX_NUMERO_ATTREZZI = 10;
        private Attrezzo[] attrezzi;
        private int numeroAttrezzi;

        public Borsa()
        {
            attrezzi = new Attrezzo[MAX_NUMERO_ATTREZZI];
            numeroAttrezzi = 0;
        }

        /**
     * Mette un attrezzo nella stanza.
     * @param attrezzo l'attrezzo da mettere nella stanza.
     * @return true se riesce ad aggiungere l'attrezzo, false atrimenti.
     */
        public bool AddAttrezzo(Attrezzo attrezzo)
        {
            if (numeroAttrezzi < MAX_NUMERO_ATTREZZI)
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
     * Restituisce l'attrezzo nomeAttrezzo se presente nella borsa.
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
                    numeroAttrezzi--;
                    return true;
                }
            }

            return false;
        }
    }
}