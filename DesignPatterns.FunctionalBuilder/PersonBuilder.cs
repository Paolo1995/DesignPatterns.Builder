using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FunctionalBuilder
{
    /// <summary>
    /// Sealed classes are used to restrict the users from inheriting the class.
    /// A class can be sealed by using the sealed keyword. The keyword tells the 
    /// compiler that the class is sealed, and therefore, cannot be extended. 
    /// No class can be derived from a sealed class.
    /// </summary>
    public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name)
            => Do(p => p.Name = name);

        //private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();
        
        //public PersonBuilder Do(Action<Person> action) => AddAction(action);

        //public PersonBuilder Called(string name) => Do(p => p.Name = name);

        //public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p)) ;

        //private PersonBuilder AddAction(Action<Person> action)
        //{
        //    actions.Add(p => { action(p); 
        //        return p; 
        //    });

        //    return this;
        //}
    }
}
