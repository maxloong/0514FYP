using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BKShelfDisable : MonoBehaviour
{
    public GameObject DisableBKShelf;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            DisableBKShelf.SetActive(false);
        }
    }
}
