namespace KitchenOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(">>> KitchenOS <<<");
            Console.WriteLine();
            Console.WriteLine("Welcome to KitchenOS, the ultimate kitchen management system!");
            Console.WriteLine("This application is designed to help you manage your kitchen efficiently, from inventory tracking to recipe management.");

            Console.Write("\nType the name of the recipe: ");
            string recipeName = Console.ReadLine();
            Console.Write("Type the total portions: ");
            int totalPortions = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the total calories: ");
            int totalCalories = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the preparation time (in minutes): ");
            int preparationTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the category (single character): ");
            char category = Console.ReadLine()[0];

            bool hasAvailableIngredients = false;

            Console.WriteLine("\nThis recipe creates " + totalPortions + " portions of " + recipeName + " with a total of " + totalCalories + " calories. " +
                "It takes " + preparationTime + " minutes to prepare, and this is the state of the available ingredients: " + hasAvailableIngredients + ". " +
                "Currently, this recipe resides in category: " + category);
        }
    }
}
