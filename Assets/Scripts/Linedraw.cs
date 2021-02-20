using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Linedraw : MonoBehaviour
{
    //my variables
    private LineRenderer lineRend;
    private Vector2 mousePos;
    private Vector2 startMousePoS;
    public GameObject line;
    public  float changePosition;
    public bool snapToGrid = true;
    public bool isDragged = true;
    public bool smartDrag = true;
    Vector2 initialPositionObject;


    [SerializeField]
    //Display distance between two points
    private Text distanceText;
    private float distance;
      

    public void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 2;
        
        
    }
    //Update
    void Update()
    {
        //If mouse is clicked then its the starting point.
        if (Input.GetMouseButtonDown(0))
        {

         startMousePoS = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            

        }
        if (Input.GetMouseButton(0))
        {

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            lineRend.SetPosition(0, new Vector3(startMousePoS.x, startMousePoS.y, 0f));
            lineRend.SetPosition(1, new Vector3(mousePos.x, mousePos.y, 0f));

            

            distance = (mousePos - startMousePoS).magnitude;
            distanceText.text = distance.ToString("F2") + "meters";


            //transform.position = Vector3.Lerp(mousePos,startMousePoS,changePosition);


            transform.position = Vector3.Lerp(startMousePoS, mousePos,changePosition );


            if (snapToGrid)
            {
                

                transform.position = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));

                mousePos = new Vector2(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));

                lineRend.SetPosition(1, mousePos);
            }


        }


    }

}
