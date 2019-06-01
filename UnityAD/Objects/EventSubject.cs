using UnityEngine;
using System.Collections.Generic;

namespace UnityAD
{
    public class EventSubject : MonoBehaviour, ISubject
    {
        public List<object> EventPublishers { get; set; } = new List<object>();

        public void Subscribe<T>(T item)
        {
            if (item is object eventPublisher)
            {
                EventPublishers.Add(eventPublisher);
            }
        }
        public void UnSubscribe<T>(T item)
        {
            if (item is object eventPublisher)
            {
                EventPublishers.Remove(eventPublisher);
            }
        }
    }
}
