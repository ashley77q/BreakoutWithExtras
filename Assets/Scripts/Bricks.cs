using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public GameObject BrickParticle;
    private void OnCollisionEnter(Collision other)
  

        {
            Instantiate(BrickParticle, transform.position, Quaternion.identity);
            GameManager.instance.DestroyBrick();
            Destroy(gameObject);
        }

    
}
