namespace DesignPattern.Mediator.MediatorPattern.Results
{

    //Burada Özel bir sorgu için class olusturuyoruz. ve içerisine getirmek istediğimiz değerleri giriyoruz.
    public class GetProductByIdQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
    }
}
