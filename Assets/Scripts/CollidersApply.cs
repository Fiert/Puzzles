    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidersApply : MonoBehaviour {

    // Use this for initialization
    void Start() {
        
        for (int i = 1; i < 33; i++)
        {
            GameObject obj = GameObject.Find("Part" + i);
            BoxCollider top = obj.AddComponent<BoxCollider>();
            BoxCollider bottom = obj.AddComponent<BoxCollider>();
            BoxCollider right = obj.AddComponent<BoxCollider>();
            BoxCollider left = obj.AddComponent<BoxCollider>();
            top.center = new Vector3(0, 1.27f, -0.5f);
            top.size = new Vector3(0.3f, 0.3f, 1);
            top.isTrigger = true;
            
            

            bottom.center = new Vector3(0, -1.27f, -0.5f);
            bottom.size = new Vector3(0.3f, 0.3f, 1);
            bottom.isTrigger = true;
            

            right.center = new Vector3(1.27f, 0, -0.5f);
            right.size = new Vector3(0.3f, 0.3f, 1);
            right.isTrigger = true;
            

            left.center = new Vector3(-1.27f, 0, -0.5f);
            left.size = new Vector3(0.3f, 0.3f, 1);
            left.isTrigger = true;
           
        }
    }
  
	
	// Update is called once per frame
	void Update () {
		
	}
}
