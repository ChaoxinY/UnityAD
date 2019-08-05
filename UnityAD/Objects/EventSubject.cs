using System;
using UnityEngine;
using System.Collections.Generic;

namespace UnityAD
{
    public class EventSubject : ISubject
    {
		//IEventhandlers should subscribe to this event first during the awake phase. If a IEventPublisher subscribes to this subject during the start phase, 
		//The IEventhandlers will be notified via this event. 
		public event EventHandler<PublisherSubscribedEventArgs> PublisherSubscribed;

		public List<IEventPublisher> EventPublishers { get; private set; } = new List<IEventPublisher>();

        public void Subscribe <IEventPublisher>(IEventPublisher item)
        {
            if (item is UnityAD.IEventPublisher eventPublisher)
            {
                EventPublishers.Add(eventPublisher);
				PublisherSubscribed(this, new PublisherSubscribedEventArgs(eventPublisher));
            }
            else
            {
                Debug.Log("Trying to add an Interface that is not from this name space : UnityAD");
            }
        }
        public void UnSubscribe<IEventPublisher>(IEventPublisher item)
        {
            if (item is UnityAD.IEventPublisher eventPublisher)
            {
                EventPublishers.Remove(eventPublisher);
            }
            else
            {
                Debug.Log("Trying to remove an Interface that is not from this name space : UnityAD");
            }
        }
    }

	public class PublisherSubscribedEventArgs : EventArgs
	{
		public IEventPublisher Publisher;
		public PublisherSubscribedEventArgs(IEventPublisher publisher)
		{
			Publisher = publisher;
		}
	}
}
