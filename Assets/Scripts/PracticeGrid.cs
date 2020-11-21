using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeGrid : MonoBehaviour
{

    public GameObject prefab;
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
       
        for (int x = 0; x < gridX; x++)
        {
            for (int y = 0; y < gridY; y++)
            {
                var position = new Vector3(y, 0, x);
                Instantiate(prefab, new Vector3(x_space * (x % gridX), x_space * (y % gridY)), Quaternion.identity);

                PracticeOrangeCube.transform.position = new Vector3(x, 3, y);
                Instantiate(PracticeOrangeCube, new Vector3(x_space * (x % 11), x_space * (y % 2)), Quaternion.identity);

                PracticeRedCube.transform.position = new Vector3(x, 2, y);
                Instantiate(PracticeOrangeCube, new Vector3(x_space * (x % 2), x_space * (y % 4)), Quaternion.identity);

            }
        }




        





            /*void spawngrid()
            {

                for(int x=0; x < gridX; x++)
                {

                    for (int y =0; y < gridY; y++)
                    {


                        Vector3 spawnPosition = new Vector3(x * gridspace, 0, y * gridspace) + gridOrigin;
                        PickAndSpawn(spawnPosition, Quaternion.identity);

                    }




                }


            }


            void PickAndSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
            {



                int randomIndex = Random.Range(0, prefab.Length);
                gameObject clone = Instantiate(prefab, positionToSpawn, rotationToSpawn);
            }*/
        }
    }

