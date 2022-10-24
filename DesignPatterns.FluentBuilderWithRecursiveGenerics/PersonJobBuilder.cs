using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FluentBuilderWithRecursiveGenerics
{
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>> where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorkAsA(string position)
        {
            person.Position = position;
            return (SELF) this;
        }
    }
}
