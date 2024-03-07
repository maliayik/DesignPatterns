namespace DesignPattern.TemplateMethod.TemplatePattern
{
    public class BasicPlan : NetflixPlans
    {
        //Netflix planımızda olusturdugumuz metotları implemet edip override ediyoruz

        //burada metotların içinde parametreleri direk olarak dönüyoruz controller tarafında kullanıcının vermiş olduğu değerleri dönüş yapıcaz.İstersek buradanda dönebiliriz.

        public override string Content(string content)
        {
            return content;
        }

        public override int CountPerson(int countPerson)
        {
            return countPerson;
        }

        public override string PlanType(string planType)
        {
           return planType;
        }

        public override double Price(double price)
        {
           return price;
        }

        public override string Resolution(string resolution)
        {
            return resolution;
        }
    }
}
