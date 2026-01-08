using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCFiveToSeven.Services
{
    public class MCFiveServices
    {
        public string MadLib (string adjective, string mythicalcreature, string items, string place, string food)
        {
            return $"Once upon a time there was an {adjective} {mythicalcreature}. This {mythicalcreature} was so {adjective} that everyone was afraid of them. The townspeople gathered around the {mythicalcreature} and threw {items} at them until they cried. Finally, the {mythicalcreature} decided to move away to {place}, where they ate {food} and made friends who did not throw {items} at them. The End.";
        }
    }
}