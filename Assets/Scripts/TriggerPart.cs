using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPart : MonoBehaviour
{  
    private GameObject part1;
    private GameObject obj;
    private GameObject obj2;
    private GameObject obj3;
    private GameObject obj4;
    private GameObject obj5;
    private GameObject obj6;

    private string movingStatusObj2;
    private string movingStatusObj3;
    private string movingStatusObj4;
    private string movingStatusObj5;


    // Use this for initialization
    void Start()
    {
        part1 = GameObject.Find("Part1");
        for (int i = 1; i < 33; i++)
        {
            obj = GameObject.Find("Part" + i);
            BoxCollider[] partColliders = obj.GetComponents<BoxCollider>();
            partColliders[1].enabled = false;
            partColliders[2].enabled = false;
            partColliders[3].enabled = false;
            partColliders[4].enabled = false;

        }
        InvokeRepeating("TriggerColl", 1, 0.1f);

    }
    private void OnTriggerEnter(Collider other)
    {
        int count = 2;
        int count2 = 5;
        int count3 = 6;
        int count4 = 3;
        int count5 = 9;
        for (int i = 1; i < 32; i++)
        {
            obj = GameObject.Find("Part" + i);
            obj2 = GameObject.Find("Part" + count++);
            obj3 = GameObject.Find("Part" + count2++);
            obj4 = GameObject.Find("Part" + count3++);
            obj5 = GameObject.Find("Part" + count4++);
            obj6 = GameObject.Find("Part" + count5++);

            Vector3 connectToTop = new Vector3(obj.transform.position.x, 0.425f, obj.transform.position.z + 1.78f);
            Vector3 connectToRight = new Vector3(obj.transform.position.x + 1.78f, 0.425f, obj.transform.position.z);

            movingStatusObj2 = obj2.GetComponent<OnMouse>().movingStatus;
           
            if (i % 4 != 0)
            {
               
                if (other.gameObject == obj2 && movingStatusObj2 == "Drag" && movingStatusObj2 != "OutOfZone")
                {
                   
                    if (part1.transform.Find(obj.name) )
                    {
                        obj2.transform.position = connectToTop;
                        obj2.transform.parent = part1.transform;
                        Destroy(obj2.GetComponent<Rigidbody>());
                    }
                   else  if (count4 < 34 && part1.transform.Find(obj5.name))
                    {
                        Vector3 connectToBottom = new Vector3(obj5.transform.position.x, 0.425f, obj5.transform.position.z - 1.78f);
                        obj2.transform.position = connectToBottom;
                        obj2.transform.parent = part1.transform;
                        Destroy(obj2.GetComponent<Rigidbody>());
                    }
                    if (count3 < 34 && part1.transform.Find(obj4.name))
                    {
                        Vector3 connectToLeft = new Vector3(obj4.transform.position.x - 1.78f, 0.425f, obj4.transform.position.z);
                        obj2.transform.position = connectToLeft;
                        obj2.transform.parent = part1.transform;
                        Destroy(obj2.GetComponent<Rigidbody>());
                    }
                }
            }
            if (count2 < 33 || i % 4 == 0)
            {
                movingStatusObj3 = obj3.GetComponent<OnMouse>().movingStatus;
                if (other.gameObject == obj3 && movingStatusObj3 == "Drag" && movingStatusObj3 != "OutOfZone" )
                {
                   
                    if (part1.transform.Find(obj.name))
                    {
                        obj3.transform.position = connectToRight;
                        obj3.transform.parent = part1.transform;
                        Destroy(obj3.GetComponent<Rigidbody>());
                    }
                    if (count3 < 33)
                    {
                        if (part1.transform.Find(obj4.name))
                        {
                            Vector3 connectToBottom = new Vector3(obj4.transform.position.x, 0.425f, obj4.transform.position.z - 1.78f);
                            obj3.transform.position = connectToBottom;
                            obj3.transform.parent = part1.transform;
                            Destroy(obj3.GetComponent<Rigidbody>());
                        }
                    }
                    if (count5 > 8 && count5 < 33)
                    {
                        if (part1.transform.Find(obj6.name))
                        {
                            Vector3 connectToLeft2 = new Vector3(obj6.transform.position.x - 1.78f, 0.425f, obj6.transform.position.z);
                            obj3.transform.position = connectToLeft2;
                            obj3.transform.parent = part1.transform;
                            Destroy(obj3.GetComponent<Rigidbody>());
                        }
                    }
                    
                }              
            }       
        }      
    }
    // Update is called once per frame
   private void TriggerColl()
    {
        int count = 2;
        int count2 = 5;
        int count3 = 6;
        int count4 = 3;
        for (int i = 1; i < 32; i++)
        {
            
            obj = GameObject.Find("Part" + i);

            BoxCollider[] partColliders = obj.GetComponents<BoxCollider>();       
            obj2 = GameObject.Find("Part" + count++);
            
            Vector3 posTop = new Vector3(obj.transform.position.x, 0.425f, obj.transform.position.z + 1.78f);
            Vector3 posRight = new Vector3(obj.transform.position.x + 1.78f, 0.425f, obj.transform.position.z);
            Vector3 posLeft = new Vector3(obj.transform.position.x - 1.78f, 0.425f, obj.transform.position.z);
            string part1name = obj2.GetComponent<OnMouse>().objectName;
            string partname = obj.GetComponent<OnMouse>().objectName;
                if (i % 4 != 0)
                {
                
                    if (part1name == obj2.name && obj2.transform.position.y > 2f)
                    {
                        partColliders[1].enabled = true;
                    }

                    if (obj2.transform.position == posTop || part1name == "")
                    {
                        partColliders[1].enabled = false;

                    if (obj2.transform.position == posTop)
                    {

                        GameObject partChildTop = GameObject.Find(obj.name + "/Border/top");
                        GameObject partChildBottom = GameObject.Find(obj2.name + "/Border/bottom");
                        Destroy(partChildTop);
                        Destroy(partChildBottom);
                    }
                }
                }

            if (count4 < 33)
            {
                obj5 = GameObject.Find("Part" + count4++);
                BoxCollider[] obj5Colliders = obj5.GetComponents<BoxCollider>();
                if (part1name == obj2.name && obj2.transform.position.y > 2f)
                {
                    obj5Colliders[2].enabled = true;
                }
                if (obj2.transform.position == posTop || part1name == "")
                {
                    obj5Colliders[2].enabled = false;
                }
             
            }
            if (count2 < 33)
            {
                obj3 = GameObject.Find("Part" + count2++);
                
                string part2name = obj3.GetComponent<OnMouse>().objectName;
                if (part2name == obj3.name && obj3.transform.position.y > 2f)
                {
                    partColliders[3].enabled = true;
                }
                if (obj3.transform.position == posRight || part2name == "")
                {
                    partColliders[3].enabled = false;
                }
                if (obj3.transform.position ==  posRight)
                {
                    GameObject partChildRight = GameObject.Find(obj.name + "/Border/right");
                    GameObject partChildLeft = GameObject.Find(obj3.name + "/Border/left");
                    Destroy(partChildLeft);
                    Destroy(partChildRight);
                }
               
            }
            if (count3 < 33)
            {
                obj4 = GameObject.Find("Part" + count3++);
                BoxCollider[] obj4Colliders = obj4.GetComponents<BoxCollider>();
                if ((part1name == obj2.name) && obj2.transform.position.y > 2f)
                {
                    obj4Colliders[4].enabled = true;
                }
                if (obj2.transform.position == posLeft || part1name == "")
                {
                    obj4Colliders[4].enabled = false;
                }
            }

        }
    }
}                                                                                                   