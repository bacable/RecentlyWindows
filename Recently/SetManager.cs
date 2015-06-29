using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recently
{
    public class SetManager
    {
        private static SetManager instance;

        private SetManager() { }

        private List<DecisionSet> decisionSets;

        public List<DecisionSet> DecisionSets
        {
            get
            {
                if(decisionSets == null)
                {
                    decisionSets = new List<DecisionSet>();
                }

                return decisionSets;
            }
        }

        public static SetManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SetManager();
                }
                return instance;
            }
        }












        public void NewDecisionSet(String name, List<String> choices)
        {
            var set = new DecisionSet(name);

            foreach (var choice in choices)
            {
                set.Add(choice, "");
            }

            this.DecisionSets.Add(set);
        }


        public void UnitTest_InitDecisionSets()
        {
            var decisionSets = new List<DecisionSet>();

            var set1 = new DecisionSet("Students");
            set1.Add("Bob Costas", "Short stubby kid");
            set1.Add("Chuck Duck", "Some guy");
            set1.Add("Samantha Brown", "The girl in the front row");

            var set2 = new DecisionSet("Restaurants");
            set2.Add("Taco Bell", "The one off New York Ave");
            set2.Add("Portillo's", "Just down the street");
            set2.Add("Lee's Chinese Garden", "In the strip mall");

            var set3 = new DecisionSet("Games Played");
            set3.Add("Dark Souls", "I have not beaten it yet");
            set3.Add("Dishonored", "Blink while you assassinate.");
            set3.Add("Splatoon", "Let's ink it all up.");

            this.DecisionSets.Add(set1);
            this.DecisionSets.Add(set2);
            this.DecisionSets.Add(set3);
        }
    }
}