using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoderLock : MonoBehaviour {
    private int one, two, three;
    public GameObject nOne, nTwo, nThree;
	// Use this for initialization
	void Start () {
        /*one = Mathf.FloorToInt(Random.value * 10);
        two = Mathf.FloorToInt(Random.value * 10);
        three = Mathf.FloorToInt(Random.value * 10);
        print(one);
        print(two);
        print(three);*/
        print("3,9,1");
    }
	
	public void CheckLock()
    {
        //if(nOne.GetComponent<ChangeNumber>().value == one && nTwo.GetComponent<ChangeNumber>().value == two && nThree.GetComponent<ChangeNumber>().value == three)
        if(nOne.GetComponent<ChangeNumber>().value == 3 && nTwo.GetComponent<ChangeNumber>().value == 9 && nThree.GetComponent<ChangeNumber>().value == 1)
        {
            print("Correct!");
            gameObject.GetComponent<WinGame>().Win();
        }
    }
}
