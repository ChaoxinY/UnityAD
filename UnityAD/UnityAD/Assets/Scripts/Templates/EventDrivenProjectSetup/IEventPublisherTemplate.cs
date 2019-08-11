using UnityAD;

public class IEventPublisherTemplate : IEventPublisher
{
	#region Initialization
	private void Start()
	{
		StaticReferences.EventSubject.Subscribe(this);
	}
	#endregion

	#region Functionality
	public void UnSubscribeFromSubject()
	{
		StaticReferences.EventSubject.UnSubscribe(this);
	}
	#endregion
}


