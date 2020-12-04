using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeGrid : MonoBehaviour
{

    public GameObject PracticeGreenBrick;
    public GameObject PracticeOrangeCube;
    public GameObject PracticeRedCube;
    //public int ColumnLength =5, RowLength;
    //public float x_space, y_space;
    public int gridX;
    public int gridY;
    public float x_space;
    public float y_space;



    // Start is called before the first frame update
    void Start()
    {
        //Green
        for (int x = 0; x < gridX; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                var position = new Vector3(x_space * x, y_space * y, z: 0);

                Instantiate(PracticeGreenBrick, position, Quaternion.identity);
            }
        }

        //Orange
        for (int x = 0; x < gridX; x++)
            for (int y = 2; y < 4; y++)
            {
                var position = new Vector3(x_space * x, y_space * y, z: 0);
                Instantiate(PracticeOrangeCube, position, Quaternion.identity);


            }
        //Red

        for (int x = 0; x < gridX; x++)
            for (int y = 4; y < 6; y++)
            {
                var position = new Vector3(x_space * x, y_space * y, z: 0);

                Instantiate(PracticeRedCube, position, Quaternion.identity);

            }



    }


}









