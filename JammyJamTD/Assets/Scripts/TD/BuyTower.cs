using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyTower : MonoBehaviour
{
    [SerializeField] GameObject towerPreviewPrefab;

    [SerializeField] Camera mainCamera;
    [SerializeField] Button buyButton;

    void Start()
    {
        towerPreviewPrefab.GetComponent<DragAndDrop>().mainCamera = mainCamera;
        towerPreviewPrefab.GetComponent<DragAndDrop>().buyButton = buyButton;
    }

    public void TowerButtonClicked()
    {
        buyButton.enabled = false;
        Instantiate(towerPreviewPrefab, Input.mousePosition, Quaternion.identity);
    }
}
