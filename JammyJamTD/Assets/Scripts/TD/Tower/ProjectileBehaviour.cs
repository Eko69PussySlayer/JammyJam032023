using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public GameObject target;

    [SerializeField] float speed = 30.0f;

    public Vector3 spawnPosition = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == target)
        {
            other.gameObject.GetComponent<LifeHandler>().Take_Damage(34);
            Destroy(gameObject);
        }
    }
}
