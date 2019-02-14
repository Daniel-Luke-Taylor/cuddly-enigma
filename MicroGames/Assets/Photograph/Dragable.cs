using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dragable : MonoBehaviour , IDragHandler{

    private bool colliding;
    private Vector2 position;
    public GameObject slot;

    public void OnDrag(PointerEventData p)
    {
        gameObject.transform.position = Input.mousePosition;
    }

    private void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            if (colliding == true)
            {
                GameObject.FindGameObjectWithTag("counter").GetComponent<Counter>().count++;
                gameObject.transform.position = position;
                gameObject.GetComponent<Collider2D>().enabled = false;
                gameObject.GetComponent<Dragable>().enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("connect");
        if(collision.gameObject == slot)
        {
            colliding = true;
            position = collision.gameObject.transform.position;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == slot)
        {
            colliding = false;
        }
    }
}
