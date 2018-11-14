using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ChangeNumber : MonoBehaviour , IPointerClickHandler {

    public int value;

    private void UpdateDisplay()
    {
        gameObject.GetComponent<Text>().text = value.ToString();
    }
    
    public void OnPointerClick(PointerEventData eve)
    {
        value++;
        if (value > 9)
        {
            value = 0;
        }
        UpdateDisplay();
    }
}
