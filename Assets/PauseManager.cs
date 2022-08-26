using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public void pauseOn()
    {
        Time.timeScale = 0;
    }
    
    public void pauseOff()
    {
        Time.timeScale = 1;
    }
}
