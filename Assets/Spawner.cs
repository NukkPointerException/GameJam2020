using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header ("Parameters")]
    [Tooltip ("Time interval to Spawn enemy")]
    public float timeToSpawn;

    public GameObject enemyPrefab;

    private float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0.0f)
        {
            HandleSpawn();
        }

    }

    void HandleSpawn()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        timeLeft = timeToSpawn;
        Debug.Log("Boom");
    }
}
