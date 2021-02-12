using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{

    [SerializeField]
    private int rows = 5;
    [SerializeField]
    private int cols = 8;
    [SerializeField]
    private float tileSize = 1;
    //private Vector3 tileSizee;


    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    /*private void OnDrawGizmos()
    {
        SnapToGrid();
    }

    private void SnapToGrid()
    {




        var position = new Vector3(


            Mathf.RoundToInt(this.transform.position.x),
            Mathf.RoundToInt(this.transform.position.y),
            Mathf.RoundToInt(this.transform.position.z)

            );
        this.transform.position = position;
    }

    private void SnapToGrid2()
    {
        var position = new Vector3(





            Mathf.Round(this.transform.position.x / this.tileSizee.x) * this.tileSizee.x,
             Mathf.Round(this.transform.position.x / this.tileSizee.y) * this.tileSizee.y,
              Mathf.Round(this.transform.position.x / this.tileSizee.z) * this.tileSizee.z
              );


        this.transform.position = position;

    }*/


    private void GenerateGrid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("Grass"));
        for (int row = 0; row < rows; row++)
        {

            for (int col = 0; col < cols; col++)
            {

                GameObject tile = (GameObject)Instantiate(referenceTile, transform);

                float posX = col * tileSize;
                float posY = row * -tileSize;

                tile.transform.localPosition = new Vector2(posX, posY);

            }


        }


        Destroy(referenceTile);

        //Center the grid
        float gridW = cols * tileSize;
        float gridH = rows * tileSize;

        transform.position = new Vector3(-gridW / 2 + tileSize / 2, gridH / 2 - tileSize / 2, 10);

    }

}
