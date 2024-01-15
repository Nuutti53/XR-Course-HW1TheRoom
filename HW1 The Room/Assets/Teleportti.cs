using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleportti : MonoBehaviour
{
    public Vector3 TeleporttiPosition;
    public Vector3 alkuperäinenPosition;
    public InputActionReference Vaihto;
    public InputActionReference VaihtoTakaisin;

    // Start is called before the first frame update
    void Start()
    {
        Vaihto.action.Enable();
        Vaihto.action.performed += (ctx) => {
            transform.position = TeleporttiPosition;
        };

        VaihtoTakaisin.action.Enable();
        VaihtoTakaisin.action.performed += (ctx) => {
            transform.position = alkuperäinenPosition;
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
