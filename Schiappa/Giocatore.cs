namespace Schiappa
{
    public class Giocatore
    {
        private int energia;
        
        public Giocatore(int energiaIniziale)
        {
            energia = energiaIniziale;
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
    }
}