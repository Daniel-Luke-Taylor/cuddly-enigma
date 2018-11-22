using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Correct : MonoBehaviour {

    public GameObject control;
    public Image ring;
    public float fillSpeed = 1f;
    public bool clicked;

    public void Clicked()
    {
        if (!clicked)
        {
            clicked = true;
            control.GetComponent<Control>().UpdateProgess();
        }
    }

    public void ResetClick()
    {
        clicked = false;
        ring.fillAmount = 0f;
    }

    private void Update()
    {
        if (clicked)
        {
            ring.fillAmount = ring.fillAmount + (Time.deltaTime * fillSpeed);
        }
    }

}
