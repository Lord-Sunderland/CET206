using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public string itemName;
    public int count;
    public float baseCost;

   void Start()
    {
        baseCost = cost;
        //tickValue = PlayerPrefs.GetInt("TICK", tickValue);
        //count = PlayerPrefs.GetInt("ITEMS", count);
    }

    private void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPoints: " + tickValue + "/s";
     //  PlayerPrefs.SetInt("TICK", tickValue);
      // PlayerPrefs.SetInt("ITEMS", count);

    }

    public void PurchasedItem()
    {
        if(click.points >= cost)
        {
            click.points -= cost;
            count++;
            cost = Mathf.Round (baseCost * Mathf.Pow(1.15f, count));
        }

    }




}
