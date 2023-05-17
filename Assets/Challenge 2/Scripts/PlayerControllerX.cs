using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastTime;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Time.realtimeSinceStartup - lastTime > 3f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastTime = Time.realtimeSinceStartup;
            }
        }
    }
}
