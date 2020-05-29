using Assets.Ressources;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{   


    private Boolean active;
    private Player instance;
    private GameObject HPText;
    // Start is called before the first frame update
    void Start()
    {
        this.HPText = transform.Find("HPText").gameObject;
        this.active = false;
        this.instance = new Player(30, 0);
        this.HPText.GetComponent<TextMesh>().text = instance.GetHp().ToString();
    }

    void setStatus(Boolean status)
    {
        this.active = status;
    }
}