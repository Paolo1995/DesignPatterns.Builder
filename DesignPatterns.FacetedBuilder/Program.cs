using DesignPatterns.FacetedBuilder;

var pb = new PersonBuilder();
Person person = pb
    .Lives
        .At("123 London Road")
        .In("London")
        .WithPostCode("SW12AC")
    .Works
        .At("Microsoft")
        .AsA("Developer")
        .Earning(123000);

Console.WriteLine(person); 