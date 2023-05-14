using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScene : MonoBehaviour
{
   
    public void NextScene (string sceneName)
    { 
        Application.LoadLevel(sceneName);   
    }
}
