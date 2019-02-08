using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class WinGame : MonoBehaviour {
    public string microgame;
    public GameObject winScreen;

    [DllImport("__Internal")]
    private static extern void GetItem(string iName);

    public void Win()
    {
        GetItem(microgame);
        winScreen.SetActive(true);
    }
}
