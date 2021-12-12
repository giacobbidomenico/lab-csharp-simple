namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        private readonly string _seed;
        private readonly string _name;
        private readonly int    _ordinal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            _name = name;
            _ordinal = ordinal;
            _seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) 
            : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        /// <summary>
        /// Method that gets the seed of the card.
        /// </summary>
        public string Seed
        {
            get => _seed;
        }

        /// <summary>
        /// Method that gets the name of a card.
        /// </summary>
        public string Name
        {
            get => _name;
        }

        /// <summary>
        /// Method that gets the ordinal number of a card.
        /// </summary>
        public int Ordinal
        {
            get => _ordinal;
        }

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            // TODO understand string interpolation
            return $"{this.GetType().Name}(Name={this.Name}, Seed={this.Seed}, Ordinal={this.Ordinal})";
        }

        /// <inheritdoc cref="object.Equals"/>
        public override bool Equals(object obj)
        {
            if(obj is null)
            {
                return false;
            }

            if(obj.GetType() != this.GetType())
            {
                return false;
            }

            if(obj == this)
            {
                return true;
            }

            return this.Equals(obj as Card);
        }

        /// <inheritdoc cref="object.GetHashCode" />
        public override int GetHashCode()
        {
            return HashCode.Combine(_name, _seed, _ordinal);
        }
    }
}
