using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {


    public Click click;

    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    private float BaseCost;

    private void Start()
    {
        BaseCost = cost;
    }





    void Update()
    {


        itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;

    } 


    
    public void PurchasedUpgrade()
    {
        if (click.points >= cost)
        {
            click.points -= cost;
            count += 1;
            click.pointsperclick += clickPower;
            cost = Mathf.Round( BaseCost * Mathf.Pow(1.15f, count));
                }


    }



}
