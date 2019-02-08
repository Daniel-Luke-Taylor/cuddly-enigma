using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class ClickLink : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern void GotoLink();

    public void ToCasefile()
    {
        GotoLink();
    }
}
