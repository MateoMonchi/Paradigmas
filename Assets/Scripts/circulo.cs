using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circulo : MonoBehaviour
{
    public canvasManager canvasManager;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent <cuadrado>() != null)
        {
            if (collision.gameObject.GetComponent<cuadrado>().Name == "Cube")
            {
                canvasManager.ChangeMessage("You are Square, not a Cube!");
                collision.gameObject.GetComponent<cuadrado>().Name = "Square";
                anim.Play("FirstAnimation");
            }
            else
            {
                canvasManager.ChangeMessage("Hello, who are you?");
                anim.Play("SecondAnimation");
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        anim.Play("Static");
        canvasManager.HideMessage();
    }
}
