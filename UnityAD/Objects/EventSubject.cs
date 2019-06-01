using UnityEngine;
using System.Collections.Generic;

namespace UnityAD
{
    public class EventSubject : MonoBehaviour, ISubject
    {
        public List<IEventPublisher> EventPublishers { get; set; } = new List<IEventPublisher>();

        public void Subscribe <IEventPublisher>(IEventPublisher item)
        {
            if (item is UnityAD.IEventPublisher eventPublisher)
            {
                EventPublishers.Add(eventPublisher);
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
}
