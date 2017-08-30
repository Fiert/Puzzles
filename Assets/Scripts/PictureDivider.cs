using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureDivider : MonoBehaviour {
    public Texture2D source;
    private Material mat;
    private GameObject part1;
    // Use this for initialization
    void Start () {
        source = Resources.Load("pic" +Random.Range(1, 20)) as Texture2D;
        mat = (Material)Resources.Load("Material/borders".ToString(), typeof(Material));
        PictureRenderer();
        Apply();
        part1 = GameObject.Find("Part1");
        for (float i=0.485f; i < 33; i+=0.01f)
        {
            if (i % 1 == 0)
            {
                GameObject obj = GameObject.Find("Part" + i);
                print(obj);
            }
            
        }
    }
    void PictureRenderer ()
    {
        int count = 1;
           
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 4; j++)
            {
               
                Rect rect = new Rect(i * 128, j * 128, 128, 128 );
                Sprite newSprite = Sprite.Create(source, rect, new Vector2(0.5f, 0.5f));
                GameObject obj = new GameObject("Part" + count++) as GameObject;
                obj.tag = "Part";
                SpriteRenderer spriteRender = obj.AddComponent<SpriteRenderer>();
               // spriteRender.material = mat;
                obj.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
                BoxCollider box = obj.AddComponent<BoxCollider>();
                spriteRender.sprite = newSprite;
                box.size = new Vector3(1.34f, 1.34f, 0.3f);
                if (obj.name == "Part1")
                {
                    obj.transform.position = new Vector3(-1, 0.425f, -2.95f);
                }
                //else
                //{
                //    obj.transform.position = new Vector3(i * 2, 3, j * 2);
                //}
                PhysicsCreator(obj, box);
                BorderCreator(obj);
                obj.transform.rotation = Quaternion.Euler(90, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

            }
        }        
    }
    void LayerOrder ()
    {

        for (int i = 1; i < 33; i++)
        {

            GameObject obj = GameObject.Find("Part" + i);

            if (obj.transform.position.y <= 0.485f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 0;
            }

            else if (obj.transform.position.y > 0.485f && obj.transform.position.y < 0.53f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 2;
            }
            else if (obj.transform.position.y > 0.53f && obj.transform.position.y < 0.58f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 3;
            }
            else if (obj.transform.position.y > 0.58f && obj.transform.position.y < 0.63f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 4;
            }
            else if (obj.transform.position.y > 0.63f && obj.transform.position.y < 0.68f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 5;
            }
            else if (obj.transform.position.y > 0.68f && obj.transform.position.y < 0.73f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 6;
            }
            else if (obj.transform.position.y > 0.73f && obj.transform.position.y < 0.78f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 7;
            }
            else if (obj.transform.position.y > 0.78f && obj.transform.position.y < 0.83f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 8;
            }
            else if (obj.transform.position.y > 0.83f && obj.transform.position.y < 0.88f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 9;
            }
            else if (obj.transform.position.y > 0.88f && obj.transform.position.y < 0.93f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 10;
            }
            else if (obj.transform.position.y > 0.93f && obj.transform.position.y < 0.98f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 11;
            }
            else if (obj.transform.position.y > 0.98f && obj.transform.position.y < 1.03f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 12;
            }
            else if (obj.transform.position.y > 1.03f && obj.transform.position.y < 1.08f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 13;
            }
            else if (obj.transform.position.y > 1.08f && obj.transform.position.y < 1.13f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 14;
            }
            else if (obj.transform.position.y > 1.13f && obj.transform.position.y < 1.18f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 15;
            }
            else if (obj.transform.position.y > 1.18f && obj.transform.position.y < 1.23f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 16;
            }
            else if (obj.transform.position.y > 1.23f && obj.transform.position.y < 1.28f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 17;
            }
            else if (obj.transform.position.y > 1.28f && obj.transform.position.y < 1.33f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 18;
            }
            else if (obj.transform.position.y > 1.33f && obj.transform.position.y < 1.38f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 19;
            }
            else if (obj.transform.position.y > 1.38f && obj.transform.position.y < 1.43f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 20;
            }
            else if (obj.transform.position.y > 1.43f && obj.transform.position.y < 1.48f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 21;
            }
            else if (obj.transform.position.y > 1.48f && obj.transform.position.y < 1.53f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 22;
            }
            else if (obj.transform.position.y > 1.53f && obj.transform.position.y < 1.58f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 23;
            }
            else if (obj.transform.position.y > 1.58f && obj.transform.position.y < 1.63f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 24;
            }
            else if (obj.transform.position.y > 1.63f && obj.transform.position.y < 1.68f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 25;
            }
            else if (obj.transform.position.y > 1.68f && obj.transform.position.y < 1.73f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 26;
            }
            else if (obj.transform.position.y > 1.73f && obj.transform.position.y < 1.78f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 27;
            }
            else if (obj.transform.position.y > 1.78f && obj.transform.position.y < 1.83f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 28;
            }
            else if (obj.transform.position.y > 1.83f && obj.transform.position.y < 1.88f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 29;
            }
            else if (obj.transform.position.y > 1.88f && obj.transform.position.y < 1.93f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 30;
            }
            else if (obj.transform.position.y > 1.93f && obj.transform.position.y < 1.98f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 31;
            }
            else if (obj.transform.position.y > 1.98f && obj.transform.position.y < 2.03f)
            {
                obj.GetComponent<SpriteRenderer>().sortingOrder = 32;
            }

        }
    }
    void BorderCreator (GameObject obj)
    {
        Material border = Resources.Load("Material/borders", typeof(Material)) as Material;
        GameObject parent = new GameObject("Border") as GameObject ;
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.name = "top";
        GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.name = "bottom";
        GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube3.name = "right";
        GameObject cube4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube4.name = "left";
        cube1.GetComponent<BoxCollider>().enabled = false;
        cube2.GetComponent<BoxCollider>().enabled = false;
        cube3.GetComponent<BoxCollider>().enabled = false;
        cube4.GetComponent<BoxCollider>().enabled = false;
        cube1.transform.localScale = new Vector3(1.78f, 0.02f, 0.07f);
        cube1.transform.position = new Vector3(0f, 0.9f, 0);
        cube2.transform.localScale = new Vector3(1.78f, 0.02f, 0.07f);
        cube2.transform.position = new Vector3(0f, -0.9f, 0);
        cube3.transform.localScale = new Vector3(-0.02f, -1.78f, 0.07f);
        cube3.transform.position = new Vector3(0.9f, 0, 0);
        cube4.transform.localScale = new Vector3(-0.02f, -1.78f, 0.07f);
        cube4.transform.position = new Vector3(-0.9f, 0, 0);
        cube1.transform.parent = parent.transform;
        cube2.transform.parent = parent.transform;
        cube3.transform.parent = parent.transform;
        cube4.transform.parent = parent.transform;
        cube1.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        cube2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        cube3.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        cube4.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        cube1.GetComponent<Renderer>().material = border;
        cube2.GetComponent<Renderer>().material = border;
        cube3.GetComponent<Renderer>().material = border;
        cube4.GetComponent<Renderer>().material = border;
        parent.transform.position = obj.transform.position;
        parent.transform.parent = obj.transform;



    }   
    void PhysicsCreator (GameObject obj, BoxCollider box)
    {
       
        
        Rigidbody rigbody = obj.AddComponent<Rigidbody>();
        rigbody.angularDrag = 0;
        rigbody.mass = 5;
        if (obj.name == "Part1")
        {
            obj.GetComponent<Rigidbody>().isKinematic = true;
        }

    }
    void Apply ()
    {
       
        for (int i = 1; i < 33; i++)
        {
           
            GameObject obj = GameObject.Find("Part" + i);
            obj.AddComponent<OnMouse>();
            
            if (obj.name != "Part1")
            {
             obj.transform.position = new Vector3(Random.Range(-4.3f, 14.5f), 2f, Random.Range(-1.5f, 6.5f));
            }

        }
        
        GameObject gameBoard = GameObject.Find("GameBoard");
        gameBoard.AddComponent<CollidersApply>();
        GameObject part = GameObject.Find("Part1");
        GameObject part2 = GameObject.Find("Part2");
        GameObject part5 = GameObject.Find("Part5");
        part.AddComponent< TriggerPart > ();     
        part2.AddComponent<TriggerPart2>();
        part5.AddComponent<TriggerPart5>();       
    }

    void Update () {
        LayerOrder();
        
        if (part1.transform.childCount > 0)
        {
           for (int i = 0; i <  part1.transform.childCount; i++)
            {
                part1.transform.GetChild(i).localRotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }

}

