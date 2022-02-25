namespace DesignPatterns.Observer
{
    public class Subscriber : IObserver
    {
        private readonly Guid Id = Guid.NewGuid();
        private YoutubeChannel _observable = null;
        public Subscriber(IObservable observable)
        {
            _observable = observable as YoutubeChannel;
        }

        public void Update() 
        {
            Console.WriteLine($"{Id} Nuevo video {_observable.GetLastVideoTitle()}");
        }
        
    }
}