namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                IProduct apple = new FoodProduct("Яблоко", 0.5m, "Свежие красные яблоки");
                IProduct tShirt = new ClothingProduct("Футболка", 15.0m, "Удобная хлопковая футболка");
                IProduct blender = new ApplianceProduct("Блендер", 50.0m, "Мощный блендер для приготовления смузи");

                decimal distance = 10.0m;

                Console.WriteLine($"{apple.GetName()} - {apple.GetDescription()} - Цена: {apple.GetPrice()} - Доставка: {apple.CalculateDeliveryCost(distance)}");
                Console.WriteLine($"{tShirt.GetName()} - {tShirt.GetDescription()} - Цена: {tShirt.GetPrice()} - Доставка: {tShirt.CalculateDeliveryCost(distance)}");
                Console.WriteLine($"{blender.GetName()} - {blender.GetDescription()} - Цена: {blender.GetPrice()} - Доставка: {blender.CalculateDeliveryCost(distance)}");
            }
        }
    }
}
