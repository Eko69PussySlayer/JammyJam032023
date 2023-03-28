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
    public TMP_Text Texty;
    public GameObject AutoFarm;
    public int gold = 0;
    public int goldPerClick = 1;
   public GameObject Head;
    public int AutoClickPrice = 10;
    public bool AutoFarmActive = false;
    public int AutoFarmGoldPerSecond = 1;
    protected float Timer;
    public int DelayAmount = 1;
    public int AutoFarmPrice = 100;
    public int AutoFarmGoldModifer = 2;
    public int AutoFarmPriceModifer = 2;
    

    // Start is called before the first frame update
    void Start()
    {   
         GameObject Head = GameObject.Find("Skull01");
        Texty.text = "Get Gold by clicking the Head";
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
        if (gold >= AutoFarmPrice)
        {
            gold -= AutoFarmPrice;
            AutoFarm.SetActive(true);
            AutoFarmGoldPerSecond = AutoFarmGoldPerSecond * AutoFarmGoldModifer;
            AutoFarmPrice = AutoFarmPrice * AutoFarmPriceModifer;
            goldText.text = "You have " + gold + " gold!";
            AutoFarmText.text = "You bought Gold Mine!";
            AutoFarmActive = true;
       
        }
        else
        {
            Texty.text = "You need 100 gold to buy this!";
        }
    }

    public void AutoFarmGold()
    {
        Timer += Time.deltaTime;
 
         if (Timer >= DelayAmount)
         {
             Timer = 0f;
             gold += AutoFarmGoldPerSecond;
                Debug.Log("You have " + gold + " gold!");

         }
    }

    public void CameraBack()
    {
        cam.transform.position = target2.position;
    }



 


}



