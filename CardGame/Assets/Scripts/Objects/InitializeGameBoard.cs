using Assets.Ressources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeGameBoard : MonoBehaviour
{
    public GameObject handCard1;
    public GameObject handCard2;
    public GameObject handCard3;

    public int[] handCardPosition1 = new int[3] { 0, -32, -20};
    public int[] handCardPosition2 = new int[3] { 10, -32, -20};
    public int[] handCardPosition3 = new int[3] { -10, -32, -20};

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(handCard1, new Vector3(handCardPosition1[0], handCardPosition1[1], handCardPosition1[2]), Quaternion.identity);
        Instantiate(handCard2, new Vector3(handCardPosition2[0], handCardPosition2[1], handCardPosition2[2]), Quaternion.identity);
        Instantiate(handCard3, new Vector3(handCardPosition3[0], handCardPosition3[1], handCardPosition3[2]), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
