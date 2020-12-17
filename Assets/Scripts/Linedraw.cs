using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Linedraw : MonoBehaviour
{
    //my variables
    private LineRenderer lineRend;
    private Vector2 MousePosition;
    private Vector2 StartMousePosition;


    [SerializeField]
    private Text distanceText;

    public float distance;


    public void Start()
    {

        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 2;

    }

    //Update
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
        }

        if (Input.GetMouseButton(0))
        {

            MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lineRend.SetPosition(0, new Vector3 (StartMousePosition.x, StartMousePosition.y, 0f));
            lineRend.SetPosition(1, new Vector3 (MousePosition.x, MousePosition.y, 0f));
            distance = (MousePosition - StartMousePosition).magnitude;
            distanceText.text = distance.ToString("F2") + "meters";




        }


    }

}
