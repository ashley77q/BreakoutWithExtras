using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    //If the ball touches the red lava box a life is lost
    private void OnTriggerEnter(Collider col)
    {
        GameManager.instance.LoseLife();
    }
}
