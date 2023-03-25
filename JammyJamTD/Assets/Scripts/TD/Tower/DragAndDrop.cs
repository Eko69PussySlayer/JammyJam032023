using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

    public Camera mainCamera;
    [SerializeField] GameObject itemToBePlaced;

    // Update is called once per frame
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            transform.position = raycastHit.point;
        }

        if (Input.GetButton("Submit"))
        {
            Instantiate(itemToBePlaced, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
