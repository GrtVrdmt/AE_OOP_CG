using Assets.Ressources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCard : MonoBehaviour
{
    public string Name;

    public int Attack;

    public int Defense;

    private GameObject AttackLabel;

    private GameObject DefenseLabel;

    //Start is called before the first frame update
    void Start()
    {
        SampleDataProvider dataProvider = new SampleDataProvider();
        var temp = dataProvider.GetRandomCard();
        Name = temp.Name;
        Attack = temp.Attack;
        Defense = temp.Defense;

        //Get reference to Attack and Defense Labels
        AttackLabel = transform.Find("AttackLabel").gameObject;
        DefenseLabel = transform.Find("DefenseLabel").gameObject;

        UpdateValues();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        var temp = this.transform.parent.parent.Find("FieldCards");
        this.transform.parent = temp.transform;
    }

    private void UpdateValues()
    {
        this.AttackLabel.GetComponent<TextMesh>().text = this.Attack.ToString();
        this.DefenseLabel.GetComponent<TextMesh>().text = this.Defense.ToString();

    }
}