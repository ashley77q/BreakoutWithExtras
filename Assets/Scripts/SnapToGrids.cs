using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrids : MonoBehaviour
{
    [SerializeField] private Vector3 gridsize = default;





    private void OnDrawGizmos()
    {
        SnaptoGrid2();
    }
    private void SnaptoGrid()
    {

        var position = new Vector3(


            Mathf.RoundToInt(this.transform.position.x),
            Mathf.RoundToInt(this.transform.position.y),
            Mathf.RoundToInt(this.transform.position.z)





            );
        this.transform.position = position;



    }
    private void SnaptoGrid2()
    {


        var position = new Vector3(





           Mathf.Round(this.transform.position.x / this.gridsize.x) * this.gridsize.x,
            Mathf.Round(this.transform.position.x / this.gridsize.y) * this.gridsize.y,
             Mathf.Round(this.transform.position.x / this.gridsize.z) * this.gridsize.z
             );


        this.transform.position = position;




    }


}
