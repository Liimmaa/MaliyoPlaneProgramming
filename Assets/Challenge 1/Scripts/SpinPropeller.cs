using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float rotationSpeed = 25;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(new Vector3(0, 0, 1) * rotationSpeed);
    }
}
