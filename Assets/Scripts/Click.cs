using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class Click : MonoBehaviour
/*{

    public int scoreText2;
    public Text scoreText;

    void Start()
    {

    }

    void Update()
    {
        scoreText.text = scoreText2.ToString();
    }

    public void AddScore()
    {


        scoreText2++;

    }
}*/
{

    public int numberOfSegments;
    private int sphere;
    public Button ButtonADD;
    public GameObject Cube;
    private bool CubeIsEnabled;

    void Start()
    {
        // m_YourFirstButton.onClick.AddListener(TaskOnClick);
        //gameObject.GetComponent<Button>().onClick.AddListener(AddDots);
        //CubeIsEnabled = true;
        //Cube.SetActive(CubeIsEnabled);

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {

            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

            Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, Cube.transform.position.z);
            Spawn(adjustZ);

        }

    }

    public void AddDots()
    {

        //numberOfSegments++;

        // CubeIsEnabled ^= true;
        //Cube.SetActive(CubeIsEnabled);

    }

    public void Spawn(Vector3 position)
    {


        Instantiate(Cube).transform.position = position;



    }






}



