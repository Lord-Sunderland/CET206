using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text pointsDisplay;
    public UnityEngine.UI.Text GPC;

    public float points = 0.00f;
    public float pointsperclick = 1;


    void Start()
    {
       // points = PlayerPrefs.GetFloat("POINTS", points);
       // pointsperclick = PlayerPrefs.GetFloat("PPC", pointsperclick);
    }


    void Update()
    {

        pointsDisplay.text = "Points " + points.ToString("F0");
        GPC.text = "Points per Click: " + pointsperclick;

        //   PlayerPrefs.SetFloat("POINTS", points);
        //  PlayerPrefs.SetFloat("PPC", pointsperclick);
    }


    public void Clicked()
    {
        points += pointsperclick;

     
    }










}