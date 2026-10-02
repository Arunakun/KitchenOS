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
            double totalCalories = Double.Parse(Console.ReadLine());
            Console.Write("Type the total recipe time (in minutes): ");
            int totalRecipeTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the category (single character): ");
            char category = Console.ReadLine()[0];

            Console.Write("Type an ingredient for this recipe: ");
            string ingredient = Console.ReadLine();
            Console.Write("Type the measurement unit for this ingredient: ");
            string measurementUnit = Console.ReadLine();
            Console.Write("Type the quantity needed for this ingredient: ");
            double quantityNeeded = Double.Parse(Console.ReadLine());
            Console.Write("Type how many units of this ingredient are available in the kitchen: ");
            double unitsAvailable = Double.Parse(Console.ReadLine());

            bool hasAvailableIngredients = true;

            double caloriesPerPortion = totalCalories / totalPortions;
            double remainingUnits = unitsAvailable - quantityNeeded;

            Console.WriteLine("\nThis recipe creates " + totalPortions + " portions of " + recipeName +
                ", containing " + caloriesPerPortion + " calories per portion. " +
                "It takes " + totalRecipeTime + " minutes to prepare, and this is the state of the available ingredients: " +
                hasAvailableIngredients + ". Currently, this recipe resides in category: " + category);

            Console.WriteLine("\nThe first ingredient for this recipe is " + ingredient + ", which requires " + quantityNeeded + " " + measurementUnit +
                ". There are currently " + unitsAvailable + " " + measurementUnit + " of this ingredient available in the kitchen. " +
                "After using this ingredient for the recipe, there will be " + remainingUnits + " " + measurementUnit + " left in the kitchen.");
        }
    }
}