using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 


public class MainUIManager : MonoBehaviour
{
    

public void StartGame () {
    Debug.Log("StartGame() called");
    SceneManager.LoadScene(1);
}

public void QuitGame () {
    Debug.Log("QuitGame() called");
    Application.Quit();
}
}