using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortFieldCards : MonoBehaviour
{
    public Vector3 p1_fieldCardPosition_1 = new Vector3( 0, -80, -20);
    public Vector3 p1_fieldCardPosition_2 = new Vector3( 100, -80, -20);
    public Vector3 p1_fieldCardPosition_3 = new Vector3( -100, -80, -20);
                                       
    public Vector3 p2_fieldCardPosition_1 = new Vector3( 0, 80, -20);
    public Vector3 p2_fieldCardPosition_2 = new Vector3( -100, 80, -20);
    public Vector3 p2_fieldCardPosition_3 = new Vector3( 100, 80, -20);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTransformChildrenChanged()
    {
        var player = this.transform.parent.name;
        if (this.transform.childCount == 1)
        {
            var temp = this.transform.GetChild(0);
            temp.transform.position = player == "Player1" ? p1_fieldCardPosition_1 : p2_fieldCardPosition_1;
        }
        else if (this.transform.childCount == 2)
        {
            var temp = this.transform.GetChild(0);
            temp.transform.position = player == "Player1" ? p1_fieldCardPosition_1 : p2_fieldCardPosition_1;
            temp = this.transform.GetChild(1);
            temp.transform.position = player == "Player1" ? p1_fieldCardPosition_2 : p2_fieldCardPosition_2;
        }
        else if (this.transform.childCount == 3)
        {
            var temp = this.transform.GetChild(0);
            temp.transform.position = player == "Player1" ? p1_fieldCardPosition_1 : p2_fieldCardPosition_1;
            temp = this.transform.GetChild(1);
            temp.transform.position = player == "Player1" ? p1_fieldCardPosition_2 : p2_fieldCardPosition_2;
            temp = this.transform.GetChild(2);
            temp.transform.position = player == "Player1" ? p1_fieldCardPosition_3 : p2_fieldCardPosition_3;
        }
    }
}
