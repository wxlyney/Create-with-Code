using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    // Declare variable
    public float speed = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move animals and projectile forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
