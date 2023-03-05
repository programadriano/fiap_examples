//Passar o código

using Domain.Base;

namespace Domain.Entities
{
    public enum TipoCanal
    {
        Video = 1,
        Audio = 2
    }

    public class Canal : IAggregateRoot
    {
        public string Nome { get; private set; }
        public TipoCanal TipoCanal { get; private set; }

        public Canal(string nome, TipoCanal tipoCanal)
        {
            Nome = nome;
            TipoCanal = tipoCanal;
        }
    }
}
