namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitRoute>
    {
        public List<VisitRoute> visitRoutes=new List<VisitRoute>();
        
        public void AddVisitRoute(VisitRoute visitRoute)
        {
            visitRoutes.Add(visitRoute);
        }

        //VisitRoute countun kaç değer aldığını almak için.
        public int VisitRouteCount { get=> visitRoutes.Count; }

        public IIterator<VisitRoute> CreateIterator()
        {
            //her defasında kendı içerisinde döndürebileceğin yeni bir iteratörü döndürmüş olacak
            return new VisitRouteIterator(this);
        }
    }
}
