using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup_Enemy : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Transform[] pathPoints;

    [SerializeField] Transform enemyParent;

    [SerializeField] float spawnDelay;
    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
        enemyPrefab.GetComponent<PathFollow>().Points = pathPoints;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if(spawnTimer >= spawnDelay)
        {
            Vector3 spawnPosition = pathPoints[0].transform.position;
            spawnTimer = 0;
            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity, enemyParent);
            
        }
    }
}
