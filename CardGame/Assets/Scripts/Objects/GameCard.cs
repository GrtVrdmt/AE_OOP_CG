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

    private bool PlayerOneCard;

    public bool IsActive = false;

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

        if (this.transform.parent.parent.name == "Player1")
            PlayerOneCard = true;
        else
            PlayerOneCard = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Defense == 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown()
    {
        if (GameLogic.PlayerOneTurn == PlayerOneCard && IsActive == false && GameLogic.CurrentPlayerAttacks == false)
        {
            if (this.transform.parent.parent.Find("FieldCards").childCount == 3 && this.transform.parent.name == "HandCards")
            {
                
            }
            else if (this.transform.parent.name == "FieldCards")
            {
                GameLogic.CurrentPlayerAttacks = !GameLogic.CurrentPlayerAttacks;
                IsActive = true;
                GameLogic.AttackerCard = this;
            }
            else
            {
                var temp = this.transform.parent.parent.Find("FieldCards");
                this.transform.parent = temp.transform;
                GameLogic.ActionsDonePerTurn += 1;
            }
        }
        else if (GameLogic.PlayerOneTurn != PlayerOneCard && GameLogic.CurrentPlayerAttacks == true && this.transform.parent.name == "FieldCards")
        {
            GameLogic.DefenderCard = this;
            GameLogic.Battle();
        }
        else if (IsActive == true)
        {
            IsActive = false;
            GameLogic.CurrentPlayerAttacks = false;
        }
    }

    private void UpdateValues()
    {
        this.AttackLabel.GetComponent<TextMesh>().text = this.Attack.ToString();
        this.DefenseLabel.GetComponent<TextMesh>().text = this.Defense.ToString();

    }
}