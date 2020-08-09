using Assets.Ressources;
using Assets.Scripts.Entitys;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDeck : MonoBehaviour
{
    public List<GameObject> CardList;

    private bool PlayerOneDeck;
    // Start is called before the first frame update
    void Start()
    {
        SampleDataProvider data = new SampleDataProvider();
        var deck = data.GetRandomDeck();

        for (var i = 0; i < deck.CardList.Count; i++)
        {
            if (i < 3)
            {
                Instantiate(CardList[i], this.transform.parent.Find("HandCards"));
            }
            else
            {
                Instantiate(CardList[i], this.transform);
            }
        }

        if (this.transform.parent.name == "Player1")
            PlayerOneDeck = true;
        else
            PlayerOneDeck = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (GameLogic.PlayerOneTurn == PlayerOneDeck && this.transform.childCount != 0)
        {
            var temp = this.transform.GetChild(0);
            if (this.transform.parent.Find("HandCards").childCount >= 3)
            {
                Destroy(temp.gameObject);
                GameLogic.ActionsDonePerTurn += 1;
            }
            else
            {
                temp.transform.parent = this.transform.parent.Find("HandCards");
                GameLogic.ActionsDonePerTurn += 1;
            }
        }
    }
}
