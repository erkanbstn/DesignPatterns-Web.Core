using System.Text;

namespace Composite.CompositePattern
{
    public class ProductComposite : IComponent
    {
        public ProductComposite(int id, string name)
        {
            Id = id;
            Name = name;
            _components = new List<IComponent>();
        }
        private List<IComponent> _components;
        public ICollection<IComponent> Components => _components;
        public int Id { get; set; }
        public string Name { get; set; }

        public void Add(IComponent component)
        {
            _components.Add(component);
        }
        public string Display()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"<div class='text-success'>{Name} ({TotalCount()})</div>");
            stringBuilder.Append($"<ul class='list-group list-group-flush ms-2'>");
            foreach ( var component in _components )
            {
                stringBuilder.Append( component.Display() );
            }
            stringBuilder.Append("</ul>");
            return stringBuilder.ToString();
        }

        public int TotalCount()
        {
            return _components.Sum(b=>b.TotalCount());
        }
    }
}
