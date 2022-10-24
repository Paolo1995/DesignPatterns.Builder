using DesignPatterns.FluentBuilderWithRecursiveGenerics;

var person = Person.New.Called("John").WorkAsA("Driver").Build();
Console.WriteLine(person);