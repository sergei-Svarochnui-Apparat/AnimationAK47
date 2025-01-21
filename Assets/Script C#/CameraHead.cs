using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHead : MonoBehaviour
{    
    public GameObject knife;
    public GameObject Uzi;
    public GameObject Ak47;

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha0))
        {
            Uzi.SetActive(false);
            Ak47.SetActive(false);
            knife.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            gameObject.SetActive(false);
            gameObject.SetActive(false);

        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            gameObject.SetActive(false);
            gameObject.SetActive(false);

        }
    }
}
