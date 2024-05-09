using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI[] texts;
    void Start()
    {
        tienda ironSword = new tienda();
        ironSword.itemName = "Espada de Hierro";
        ironSword.price = 1.5f;

        tienda woodShield = new tienda();
        woodShield.itemName = "Escudo de abeto";
        woodShield.price = 0.5f;

        tienda rayGun = new tienda();
        rayGun.itemName = "Pistolita Pew Pew";
        rayGun.price = 9999f;

        Debug.Log(ironSword.itemName + ": $" + ironSword.price.ToString("0.00"));
        Debug.Log(woodShield.itemName + ": $" + woodShield.price.ToString("0.00"));
        Debug.Log(rayGun.itemName + ": $" + rayGun.price.ToString("0.00"));
        texts[0].text = ironSword.itemName + ": $" + ironSword.price.ToString("0.00");
        texts[1].text = woodShield.itemName + ": $" + woodShield.price.ToString("0.00");
        texts[2].text = rayGun.itemName + ": $" + rayGun.price.ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
