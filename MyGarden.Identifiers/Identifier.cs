namespace MyGarden.Identifiers
{
    public abstract class Identifier<T>
    {
        public T Id { get; set; }

        public Identifier(T id)
        {
            Id = id;
        }
    }
}
