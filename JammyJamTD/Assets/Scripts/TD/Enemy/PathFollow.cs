using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{

    public Transform[] Points;

    [SerializeField] private float moveSpeed = 10;

    private int pointsIndex;


    // Start is called before the first frame update
    void Start()
    {
        pointsIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
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
            Destroy(gameObject);
        }
    }
}
