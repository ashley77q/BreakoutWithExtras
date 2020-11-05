using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{

    public int block_health = 7;
    public GameObject BrickParticle;


    private void OnCollisionEnter(Collision other)
    {

      Instantiate(BrickParticle, transform.position, Quaternion.identity);
       
        
        if (other.gameObject.name == "Ball")
        block_health--;

        //When a block is destroyed increase the score
        ScoreScript.scoreValue += 1;
        GameManager.instance.DestroyBrick();
        Destroy(gameObject);
    }

    void Start()
    {

        switch (gameObject.tag)
        {

            case "Red":
                block_health = 4;
                break;

            case "Yellow":
                block_health = 3;
                break;

            case "Green":
                block_health = 1;
                break;


        }
        if (this.gameObject.tag == "Red")
        {
            Debug.Log("this is a red block");


        }
    }
}

               




    

