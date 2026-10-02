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
            double totalCalories = Convert.ToDouble(Console.ReadLine());
            Console.Write("Type the preparation time (in minutes): ");
            int preparationTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the category (single character): ");
            char category = Console.ReadLine()[0];

            bool hasAvailableIngredients = false;

            double caloriesPerPortion = totalCalories / totalPortions;

            Console.WriteLine("\nThis recipe creates " + totalPortions + " portions of " + recipeName +
                ", containing " + caloriesPerPortion + " calories per portion. " +
                "It takes " + preparationTime + " minutes to prepare, and this is the state of the available ingredients: " +
                hasAvailableIngredients + ". Currently, this recipe resides in category: " + category);
        }
    }
}
