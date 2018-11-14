using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoderLock : MonoBehaviour {
    private int one, two, three;
    public GameObject nOne, nTwo, nThree;
    public GameObject unlock;
	// Use this for initialization
	void Start () {
        one = Mathf.FloorToInt(Random.value * 10);
        two = Mathf.FloorToInt(Random.value * 10);
        three = Mathf.FloorToInt(Random.value * 10);
        print(one);
        print(two);
        print(three);
    }
	
	public void CheckLock()
    {
        if(nOne.GetComponent<ChangeNumber>().value == one && nTwo.GetComponent<ChangeNumber>().value == two && nThree.GetComponent<ChangeNumber>().value == three)
        {
            print("Correct!");
            unlock.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
