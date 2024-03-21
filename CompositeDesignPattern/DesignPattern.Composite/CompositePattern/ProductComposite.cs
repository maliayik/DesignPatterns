using System.Text;

namespace DesignPattern.Composite.CompositePattern
{
    public class ProductComposite : IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private List<IComponent> _components;

        public ProductComposite(int id, string name)
        {
            Id = id;
            Name = name;
            _components= new List<IComponent>();
        }

        public ICollection<IComponent> Components => _components;

        //Yukarıda tanımlamıs oldugumuz list componentin içine öğeleri eklemek için.
        public void Add(IComponent component) 
        {
            _components.Add(component);
        }

        //producta bağlı compositlerin isimlerini getirecek.
        public string Display()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"<div class='text-success'>{Name} ({TotalCount()})</div>");
            stringBuilder.Append("<ul class='list-group list-group-flush ms-2'>");
            foreach (var item in _components)
            {
                stringBuilder.Append(item.Display()); //her defasında displayı uygulayacak tüm     kategorileri listelemek için
            }
            stringBuilder.Append("</ul>"); //yeni bir composite geçerken ul etiketini kapat.

            return stringBuilder.ToString();
        }

        //Toplam kategori sayısını hesaplamak için
        public int TotalCount()
        {
            return _components.Sum(x=> x.TotalCount()); 
        }
    }
}
