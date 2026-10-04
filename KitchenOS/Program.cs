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
            Console.Write("Type how many portions you want to make: ");
            int totalPortions = int.Parse(Console.ReadLine());
            double caloriesPerPortion = 386;
            int totalRecipeTime = 103; // Recipe time in minutes
            char category = 'C';
            string ingredient = "Ricotta Cheese";
            string measurementUnit = "cups";
            double quantityNeededPerPortion = 1.0 / 6.0; // 1 cup is needed per 6 portions
            double unitsAvailable = 5; // Example value
            double proteinPerPortion = 23; // Protein in grams per portion
            double fatPerPortion = 21; // Fat in grams per portion
            double carbsPerPortion = 27; // Carbohydrates in grams per portion
            double sodiumPerPortion = 890; // Sodium in milligrams per portion

            double quantityNeededTotal = quantityNeededPerPortion * totalPortions;
            double remainingUnits = unitsAvailable - quantityNeededTotal;
            double totalCalories = caloriesPerPortion * totalPortions;
            double totalProtein = proteinPerPortion * totalPortions;
            double totalFat = fatPerPortion * totalPortions;
            double totalCarbs = carbsPerPortion * totalPortions;
            double totalSodium = sodiumPerPortion * totalPortions;

            Console.WriteLine("\nThis recipe creates " + totalPortions + " portions of " + recipeName +
                ", containing " + caloriesPerPortion + " calories per portion. " +
                "It takes " + totalRecipeTime + " minutes to prepare. Currently, this recipe resides in category: " + category);

            Console.WriteLine("\nThe first ingredient for this recipe is " + ingredient + ", which requires " + quantityNeededTotal + " " + measurementUnit +
                ". There are currently " + unitsAvailable + " " + measurementUnit + " of this ingredient available in the kitchen. " +
                "After using this ingredient for the recipe, there will be " + remainingUnits + " " + measurementUnit + " left in the kitchen.");

            Console.WriteLine("\nThe total nutritional information for this recipe is as follows: " +
                "\nProtein: " + totalProtein + " grams" +
                "\nFat: " + totalFat + " grams" +
                "\nCarbohydrates: " + totalCarbs + " grams" +
                "\nSodium: " + totalSodium + " milligrams");

            Console.WriteLine("\nThe nutritional information per portion is as follows: " +
                "\nProtein: " + proteinPerPortion + " grams" +
                "\nFat: " + fatPerPortion + " grams" +
                "\nCarbohydrates: " + carbsPerPortion + " grams" +
                "\nSodium: " + sodiumPerPortion + " milligrams");
        }
    }
}