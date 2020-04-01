namespace Schiappa
{
    public class Giocatore
    {
        private int energia;
        private Borsa borsa;
        
        public Giocatore(int energiaIniziale)
        {
            energia = energiaIniziale;
            borsa = new Borsa();
        }


        public int GetEnergia()
        {
            return energia;
        }

        public bool IsVivo()
        {
            return energia > 0;
        }

        public void SetEnergia(int nuovaEnergia)
        {
            energia = nuovaEnergia;
        }

        public Borsa GetBorsa()
        {
            return borsa;
        }
    }
}