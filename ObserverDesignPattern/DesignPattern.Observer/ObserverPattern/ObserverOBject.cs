using DesignPattern.Observer.DAL;
using System.Collections.Generic;

namespace DesignPattern.Observer.ObserverPattern
{
    public class ObserverOBject
    {

        //constructorda olusturmamızın nedeni  gözlemlediğimiz şeyleri liste olarak tutmak için,ardından bu listeden istediğimizi seçip işlem yaptırabiliriz.

        private readonly List<IObserver> _observers;

        public ObserverOBject()
        {
            _observers = new List<IObserver>();
        }

        //Burada hangi bültene abone olucaksak buradan belirliyoruz.
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        //Olayları her bir kullanıcı için tek tek tetiklenmesi için kullanılan metot.
        /// <summary>
        /// İçerisine gözlemlenen kullanıcıdaki adımları tutuyor.
        /// </summary>       
        public void NotifyObserver (AppUser appUser)
        {
            _observers.ForEach(x =>
            {
                x.CreateNewUser(appUser);
            });
        }

    }
}
