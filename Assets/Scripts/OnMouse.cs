using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouse : MonoBehaviour
{
    public string objectStatus = "Idle";
    private Vector3 screenPoint;
    private Vector3 offset;
    private KeyCode mouse = KeyCode.Mouse0;
    public string movingStatus = "";
    public string objectName = "";
    

    void OnMouseDown()
    {
        if (objectStatus != "Locked" && gameObject.name != "Part1")
        {
            if (Input.GetKeyDown(mouse) && objectStatus != "Locked" && gameObject.name != "Part1")
            {
                movingStatus = "Drag";
                objectName = this.gameObject.name;

            }
        }
    }

    void OnMouseDrag()
    {
        
        if (movingStatus == "Drag" && objectStatus != "Locked" && gameObject.name != "Part1")
        {
            Camera myCam = GameObject.Find("GameCamera").GetComponent<Camera>();
           
                Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z + 9.5f);
                Vector3 curPosition = myCam.ScreenToWorldPoint(curScreenPoint);

                transform.position = curPosition;
           
            GetComponent<SpriteRenderer>().sortingOrder = 40;
            GetComponent<Transform>().rotation = Quaternion.Euler(90, 0, 0);
         
        }
 
       


    }
    private void NameRefresher ()
    {
        for (int i = 1; i <= 32; i++)
        {
            GameObject obj = GameObject.Find("Part" + i);


            if (Input.GetKeyDown(mouse) && gameObject.name != "Part1")
            {
                movingStatus = "Drag";
                objectName = this.gameObject.name;


            }

            else if (objectName == obj.name && (obj.transform.position.y < 1.8f))
            {
                movingStatus = "Staying";
                objectName = "";
            }


        }

    }
    private void Start()
    {
        InvokeRepeating("NameRefresher", 1, 0.1f);
    }
    private void Update()
    {
        if (gameObject.transform.position.x < -5.5f || gameObject.transform.position.x > 16 || gameObject.transform.position.z < -3.5f || gameObject.transform.position.z > 8f ||gameObject.transform.position.y < -0.1f || gameObject.transform.position.y > 70)
        {
            this.gameObject.transform.position = new Vector3(Random.Range(-5, 15), 4f, Random.Range(-1.5f, 7));
            movingStatus = "OutOfZone";
            objectName = "";
        }
       
        if (gameObject.name == "Part1")
        {
            objectStatus = "Locked";
        }
    }
}
