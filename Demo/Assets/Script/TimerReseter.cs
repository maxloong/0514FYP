using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerReseter : MonoBehaviour
{
    public Timer Timer;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="PLayer")
        {
            Timer.ResetMyTimer();
            Debug.Log("Timer Reset");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer.ResetMyTimer();
        Debug.Log("Timer Reset");
    }
}
