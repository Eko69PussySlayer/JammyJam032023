using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{

    public Camera mainCamera;
    public Button buyButton;
    [SerializeField] GameObject itemToBePlaced;
    [SerializeField] LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask))
        {
            Debug.Log("Raycast hit!");
            transform.position = raycastHit.point;
        }

        if (Input.GetButton("Submit"))
        {
            Instantiate(itemToBePlaced, transform.position, Quaternion.identity);
            Destroy(gameObject);
            buyButton.enabled = true;
        }
    }
}
