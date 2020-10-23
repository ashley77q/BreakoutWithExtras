using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSquare : MonoBehaviour
{
    Vector3 V = new Vector3(10, 10, 10);
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(V * Time.deltaTime);
    }
}
