using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    private int correct;
    public int pointsNeeded;
    public GameObject win;

	public void UpdateProgess()
    {
        correct++;
        if(correct >= pointsNeeded)
        {
            Complete();
        }
    }

    public void Uncorrect()
    {
        correct = 0;
    }

    private void Complete()
    {
        print("correct");
        win.SetActive(true);
    }
}
