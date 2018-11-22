using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Correct : MonoBehaviour {

    public Image ring;
    public float fillSpeed = 1f;
    public bool clicked;

    public void Clicked()
    {
        clicked = true;
    }
    private void Update()
    {
        if (clicked)
        {
            ring.fillAmount = ring.fillAmount + (Time.deltaTime * fillSpeed);
        }
    }

}
