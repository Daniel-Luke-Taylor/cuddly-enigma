using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class WinGame : MonoBehaviour {
    public string[] microgames;
    public GameObject winScreen;

    [DllImport("__Internal")]
    private static extern void GetItem(string iName);

    public void Win()
    {

        foreach(string m in microgames)
        {
            GetItem(m);
        }
        winScreen.SetActive(true);
    }
}
