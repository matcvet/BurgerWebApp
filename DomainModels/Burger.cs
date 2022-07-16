namespace DomainModels
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public Burger()
        {

        }

        public Burger(int id, string name, string description, string imageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }

        public Burger(string name, string description, string imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
