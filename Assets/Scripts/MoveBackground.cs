using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float speed = - 2f;
    public float lowerYValue = -20f;
    public float upperYValue = 40;

    private void Update()
    {
        //infinity space background
        transform.Translate (0f, speed * Time.deltaTime, 0f);
        if (transform.position.y <= lowerYValue)
        {



            transform.Translate(0f, upperYValue, 0f);
        }
    }

}
