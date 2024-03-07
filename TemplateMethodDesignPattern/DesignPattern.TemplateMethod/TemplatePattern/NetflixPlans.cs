namespace DesignPattern.TemplateMethod.TemplatePattern
{
    public  abstract class NetflixPlans
    {
        public void CreatePlan()
        {
            PlanType(string.Empty);
            CountPerson(0);
            Price(0);
            Resolution(string.Empty);
            Content(string.Empty);
        }

        //Burada amaç Netflix planının içinde yer alacak özellikleri belirlemek ve bu kolaylık olsun diye prob kullanmadan parametreli methot olarak yaptık ve değerlerini boş olarak belirledik.Çağrıldıkları plana göre içleri dolacak.

        public abstract string PlanType(string planType);
        public abstract int CountPerson(int countPerson);
        public abstract double Price(double price);
        public abstract string Resolution(string resolution);
        public abstract string Content(string content);
    }
}
