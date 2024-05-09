using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectangule : MonoBehaviour
{
    public canvasManager canvasManager;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<cuadrado>() != null)
        {
            string playerName = collision.gameObject.GetComponent<cuadrado>().Name;
            canvasManager.ChangeMessage("Hello, " + playerName + "!");
            anim.Play("Rectangle Animation");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        anim.Play("Static");
        canvasManager.HideMessage();
    }
}
