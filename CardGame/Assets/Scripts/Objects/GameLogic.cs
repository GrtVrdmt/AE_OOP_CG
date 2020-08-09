using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameLogic : MonoBehaviour
{
    public static bool PlayerOneTurn = true;
    public static bool CurrentPlayerAttacks = false;
    public static int ActionsDonePerTurn;
    public static GameCard AttackerCard;
    public static GameCard DefenderCard;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ActionsDonePerTurn >= 2)
        {
            PlayerOneTurn = !PlayerOneTurn;
            ActionsDonePerTurn = 0;
        }
    }

    public static void Battle()
    {
        if (AttackerCard.Attack >= DefenderCard.Defense)
        {
            DefenderCard.Defense = 0;
        }
        CurrentPlayerAttacks = false;
        AttackerCard.IsActive = false;
        ActionsDonePerTurn += 1;
        AttackerCard = null;
        DefenderCard = null;
    }

    public static void Angriff(ref GameCard attacker)
    {
        AttackerCard = attacker;
    }

    public static void Verteidigung(ref GameCard defender)
    {

    }
}
