using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wrong : MonoBehaviour {

    public GameObject control;
    public GameObject[] corrects;
    public Image cross;
    public float fillSpeed = 1f;
    public bool clicked;

    public void Clicked()
    {
        if (!clicked)
        {
            clicked = true;
            control.GetComponent<Control>().Uncorrect();
            foreach (GameObject g in corrects)
            {
                g.GetComponent<Correct>().ResetClick();
            }
        }
    }

    public void ResetClick()
    {
        clicked = false;
        cross.fillAmount = 0f;
    }

    private void Update()
    {
        if (clicked)
        {
            cross.fillAmount = cross.fillAmount + (Time.deltaTime * fillSpeed);
        }
    }
}
