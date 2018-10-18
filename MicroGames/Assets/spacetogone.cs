using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacetogone : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            print("jump");
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        if (Input.GetButtonUp("Jump"))
        {
            print("unjump");
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
