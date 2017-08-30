using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPart5 : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        GameObject part1 = GameObject.Find("Part1");
        GameObject part5 = GameObject.Find("Part5"); 

        string movingStatus = part5.GetComponent<OnMouse>().movingStatus;

        Vector3 posRight = new Vector3(part1.transform.position.x + 1.78f, 0.425f, part1.transform.position.z);

        if ((other.gameObject.name == "Part1") && (movingStatus == "Drag"))
        {
            part5.transform.position = posRight;                      
            part5.transform.parent = part1.transform;                                                                      
            Destroy(part5.GetComponent<Rigidbody>());
        }
    }
}
