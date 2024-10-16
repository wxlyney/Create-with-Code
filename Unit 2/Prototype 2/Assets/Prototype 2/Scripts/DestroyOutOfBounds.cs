using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Declare variables
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the gameObject if out of bounds
        if (transform.position.z > topBound ){
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound){
            // Trigger a Game Over message
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
