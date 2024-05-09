using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuadrado : MonoBehaviour
{
    public string theName;
    public float speed;
    public string Name
    {
        get { return theName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                theName = value;
            }
            else
            {
                Debug.LogWarning("Please insert a name!!");
            }
        }
    }

    void FixedUpdate()
    {
        Movimiento();
    }

    void Movimiento()
    {
        float speed_x = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(speed_x, 0f, 0f) * speed;
        transform.position += movement;
    }
}
