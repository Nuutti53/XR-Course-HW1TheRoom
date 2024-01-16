using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float degreesPerSecond = 0; 
    public float degreesPerSecondChild = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);

        foreach (Transform child in transform) {
            child.Rotate(new Vector3(0, degreesPerSecondChild, 0) * Time.deltaTime);
        }
    }
}
