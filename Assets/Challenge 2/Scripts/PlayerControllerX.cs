using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnTimer = 0.5f;
    public float spawnTimerCounter = 0f;

    // Update is called once per frame
    void Update()
    {
        spawnTimerCounter -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&&spawnTimerCounter<0)
        {
            spawnTimerCounter = spawnTimer;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
