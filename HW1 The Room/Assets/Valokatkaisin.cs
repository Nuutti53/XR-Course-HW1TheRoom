using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Valokatkaisin : MonoBehaviour
{
    public Light light;
    public InputActionReference action;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        action.action.performed += (ctx) =>
        {
            light.color = Color.red;
        };
    }
}
