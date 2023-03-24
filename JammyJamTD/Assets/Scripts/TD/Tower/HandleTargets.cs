using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleTargets : MonoBehaviour
{
    List<GameObject> targets = new List<GameObject>();

    [SerializeField] GameObject projectilePrefab;

    [SerializeField] float attackDelay = 1;

    [SerializeField] Transform projectileParent;
    GameObject currentTarget;
    float timer = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            targets.Add(other.gameObject);
            currentTarget = targets[0];
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            targets.Remove(other.gameObject);
            currentTarget = targets[0];
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (currentTarget && timer >= attackDelay)
        {
            Shoot();
            timer = 0;
        }

        if (targets.Count != 0 && currentTarget == null)
        {
            targets.Remove(targets[0]);
        }
    }

    void Shoot()
    {
        ProjectileBehaviour pb = projectilePrefab.GetComponent<ProjectileBehaviour>();
        pb.spawnPosition = transform.position;
        pb.target = currentTarget;
        Instantiate(projectilePrefab);
    }
}
