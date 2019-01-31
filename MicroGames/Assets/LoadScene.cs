using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    private void Start()
    {
        //get currentURL
        string currentURL = Application.absoluteURL;
        //currentURL = "file:///C:/Users/Daniel%20Taylor/Desktop/Digital%20Artifact%20and%20Demo/cuddly-enigma/docs/lockpick.html";
        //Check the URL for specific strings and open scenes
        if (currentURL.Contains("lockpick"))
        {
            LoadSceneName("PickLock");
        }
        else if (currentURL.Contains("photo"))
        {
            LoadSceneName("Photograph");
        }
        else if (currentURL.Contains("document"))
        {
            LoadSceneName("Compare Documents");
        }
        else if (currentURL.Contains("statement"))
        {
            LoadSceneName("Compare Statements");
        }
        else if (currentURL.Contains("decoder"))
        {
            LoadSceneName("Decoder");
        }
    }

    public void LoadSceneName(string name)
    {
        SceneManager.LoadScene(name);
    }
}
