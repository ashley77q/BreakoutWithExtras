using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float PaddleSpeed = 1f;
    private Vector3 playerPos = new Vector3(0, -10f, 0);

    //Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * PaddleSpeed);
        playerPos = new Vector3(Mathf.Clamp (xPos, 1f, 20f), -9.5f, 0f);
        transform.position = playerPos;
    }





}
