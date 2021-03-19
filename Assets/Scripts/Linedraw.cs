using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
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
    public int numberOfSegments;


    [SerializeField]
    //Display distance between two points
    private Text distanceText;
    private float distance;
    [SerializeField] private Transform _spherePrefab;

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

            DrawLine();
            DrawDots();
        }
    }

    private List<Transform> SphereDestroy = new List<Transform>();
    //private int numberOfSegments;

    public void DrawDots()
    {
        // Destroy Dots from last frame
        List<Transform> copyOfTheSpheresList = new List<Transform>(SphereDestroy);
        foreach (var sphere in copyOfTheSpheresList)
        {
            SphereDestroy.Remove(sphere);
            Destroy(sphere.gameObject);
        }

        //Changes the number of dots that appear on the line
        //int numberOfSegmeints = Click.AddDots;
        //int numberOfSegments = 5;


       // Vector3[] points = new Vector3[numberOfSegments + 1];
        //for (int step = 0; step <= numberOfSegments; step++)
       
        {
            

        
            //float percentOfTheLength = (float)step / numberOfSegments;
            //Vector3 positionOfTheDot = Vector3.Lerp(startMousePoS, mousePos, percentOfTheLength);
            //points[step] = positionOfTheDot;
        }
        


        // At this point, we have all the points.
       // foreach (var dotPosition in points)
        {
            //Transform sphereInstance = Instantiate(_spherePrefab, dotPosition, Quaternion.identity);
            //SphereDestroy.Add(sphereInstance);
        }
    }




    private void DrawLine()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lineRend.SetPosition(0, new Vector3(startMousePoS.x, startMousePoS.y, 0f));
        lineRend.SetPosition(1, new Vector3(mousePos.x, mousePos.y, 0f));
        distance = (mousePos - startMousePoS).magnitude;
        distanceText.text = distance.ToString("F2") + "meters";
        transform.position = Vector3.Lerp(mousePos,startMousePoS,changePosition);

        // Originally for moving the sphere at 50%
        transform.position = Vector3.Lerp(startMousePoS, mousePos, changePosition);
        if (snapToGrid)
        {
            transform.position = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));
            startMousePoS = new Vector3(Mathf.RoundToInt(startMousePoS.x), Mathf.RoundToInt(startMousePoS.y));


            // Setting the end point to the sphere transform at 50%
            mousePos = new Vector2(Mathf.RoundToInt(mousePos.x), Mathf.RoundToInt(mousePos.y));
            lineRend.SetPosition(1, mousePos);
            
        }

        

    }

    public void AddDots()
    {


        numberOfSegments++;



    }

}





