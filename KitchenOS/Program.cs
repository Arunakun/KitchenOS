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

            string recipeName = "Easy Homemade Lasagna";
            int totalPortions = 12;
            double totalCalories = 4632;
            int totalRecipeTime = 103; // Recipe time in minutes
            char category = 'C';
            string ingredient = "Ricotta Cheese";
            string measurementUnit = "cups";
            double quantityNeeded = 2;
            double unitsAvailable = 5; // Example value
            double proteinTotal = 276; // Total protein in grams for the entire recipe
            double fatTotal = 252; // Total fat in grams for the entire recipe
            double carbsTotal = 324; // Total carbohydrates in grams for the entire recipe
            double sodiumTotal = 10680; // Total sodium in milligrams for the entire recipe
            bool hasAvailableIngredients = true;

            double remainingUnits = unitsAvailable - quantityNeeded;
            double caloriesPerPortion = totalCalories / totalPortions;
            double proteinPerPortion = proteinTotal / totalPortions;
            double fatPerPortion = fatTotal / totalPortions;
            double carbsPerPortion = carbsTotal / totalPortions;
            double sodiumPerPortion = sodiumTotal / totalPortions;

            Console.WriteLine("\nThis recipe creates " + totalPortions + " portions of " + recipeName +
                ", containing " + caloriesPerPortion + " calories per portion. " +
                "It takes " + totalRecipeTime + " minutes to prepare, and this is the state of the available ingredients: " +
                hasAvailableIngredients + ". Currently, this recipe resides in category: " + category);

            Console.WriteLine("\nThe first ingredient for this recipe is " + ingredient + ", which requires " + quantityNeeded + " " + measurementUnit +
                ". There are currently " + unitsAvailable + " " + measurementUnit + " of this ingredient available in the kitchen. " +
                "After using this ingredient for the recipe, there will be " + remainingUnits + " " + measurementUnit + " left in the kitchen.");

            Console.WriteLine("\nThe total nutritional information for this recipe is as follows: " +
                "\nProtein: " + proteinTotal + " grams" +
                "\nFat: " + fatTotal + " grams" +
                "\nCarbohydrates: " + carbsTotal + " grams" +
                "\nSodium: " + sodiumTotal + " milligrams");

            Console.WriteLine("\nThe nutritional information per portion is as follows: " +
                "\nProtein: " + proteinPerPortion + " grams" +
                "\nFat: " + fatPerPortion + " grams" +
                "\nCarbohydrates: " + carbsPerPortion + " grams" +
                "\nSodium: " + sodiumPerPortion + " milligrams");
        }
    }
}