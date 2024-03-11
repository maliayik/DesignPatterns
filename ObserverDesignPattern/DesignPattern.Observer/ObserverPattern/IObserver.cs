using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern
{
    public interface IObserver
    {
        //Yeni bir kullanıcı olustugunda tetiklenecek metot.
        void CreateNewUser(AppUser appUser);
    }
}
