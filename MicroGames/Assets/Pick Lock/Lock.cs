using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour {
    public float unlockRange;
    public Slider lockSlider;
    private float unlockPoint;
    

	// Use this for initialization
	void Start () {
        unlockPoint = Random.value;
        print(unlockPoint);
	}

    //test lock
    public void UnlockCheck()
    {
        print("checking");
        if(lockSlider.value < unlockPoint + unlockRange && lockSlider.value > unlockPoint - unlockRange)
        {
            Unlock();
            gameObject.GetComponent<WinGame>().Win();
        }
    }

    private void Unlock()
    {
        print("Correct");
        gameObject.GetComponent<Animator>().enabled = true;
    }

}
