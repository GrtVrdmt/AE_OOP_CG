using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortCardsOnField : MonoBehaviour
{
    public Vector3 fieldCardPosition1 = new Vector3( 0, -8, -20 );
    public Vector3 fieldCardPosition2 = new Vector3( 10, -8, -20 );
    public Vector3 fieldCardPosition3 = new Vector3( -10, -8, -20 );
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
        if (this.transform.childCount == 1)
        {
            var temp = this.transform.GetChild(0);
            temp.transform.position = new Vector3(fieldCardPosition1[0], fieldCardPosition1[1], fieldCardPosition1[2]);
        }
        else if (this.transform.childCount == 2)
        {
            var temp = this.transform.GetChild(0);
            temp.transform.position = new Vector3(fieldCardPosition1[0], fieldCardPosition1[1], fieldCardPosition1[2]);
            temp = this.transform.GetChild(1);
            temp.transform.position = new Vector3(fieldCardPosition2[0], fieldCardPosition2[1], fieldCardPosition2[2]);
        }
        else if (this.transform.childCount == 3)
        {
            var temp = this.transform.GetChild(0);
            temp.transform.position = new Vector3(fieldCardPosition1[0], fieldCardPosition1[1], fieldCardPosition1[2]);
            temp = this.transform.GetChild(1);
            temp.transform.position = new Vector3(fieldCardPosition2[0], fieldCardPosition2[1], fieldCardPosition2[2]);
            temp = this.transform.GetChild(2);
            temp.transform.position = new Vector3(fieldCardPosition3[0], fieldCardPosition3[1], fieldCardPosition3[2]);
        }
    }


}
