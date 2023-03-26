using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Clicker : MonoBehaviour
{
    
    [SerializeField] float Speed;
    public Transform target;
    public Transform target2;
    public Camera cam;
    public TMP_Text goldText;
    public TMP_Text AutoFarmText;
    public GameObject AutoFarm;
    public int gold = 0;
    public int goldPerClick = 1;
   public GameObject Head;
    public int AutoClickPrice = 10;
    public bool AutoFarmActive = false;

    // Start is called before the first frame update
    void Start()
    {   
         GameObject Head = GameObject.Find("Skull01");
        goldText.text = "Get Gold by clicking the Head";
        Debug.Log("You have " + gold + " gold!");    
    }

    // Update is called once per frame
    void Update()
    {
        if  (AutoFarmActive == true)
        {
            AutoFarmGold();
        }
        cam.transform.LookAt(Head.transform);
        goldText.text = "You have " + gold + " gold!";
    }
 
    public void ClickGold()
    {
        gold += goldPerClick;
        Debug.Log("You have " + gold + " gold!");
        
    }


    public void UpgradeUi()
    {

       cam.transform.position = target.position;


    }


    public void buyAutoFarm()
    {
        if (gold >= 100)
        {
            gold -= 100;
            AutoFarm.SetActive(true);
            goldText.text = "You have " + gold + " gold!";
            AutoFarmText.text = "You bought Gold Mine!";
       
        }
        else
        {
            goldText.text = "You need 100 gold to buy this!";
        }
    }

    public void AutoFarmGold()
    {
        gold += (int) (1000.0f * Time.deltaTime);
        Debug.Log("You have " + gold + " gold!");

    }

    public void CameraBack()
    {
        cam.transform.position = target2.position;
    }

    public void UpgradeGoldPerClick()
    {
        if (gold >= AutoClickPrice)
        {
            AutoClickPrice *= 3;
            gold -= AutoClickPrice;
            goldPerClick *= 2;
            goldText.text = "You have " + gold + " gold!";
        }
        else
        {
            goldText.text = "You need" + AutoClickPrice +  "gold to upgrade!";
        }
    }

}


