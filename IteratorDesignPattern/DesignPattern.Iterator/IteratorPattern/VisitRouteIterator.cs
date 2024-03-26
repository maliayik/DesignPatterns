namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitRoute>
    {
        private VisitRouteMover _visitRouteMover;

        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            _visitRouteMover = visitRouteMover;
        }


        //route başlangıç değeri
        private int currentIndex = 0;

        public VisitRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            //mevcut itemın yani 0 ın gelen değerden küçük olup olmadıgı kontrolü
            if(currentIndex < _visitRouteMover.VisitRouteCount)
            {
                //sıradaki visitin tur rotasındaki index değerinin bir artmış halini al.
                CurrentItem= _visitRouteMover.visitRoutes[currentIndex++];
                return true;
            }
            else
            {
                return false;
            }
          
        }
    }
}
