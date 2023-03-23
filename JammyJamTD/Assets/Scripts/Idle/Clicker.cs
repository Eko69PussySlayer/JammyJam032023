using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public int gold = 0;
    public int goldPerClick = 1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("You have " + gold + " gold!");    
    }

 
    public void ClickGold()
    {
        gold += goldPerClick;
        Debug.Log("You have " + gold + " gold!");
    }
}


