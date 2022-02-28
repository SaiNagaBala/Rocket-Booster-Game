using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RocketAllowed")
        {
            Debug.Log("You are Allowed ");
            Debug.Log("**YOU WON THE GAME**");
        }
        else if (collision.gameObject.tag == "NotAllowed")
        {
            Debug.Log("Not Allowed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
