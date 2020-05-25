using Assets.Ressources;
using Assets.Scripts.Entitys;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameDeck : MonoBehaviour
{
    public List<GameObject> CardList;
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
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        var temp = this.transform.GetChild(0);
        if (this.transform.parent.Find("HandCards").childCount >= 3)
        {
            Destroy(temp.gameObject);
        }
        else
        {
            temp.transform.parent = this.transform.parent.Find("HandCards");
        }
    }
}
