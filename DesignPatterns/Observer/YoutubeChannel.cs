namespace DesignPatterns.Observer
{
    public class YoutubeChannel : IObservable
    {
        private readonly IList<IObserver> channelSubscribers = new List<IObserver>();
        private string lastTitle;

        public void Attach(IObserver observer)
        {
            channelSubscribers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            channelSubscribers.Remove(observer);
        }

        public void Notify() 
        {
            foreach (var subscriber in channelSubscribers) 
            {
                subscriber.Update();
            }
        }

        public void NewVideo(string title) 
        {
            lastTitle = title;
            this.Notify();
        }

        public string GetLastVideoTitle()
        {
            return lastTitle;
        }
    }
}