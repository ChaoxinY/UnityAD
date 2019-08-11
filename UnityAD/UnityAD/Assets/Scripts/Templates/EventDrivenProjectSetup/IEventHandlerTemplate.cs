using UnityAD;

//Template copy paste only.
public class IEventHandlerTemplate : IEventHandler
{
	#region Initialization
	//Has to subscribe to the eventsubject during the Awake phase of the Unity script lifecycle to receive publisher subscribed event.
	private void Awake()
	{
		StaticReferences.EventSubject.PublisherSubscribed += SubscribeEvent;
	}
	#endregion

	#region Functionality
	public void SubscribeEvent(object eventPublisher, PublisherSubscribedEventArgs publisherSubscribedEventArgs)
	{
		//SubScribe to the targeted eventPublisher with the same type
		//if(publisherSubscribedEventArgs.Publisher.GetType() == typeof(targetType))
		//{
		//Subscribe to the targeted event.
		//}
	}

	public void UnSubScribeEvent()
	{
		StaticReferences.EventSubject.PublisherSubscribed -= SubscribeEvent;
		//Unsubscribe from all subcribed events
		//foreach(IEventPublisher eventPublisher in StaticReferences.EventSubject.EventPublishers)
		//{
		//	if(eventPublisher.GetType()== typeof(targetType))
		//	{
		//Unsubscribe event
		//	}
		//}
	}
	#endregion
}

