namespace Schiappa
{
    public class Attrezzo
    {
        private string nome;
        private int peso;

        public Attrezzo(string nome, int peso)
        {
            this.nome = nome;
            this.peso = peso;
        }

        public string GetNome()
        {
            return nome;
        }

        public int GetPeso()
        {
            return peso;
        }

        public override string ToString()
        {
            return GetNome() + " (" + GetPeso() + "Kg)";
        }
    }
}