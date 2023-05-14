using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeLvOpener : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public GameObject LvCamera;
    public GameObject Player1;
    public GameObject Player2;
    public LineRenderer Line;
    public GameObject TimerUI;
    public GameObject Timer;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            camera1.enabled = false;
            camera2.enabled = false;
            LvCamera.SetActive(true);
            Player1.GetComponent<SphereCollider>().enabled = true;
            Player1.GetComponent<FPSController>().mouseSensitivity = 0;
            Player1.GetComponent<LineConnecter>().enabled = true;
            Player2.GetComponent<FPSController2>().mouseSensitivity = 0;
            Player2.GetComponent<LineConnecter>().enabled = true;
            Line.enabled = true;
            TimerUI.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            camera1.enabled = true;
            camera2.enabled = true;
            LvCamera.SetActive(false);
            Player1.GetComponent<SphereCollider>().enabled = false;
            Player1.GetComponent<FPSController>().mouseSensitivity = 11;
            Player1.GetComponent<LineConnecter>().enabled = false;
            Player2.GetComponent<FPSController2>().mouseSensitivity = 11;
            Player2.GetComponent<LineConnecter>().enabled = false;
            Line.enabled = false;
            TimerUI.SetActive(false);
            Timer.GetComponent<Timer>().enabled = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
