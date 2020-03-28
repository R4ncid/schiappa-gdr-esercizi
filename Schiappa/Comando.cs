using System.IO;

namespace Schiappa
{
    public class Comando
    {
        private string nome;

        private string parametro;

        public Comando(string istruzione)
        {
            var parole = istruzione.Split(' ');
            nome = parole[0];
            if (parole.Length > 1)
            {
                parametro = parole[1];
            }
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetParametro()
        {
            return parametro;
        }

        public bool Sconosciuto()
        {
            return nome == null;
        }
    }
}