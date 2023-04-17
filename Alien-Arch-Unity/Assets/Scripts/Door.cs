using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    // public variables are editable in unity
    public string targetScene = "";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ChangeScene();
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}



