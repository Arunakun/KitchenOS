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

            string recipeName = "Creamy Buldak Ramen";
            int totalPortions = 1;
            int totalCalories = 555;
            int preparationTime = 10; // in minutes
            bool hasAvailableIngredients = false;
            char category = 'F';

            Console.WriteLine("\nRecipe: " + recipeName);
            Console.WriteLine("Portions: " + totalPortions);
            Console.WriteLine("Calories per portion: " + totalCalories);
            Console.WriteLine("Preparation time: " + preparationTime + " minutes");
            Console.WriteLine("Available ingredients: " + hasAvailableIngredients);
            Console.WriteLine("Category: " + category);

            recipeName = "Spicy creamy ramen";
            hasAvailableIngredients = true;
            category = 'E';

            Console.WriteLine("\nRecipe: " + recipeName);
            Console.WriteLine("Portions: " + totalPortions);
            Console.WriteLine("Calories per portion: " + totalCalories);
            Console.WriteLine("Preparation time: " + preparationTime + " minutes");
            Console.WriteLine("Available ingredients: " + hasAvailableIngredients);
            Console.WriteLine("Category: " + category);
        }
    }
}
