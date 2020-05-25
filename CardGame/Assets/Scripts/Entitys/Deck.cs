using Assets.Ressources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Entitys
{
    public class Deck
    {
        public string Name { get; set; }
        public List<Card> CardList { get; set; }

        public Deck(string name, List<Card> cardList)
        {
            Name = name;
            CardList = cardList;
        }
    }
}
