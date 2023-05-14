using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float myTimer = 5;
    public Slider slider;
    public LineConnecter LC;
    public Transform resetPos1;
    public Transform resetPos2;
    public Transform Player1;
    public Transform Player2;
    public TimerReseter TR;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = myTimer;
        slider.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {  
       UpdateTime();
       if (myTimer == 0)
       {
            ResetPlayerPos();
            //TR.Timer.ResetMyTimer();
       }
    }

    public void UpdateTime()
    {
        if (myTimer > 0)
        {
            myTimer -= Time.deltaTime;
            slider.value = myTimer;
        }
        else
        {
            myTimer = 0;
        }
        slider.value = myTimer;
    }

    public void ResetPlayerPos()
    {
        Debug.Log("timer go zero");
        Player1.transform.position = resetPos1.position;
        Player2.transform.position = resetPos2.position;
    }

    public void ResetMyTimer()
    {
        myTimer = 5;
    }
}