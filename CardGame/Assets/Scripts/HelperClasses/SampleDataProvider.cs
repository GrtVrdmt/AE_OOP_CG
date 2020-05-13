using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.VR;

namespace Assets.Ressources
{
    public class SampleDataProvider
    {
        public List<Card> CardList { get; set; }
        public SampleDataProvider()
        {
            List<Card> cardlist = new List<Card>()
            {
                new Card("Lagertha", 10, 10),
                new Card("Ragnar", 8, 7),
                new Card("Floki", 5, 6),
                new Card("Björn", 7, 7),
                new Card("Übbe", 5, 5),
                new Card("Ivar", 1, 1)
            };
            CardList = cardlist;
        }

        public Card GetRandomCard()
        {
            var random = new Random();
            int index = random.Next(CardList.Count());
            return CardList[index];
        }
    }
}
