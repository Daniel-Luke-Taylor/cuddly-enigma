using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {

    public int count;
    private bool complete;

    private void Update()
    {
        if (count == 9 && !complete)
        {
            complete = true;
            Unlock();
        }
    }

    private void Unlock()
    {
        print("Correct");
    }

}
