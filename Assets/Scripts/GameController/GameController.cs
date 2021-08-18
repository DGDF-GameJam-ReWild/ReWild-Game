using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController gameControllerInstance;


    private void Awake() 
    {
        gameControllerInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        TimeManager.instance.BeginTimer();
        CountdownTimer.instance.BeginCountdown(40f);
        // GetComponent<MonetizedMode>().enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
