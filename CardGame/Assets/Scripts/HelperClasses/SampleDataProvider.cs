using Assets.Scripts.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.VR;
using Random = UnityEngine.Random;

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
            return CardList[Random.Range(0, 5)];
        }

        public Deck GetRandomDeck()
        {
            List<Card> cardList = new List<Card>();
            for(var i = 0; i < 4; i++)
            {
                cardList.Add(GetRandomCard());
            }
            Deck newDeck = new Deck("test", cardList);
            return newDeck;
        }
    }
}
