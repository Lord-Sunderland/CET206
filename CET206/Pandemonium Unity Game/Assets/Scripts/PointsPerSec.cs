using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsPerSec : MonoBehaviour {

    public UnityEngine.UI.Text ppsDisplay;
    public Click click;
    public ItemManager[] items;


    private void Start()
    {
        StartCoroutine(AutoTick());
        
    }

    private void Update()
    {
        ppsDisplay.text = "Points per sec: " + GetPointsPerSec();
    }



    public float GetPointsPerSec()
    {
        float tick = 0;

        foreach(ItemManager item in items)
        {
            tick += item.count * item.tickValue;
        }




        return tick;
    }


    public void AutoPointsPerSec()
    {
        click.points += GetPointsPerSec() / 10;

    }

    IEnumerator AutoTick()
    {
        while (true)
        {

            AutoPointsPerSec();
            yield return new WaitForSeconds(0.10f);
        }

    }




}
