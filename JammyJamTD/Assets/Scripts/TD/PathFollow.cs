using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{

    [SerializeField] Transform[] Points;

    [SerializeField] private float moveSpeed;

    private int pointsIndex;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[pointsIndex].transform.position;
        Debug.Log("Path Started");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Moving towards " + pointsIndex);
        if(pointsIndex <= Points.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Points[pointsIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == Points[pointsIndex].transform.position)
            {
                pointsIndex += 1;
            }
        }

        if (pointsIndex == Points.Length)
        {
            pointsIndex = 0;
        }

        if (Input.GetKeyDown("space"))
        {
            Destroy(gameObject);
        }
    }
}
