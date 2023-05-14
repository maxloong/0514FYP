using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineConnecter : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public LineRenderer LineRender;
    public bool isConnected = false;
    public GameObject Timer;

    // Start is called before the first frame update
    void Start()
    {
        LineRender.positionCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LineRender.SetPosition(0, pos1.position);
        LineRender.SetPosition(1, pos2.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            LineRender.positionCount = 2;
            isConnected = true;
            Timer.GetComponent<Timer>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LineRender.positionCount = 0;
            isConnected = false;
            Timer.GetComponent<Timer>().enabled = true;
            Timer.GetComponent<Timer>().UpdateTime();
        }
    }
}
