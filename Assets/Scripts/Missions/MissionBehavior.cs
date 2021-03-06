using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    string stageType;
    string missionDetails;
    bool timedMission;
    bool runningTimer;
    public float timeAvailable;
    bool updateTimer;
    float time;


    // Start is called before the first frame update, set the proper variables for the mission
    void Start()
    {
        SetMissionDetails(missionDetails);
        SetMissionTimeType(updateTimer);
        if (timedMission)
        {
            SetTime(time);
        }
    }

    //Set the available time for the mission
    private void SetTime(float timer)
    {
        timeAvailable = timer;
    }

    //Set the mission details for the mission
    private void SetMissionDetails(string details)
    {
        missionDetails = details;
    }
    //Determine if the mission is timed or not.
    private void SetMissionTimeType(bool timeType)
    {
        timedMission = timeType;
        runningTimer = timeType;

    }

    // Update is called once per frame
    void Update()
    {
        if (timedMission && runningTimer)
        {
            if (timeAvailable > 0)
            {
                timeAvailable -= Time.deltaTime;
            }

            else
            {
                Debug.Log("You've run out of time!");
                timeAvailable = 0;
                runningTimer = false;

            }
        }

    }
}