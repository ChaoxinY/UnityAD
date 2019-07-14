namespace UnityAD
{
    public interface IEventHandler
    {
		void SubscribeEvent(object eventPublisher, PublisherSubscribedEventArgs publisherSubscribedEventArgs);
	}
}
