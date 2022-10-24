using DesignPatterns.FunctionalBuilder;

var person = new PersonBuilder().Called("John").WorkAsA("Developer").Build();
Console.WriteLine(person.Name);