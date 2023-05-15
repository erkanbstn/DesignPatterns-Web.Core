namespace Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitorRoute>
    {
        private VisitRouteMover _routeMover;

        public VisitRouteIterator(VisitRouteMover routeMover)
        {
            _routeMover = routeMover;
        }
        private int currentIndex = 0;
        public VisitorRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if (currentIndex < _routeMover.VisitRouteCount)
            {
                CurrentItem = _routeMover.visitorRoutes[currentIndex++];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
