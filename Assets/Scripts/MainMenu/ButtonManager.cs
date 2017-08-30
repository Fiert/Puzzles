using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public bool isPressed = false;
    public static bool timerStarted = false;

    private void Start()
    {

    }
    public void NewGameBtn (string newGame)
    {
      
        SceneManager.LoadScene(newGame);
        
    }
    
    public void ExitGameBtn()
    {
        Application.Quit();
    }
    public void ResumeBtn()
    {
        StartCoroutine(WaitForSceneLoad(SceneManager.GetSceneByName("Game")));
    }
    public void AdminGame()
    {
        SceneManager.LoadScene("GameAdmin");
    }

 
public IEnumerator WaitForSceneLoad(Scene scene)
{
    while (!scene.isLoaded)
    {
        yield return null;
    }
    Debug.Log("Setting active scene..");
    SceneManager.SetActiveScene(scene);
}
}
