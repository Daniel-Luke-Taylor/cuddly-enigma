using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class ClickLink1 : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern void GotoBook();

    public void ToCasefile()
    {
        GotoBook();
    }
}
