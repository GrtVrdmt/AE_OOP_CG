using Assets.Ressources;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{
    private Boolean active;
    private Player instance;
    // Start is called before the first frame update
    void Start()
    {
        this.active = false;
        this.instance = new Player(30, 0);
    }

    void setStatus(Boolean status)
    {
        this.active = status;
    }
}