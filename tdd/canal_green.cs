//Passar o código

using Domain.Base;

namespace Domain.Entities
{
    public class Canal : IAggregateRoot
    {
        public string Nome { get; private set; }
        public int TipoCanal { get; private set; }

        public Canal(string nome, int tipoCanal)
        {
            Nome = nome;
            TipoCanal = tipoCanal;
        }
    }
}
