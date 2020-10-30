using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSquare : MonoBehaviour
{
    Vector3 V = new Vector3(10, 10, 10);
    //Vector3 V;
    void Update()
    {

        /*var euler = transform.eulerAngles;
        euler.z = Random.Range(0, 360);
        euler.x = Random.Range(0, 360);
        euler.y = Random.Range(0, 360);
        transform.Rotate( V * Time.deltaTime);*/

        transform.Rotate(V * Time.deltaTime);


    }





}


