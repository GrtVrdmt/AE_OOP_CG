using Assets.Ressources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCard : MonoBehaviour
{
    public string Name;

    public int Attack;

    public int Defense;

    //Start is called before the first frame update
    void Start()
    {
        SampleDataProvider dataProvider = new SampleDataProvider();
        var temp = dataProvider.GetRandomCard();
        Name = temp.Name;
        Attack = temp.Attack;
        Defense = temp.Defense;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if(this.transform.parent.parent.Find("FieldCards").childCount == 3)
        {

        }
        else
        {
        var temp = this.transform.parent.parent.Find("FieldCards");
        this.transform.parent = temp.transform;
        }
    }
}