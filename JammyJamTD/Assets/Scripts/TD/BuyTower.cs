using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTower : MonoBehaviour
{
    [SerializeField] GameObject towerPreviewPrefab;

    [SerializeField] Camera mainCamera;

    void Start()
    {
        towerPreviewPrefab.GetComponent<DragAndDrop>().mainCamera = mainCamera;
    }

    public void TowerButtonClicked()
    {
        Instantiate(towerPreviewPrefab, Input.mousePosition, Quaternion.identity);
    }
}
