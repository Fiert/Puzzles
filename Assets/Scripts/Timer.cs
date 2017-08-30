using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public float timer;
    bool timerStarted = ButtonManager.timerStarted;

	// Use this for initialization
	void Start () {
        if (SceneManager.GetSceneByName("Game").isLoaded == true)
        {
            timerStarted = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (timerStarted == true)
        {
            timer += Time.deltaTime;
        }
    }
    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 40;
        myStyle.normal.textColor = Color.white;

        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");

        Rect rect = new Rect(new Vector2(Screen.width/2, 10), new Vector2(100, 100));
       GUI.Label(rect, minutes + ":" + seconds, myStyle);
        
    }
}
