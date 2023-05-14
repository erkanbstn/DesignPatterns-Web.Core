using Observer.DAL;
using System.Collections.Generic;

namespace Observer.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observers;

        public ObserverObject()
        {
            _observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);    
        }
        public void NotifyObserver(AppUser appUser)
        {
            _observers.ForEach(b =>
            {
                b.CreateNewUser(appUser);
            });
        }
    }
}
