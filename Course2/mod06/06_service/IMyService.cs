namespace StarterM
{
    public interface IMyService
    {
        Guid Id { get; }
    }
    public class MySevice : IMyService, IDisposable
    {
        //public Guid Id => Guid.NewGuid();
        public Guid Id { get;  }= Guid.NewGuid();

        public void Dispose()=>Console.WriteLine(nameof(Dispose));
    }
}
