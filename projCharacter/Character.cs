using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projCharacter
{
    public class Character
    {
        public string nameCharacter;
        public float lifePoints;
        public float lifeDef;
        public float lifeAttak;
        public Character()
        {
            nameCharacter = "Toto";
            lifeAttak = 50;
            lifeDef = 20;
            lifePoints = 70;
           
        }

        public Character(string _nameCharacter, string _lifeDef, string _lifeAttak, string _lifePoints)
        {
            nameCharacter = _nameCharacter;
            lifeDef = float.Parse(_lifeDef);
            lifeAttak= float.Parse(_lifeAttak);
            lifePoints = float.Parse(_lifePoints);
        }

        
    }
}
