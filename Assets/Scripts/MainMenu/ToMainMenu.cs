using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ToMainMenu : MonoBehaviour {
    bool paused = false;
    private KeyCode mouse = KeyCode.Mouse0;
    GameObject part1;
    GameObject menu;
    GameObject image;
    GameObject win;
    GameObject[] gameObjectArray;
    GameObject img;
    GameObject imageBtnOn;
    GameObject imageBtnOff;
    GameObject imgTransp;
    GameObject imageTranspBtnOn;
    GameObject imageTranspBtnOff;
    bool pressed = false;
    private void Start()
    {
        imageBtnOn = GameObject.Find("ImageBtnOn");
        imageBtnOff = GameObject.Find("ImageBtnOff");
        imageTranspBtnOn = GameObject.Find("ImageTranspBtnOn");
        imageTranspBtnOff = GameObject.Find("ImageTranspBtnOff");

        part1 = GameObject.Find("Part1");
        gameObjectArray = GameObject.FindGameObjectsWithTag("Part");
        image = GameObject.Find("Image");
        menu = GameObject.Find("Canvas");   
        win = GameObject.Find("Win");
        img = GameObject.Find("Img");
        imgTransp = GameObject.Find("ImgTransp");
        
        paused = false;
        menu.SetActive(false);
        img.SetActive(false);
        imageBtnOff.SetActive(false);
        imgTransp.SetActive(false);
        imageTranspBtnOff.SetActive(false);
       
    }
    public void ImgBtnOn()
    {
        img.SetActive(true);
        imageBtnOn.SetActive(false);
        imageBtnOff.SetActive(true);
    }
    public void ImgBtnOff()
    {
        img.SetActive(false);
        imageBtnOff.SetActive(false);
        imageBtnOn.SetActive(true);
    }

    public void ImgTranspOn ()
    {
        imgTransp.SetActive(true);
        imageTranspBtnOn.SetActive(false);
        imageTranspBtnOff.SetActive(true);
    }

    public void ImgTranspOff()
    {
        imgTransp.SetActive(false);
        imageTranspBtnOn.SetActive(true);
        imageTranspBtnOff.SetActive(false);
    }
    public void ExitGameBtn ()
    {
        Application.Quit();
    }
    public void ResumeBtn ()
    {
        image.SetActive(true);
        
        menu.SetActive(false);
        foreach (GameObject go in gameObjectArray)
        {
            go.SetActive(true);
        }
        paused = false;

    }
    public void NewGameBtn ()
    {
        SceneManager.LoadScene("Game");
    }
    //Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");

        }
    }
}
