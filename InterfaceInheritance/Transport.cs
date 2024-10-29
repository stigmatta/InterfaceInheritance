namespace TransportsHierarchy
{
    public abstract class Transport
    {
        public abstract string Name { get; }
        public abstract string Action { get; }

        public virtual void Move() {
            Console.WriteLine("{0} is {1}", Name,Action);
        }
    }
}
