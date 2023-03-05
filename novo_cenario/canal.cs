public class Canal : IAggregateRoot
    {
        public string Nome { get; private set; }
        public TipoCanal TipoCanal { get; private set; }

        public Canal(string nome, TipoCanal tipoCanal)
        {
            Nome = nome;
            TipoCanal = tipoCanal;
            ValidateEntity();
        }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
        }
    }