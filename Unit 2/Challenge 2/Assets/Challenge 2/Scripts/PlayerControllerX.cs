using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float downTime = 1;
    private float fire = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > fire)
        {
            fire = Time.time + downTime;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
