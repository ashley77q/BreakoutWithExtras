using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{

    public int block_health = 7;
    public GameObject BrickParticle;
    private int score_multiplier = 0;
 
    public Material white;

    void Start()
    {

        switch (gameObject.tag)
        {

            case "Red":
                block_health = 2;
                score_multiplier = 5;
                break;

            case "Yellow":
                block_health = 2;
                score_multiplier = 3;
                break;

            case "Green":
                block_health = 2;
                score_multiplier = 1;
                break;

        }

       

    }
   

    void OnCollisionEnter(Collision other)
    {
        Instantiate(BrickParticle, transform.position, Quaternion.identity);
        {
            if (other.gameObject.name == "Ball")
                block_health --;
        }

        if (block_health <= 2)
        {
            GetComponent<MeshRenderer>().material = white;


        }

        if (block_health <= 0)
        {

            //When a block is destroyed increase the score
            ScoreScript.scoreValue += score_multiplier;
            GameManager.instance.DestroyBrick();
            Destroy(gameObject);

        }
        

    }

}

               




    

