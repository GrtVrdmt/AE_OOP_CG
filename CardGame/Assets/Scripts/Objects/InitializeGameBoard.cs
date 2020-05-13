using Assets.Ressources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeGameBoard : MonoBehaviour
{
    #region PlayerDeckVariables
    
    #endregion
    #region PlayerHandCardVariables
    public GameObject p1_handCard1;
    public GameObject p1_handCard2;
    public GameObject p1_handCard3;
    public GameObject p2_handCard1;
    public GameObject p2_handCard2;
    public GameObject p2_handCard3;
    #endregion
    public Vector3 p1_handCardPosition1 = new Vector3 ( 0, -32, -20 );
    public Vector3 p1_handCardPosition2 = new Vector3 ( 10, -32, -20 );
    public Vector3 p1_handCardPosition3 = new Vector3 ( -10, -32, -20 );

    public Vector3 p2_handCardPosition1 = new Vector3 ( 0, 32, -20 );
    public Vector3 p2_handCardPosition2 = new Vector3 ( -10, 32, -20 );
    public Vector3 p2_handCardPosition3 = new Vector3 ( 10, 32, -20 );

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(p1_handCard1, p1_handCardPosition1, Quaternion.identity, GameObject.Find("P1_HandCards").transform);
        Instantiate(p1_handCard2, p1_handCardPosition2, Quaternion.identity, GameObject.Find("P1_HandCards").transform);
        Instantiate(p1_handCard3, p1_handCardPosition3, Quaternion.identity, GameObject.Find("P1_HandCards").transform);

        Instantiate(p2_handCard1, p2_handCardPosition1, Quaternion.identity, GameObject.Find("P2_HandCards").transform);
        Instantiate(p2_handCard2, p2_handCardPosition2, Quaternion.identity, GameObject.Find("P2_HandCards").transform);
        Instantiate(p2_handCard3, p2_handCardPosition3, Quaternion.identity, GameObject.Find("P2_HandCards").transform);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
