using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryWeapons : MonoBehaviour
{
    public GameObject knife;
    public GameObject Uzi;
    public GameObject Ak47;
    public GameObject TrHand;
    public GameObject TrHandStock;

    public GameObject Skoof;
    public Animator doorAk47;

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Uzi.SetActive(false);
            Ak47.SetActive(false);
            knife.SetActive(true);
            TrHand.SetActive(false);
            TrHandStock.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Uzi.SetActive(true);
            Ak47.SetActive(false);
            knife.SetActive(false);
            TrHand.SetActive(false);
            TrHandStock.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
                Uzi.SetActive(false);
                Ak47.SetActive(true);
                knife.SetActive(false);
                TrHand.SetActive(true);
                TrHandStock.SetActive(false);
        }
        if (Input.GetKey(KeyCode.R))
        {
            doorAk47 = Skoof.GetComponent<Animator>();
            if (doorAk47 != null)
            {
                doorAk47.enabled = true; // Отключаем Animator изначально
            }
        }
        if (Input.GetKey(KeyCode.Alpha0))
        {
            doorAk47 = Skoof.GetComponent<Animator>();
            if (doorAk47 != null)
            {
                doorAk47.enabled = false; // Отключаем Animator изначально
            }
        }
        
    }
}
