using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeGrid : MonoBehaviour
{
    public GameObject prefab;
    public int ColumnLength, RowLength;
    public float x_space, y_space;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i< ColumnLength * RowLength; i++)
        {

            Instantiate(prefab, new Vector3(x_space * (i % ColumnLength), y_space * (i / ColumnLength)), Quaternion.identity);




        }
    }
}
