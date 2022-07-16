using DomainModels;
using Helpers;

namespace DataAccess
{
    public static class BurgerAppDb
    {
        public static List<Burger> Burgers = new List<Burger>
        {
            new Burger(NumberHelper.GetRandomId(), "Cheeseburger", "Beef, Cheese, Onion, Tomatoes, Kethcup, Lettuce", "https://www.kitchensanctuary.com/wp-content/uploads/2021/05/Double-Cheeseburger-tall-FS-38.webp"),
            new Burger(NumberHelper.GetRandomId(), "Hamburger", "Beef, Cheese, Onion, Tomatoes, Kethcup, Lettuce", "https://www.tastingtable.com/img/gallery/heres-how-hamburgers-got-their-name/intro-1653066580.webp"),
            new Burger(NumberHelper.GetRandomId(), "Chickeburger", "Chicken, Onions, Tomatoes, Kethcup, Lettuce", "https://i1.wp.com/gofry.com.fj/wp-content/uploads/2019/04/Chicken_Burger-scaled-e1624614963511.jpg?fit=600%2C583&ssl=1"),
            new Burger(NumberHelper.GetRandomId(), "Spicyburger", "Beef, Pepperoni, Onions, Tomatoes, Kethcup, Lettuce", "https://embed.widencdn.net/img/mccormick/dy2orpqxvj/800x800px/52%20SPICY%20CRUNCHY%20BURGER.jpeg?keep=c&crop=yes&u=a3rg0s&use=aeriv"),
        };

        public static List<Size> Sizes = new List<Size>
        {
            new Size(NumberHelper.GetRandomId(), "S", "10cm"),
            new Size(NumberHelper.GetRandomId(), "M", "15cm"),
            new Size(NumberHelper.GetRandomId(), "XL", "20cm"),
        };

        public static List<MenuItem> MenuItems = new List<MenuItem>
        {
            new MenuItem(NumberHelper.GetRandomId(), Burgers[0], Sizes[0], 120),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[0], Sizes[1], 170),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[0], Sizes[2], 210),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[1], Sizes[0], 100),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[1], Sizes[1], 150),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[1], Sizes[2], 200),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[2], Sizes[0], 110),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[2], Sizes[1], 160),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[2], Sizes[2], 210),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[3], Sizes[0], 130),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[3], Sizes[1], 180),
            new MenuItem(NumberHelper.GetRandomId(), Burgers[3], Sizes[2], 230),
        };

        public static List<Order> Orders = new List<Order>();
    }
}
