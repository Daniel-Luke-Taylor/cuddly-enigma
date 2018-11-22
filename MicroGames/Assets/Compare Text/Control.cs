using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    private int correct;
    public int pointsNeeded;

	public void UpdateProgess()
    {
        correct++;
        if(correct <= pointsNeeded)
        {
            Complete();
        }
    }

    private void Complete()
    {
        print("correct");
    }
}
