(Dish dish, Ingredient ingredient, Seasoning seasoning) soup;

while (true)
{
    Console.Clear();
    Console.WriteLine(@"Choose a dish from the following list:
1 - Soup
2 - Stew
3 - Gumbo");

    int selection = Convert.ToInt32(Console.ReadLine());

    soup.dish = selection switch
    {
        1 => Dish.Soup,
        2 => Dish.Stew,
        3 => Dish.Gumbo,
        _ => Dish.Soup,
    };

    Console.WriteLine(@"Choose an ingredient from the following list:
1 - Mushroom
2 - Chicken
3 - Carrot
4 - Potato");

    selection = Convert.ToInt32(Console.ReadLine());

    soup.ingredient = selection switch
    {
        1 => Ingredient.Mushroom,
        2 => Ingredient.Chicken,
        3 => Ingredient.Carrot,
        4 => Ingredient.Potato,
        _ => Ingredient.Carrot,
    };

    Console.WriteLine(@"Choose a seasoning from the following list:
1 - Spicy
2 - Salty
3 - Sweet");

    selection = Convert.ToInt32(Console.ReadLine());

    soup.seasoning = selection switch
    {
        1 => Seasoning.Spicy,
        2 => Seasoning.Salty,
        3 => Seasoning.Sweet,
        _ => Seasoning.Sweet,
    };

    Console.Clear();
    Console.WriteLine($"You have chosen: {soup.seasoning} {soup.ingredient} {soup.dish}");
    Console.ReadLine();
}

enum Dish
{
    Soup,
    Stew,
    Gumbo
};

enum Ingredient
{
    Mushroom,
    Chicken,
    Carrot,
    Potato
};

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
};