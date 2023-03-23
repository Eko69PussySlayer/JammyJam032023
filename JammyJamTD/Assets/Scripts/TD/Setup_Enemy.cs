using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup_Enemy : MonoBehaviour
{

    public GameObject enemyPrefab;
    public Transform[] pathPoints;

    public float spawnDelay;
    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
        GameObject enemyBehaviour = enemyPrefab.transform.GetChild(0).gameObject;
        PathFollow path = enemyBehaviour.GetComponent(typeof(PathFollow)) as PathFollow;
        path.Points = pathPoints;
        Debug.Log(path.Points);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if(spawnTimer >= spawnDelay)
        {
            Vector3 spawnPosition = pathPoints[0].transform.position;
            spawnTimer = 0;
            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            
        }
    }
}
