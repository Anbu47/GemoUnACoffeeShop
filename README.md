# UnACoffeeShopCodingProblem!
# Getting Started
## Dependencies

To execute this C# console program, you will need to have the following software installed on your computer:

- [.NET Core 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [C# vscode extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
## Execution program
Follow these step
1. Open the project folder using VSCode
2. Build the program by typing the following command:
```
dotnet build
```
This will compile your C# code and create an executable file.
3. Execute the program by typing the following command:
```
dotnet run
```
This will run your C# console program.

That's it! You should now be able to execute your C# console program using the .NET Core SDK and the command line interface.
## Help
- If you encounter any build errors, make sure that you have installed the correct version of the .NET Core SDK and that your program's dependencies are properly configured.
- If you need more advanced debugging features, consider using an integrated development environment (IDE) such as Visual Studio or Jetbrain Rider.
# How the code work

## Class Structure
ShopItem is the superclass has property _description. ShopItem include GetDescription(), Cost() function.

- _description saves object name, which depends on class. 

E.g: ```When Milktea class is create _description of the object will be change to "Milktea".```

- GetDescription() is used to return _description value.  
- Cost() is used to return the cost of item. 


To expand the code base, I choose Decorator and Factory Design Pattern.
### Decorator Design Pattern 
Defintion: Decorator Pattern will let us attach **new behaviors to objects** by placing **these objects** inside **special wrapper objects** that contain the behaviors.

In this code: 
![image](https://github.com/Anbu47/GemoUnACoffeeShop/assets/29634024/99bc9498-7c46-4b05-ab60-43b0cefe97f1)

We place **DrinkItem** and **FoodItem** inside **DrinkDecorator** and **FoodDecorator** respectively, which are special wrapper objects. 

- **DrinkDecorator** include **AlmondMilk, WholeMilk, WhippedCream** which inherit GetDescription(), Cost() function from **DrinkItem**. 
- Same go for **BagelDecorator** and **SandwichDecortor**, which inherit function from **Bagel** and **Sandwich** respectively. 
### Factory Design Pattern
Definition: Factory method provides an interface for creating objects in a superclass, but it also allows subclasses to change the type of objects that will be created.

In this code:
![image](https://github.com/Anbu47/GemoUnACoffeeShop/assets/29634024/d06632c9-b6b0-4982-979f-79c95761ab71)

**DrinkFactory** and **FoodFactory** inherit Order() function from **ShopItemFactory** to create Coffee, Milktea, Bagel, Sandwich in ShopItem, which is the superclass.

## Reference 
- https://refactoring.guru/design-patterns/decorator
- https://refactoring.guru/design-patterns/factory-method
