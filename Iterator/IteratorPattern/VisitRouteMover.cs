namespace Iterator.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitorRoute>
    {
        public List<VisitorRoute> visitorRoutes = new List<VisitorRoute>();
        public void AddVisitRoute(VisitorRoute visitorRoute)
        {
            visitorRoutes.Add(visitorRoute);
        }
        public int VisitRouteCount { get => visitorRoutes.Count; }
        public IIterator<VisitorRoute> CreateIterator()
        {
            return new VisitRouteIterator(this);
        }
    }
}
