using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScale : MonoBehaviour {
    public Texture2D img;
    
    void Start()
    {
        InvokeRepeating("SpriteCreator", 0.001f, 1000000);
    }
    private void Update()
    {
        
    }
    void SpriteCreator ()
    {
        GameObject gameBoard = GameObject.Find("GameBoard");
        img = gameBoard.GetComponent<PictureDivider>().source;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Sprite sprite = Sprite.Create(img, new Rect(0, 0, img.width, img.height), new Vector2(1, 1));
        spriteRenderer.sprite = sprite;
    }
}
    

