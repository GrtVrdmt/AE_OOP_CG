using Assets.Ressources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeGameBoard : MonoBehaviour
{
    #region PlayerDeckVariables
    
    #endregion
    #region PlayerHandCardVariables
    public List<GameObject> p1_handCards;
    public List<GameObject> p2_handCards;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
