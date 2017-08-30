using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPart2 : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        GameObject part1 = GameObject.Find("Part1");
        GameObject part2 = GameObject.Find("Part2");

        string movingStatus = part2.GetComponent<OnMouse>().movingStatus;

        if ((other.gameObject == part1) && (movingStatus == "Drag"))
        {
            part2.transform.position = new Vector3(part1.transform.position.x, 0.425f, part1.transform.position.z + 1.78f); ;
            part2.transform.parent = part1.transform;
            Destroy(part2.GetComponent<Rigidbody>()); 
        }
    }
}
