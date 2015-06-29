using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recently
{
    public class DecisionSet
    {
        public String Name { get; set; }

        private List<Choice> choices;

        public DecisionSet(String name)
        {
            choices = new List<Choice>();
            this.Name = name;
        }

        public void Add(String name, String description)
        {
            var choice = new Choice();
            choice.Name = name;
            choice.Description = description;
            choices.Add(choice);
        }

    }
}
