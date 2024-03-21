﻿namespace DesignPattern.Composite.CompositePattern
{
    public class ProductComponent : IComponent
    {
        public ProductComponent(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }


        //productlarımızın ismini getirmek için.
        public string Display()
        {
           return $"<li class='list-group-item'>{Name}</li>";
        }

        public int TotalCount()
        {
            return 1;
        }
    }
}
