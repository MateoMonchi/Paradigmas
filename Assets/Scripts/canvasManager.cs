using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class canvasManager : MonoBehaviour
{
    public Image Mensaje;
    public TextMeshProUGUI messageText;
    public Animator messageAnim;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeMessage(string message)
    {
        messageText.enabled = true;
        messageAnim.Play("MessageAnimation");
        messageText.text = message;
    }
    public void HideMessage()
    {
        messageText.enabled = false;
        messageAnim.Play("HideMessageAnimation");
    }
}
