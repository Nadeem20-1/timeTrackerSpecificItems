using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class stopwatch : MonoBehaviour
{
    private float ctscanCurrentTime = 0;
    private float mriCurrentTime = 0;
    private float orCurrentTime = 0;
    private float radiologyCurrentTime = 0;
    private float ultrasoundCurrentTime = 0;

    public Text ctscanTimeText;
    public Text mriTimeText;
    public Text orTimeText;
    public Text radiologyTimeText;
    public Text ultrasoundTimeText;

    public Text currentRoom;
    private string sceneName;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sceneName = currentRoom.text;
        switch (sceneName)
        {
            case "ct":
                ctscanCurrentTime += Time.deltaTime;
                TimeSpan time = TimeSpan.FromSeconds(ctscanCurrentTime);
                ctscanTimeText.text = time.ToString(@"mm\:ss\:fff");
                break;
            case "mri":
                mriCurrentTime += Time.deltaTime;
                TimeSpan time1 = TimeSpan.FromSeconds(mriCurrentTime);
                mriTimeText.text = time1.ToString(@"mm\:ss\:fff");
                break;
            case "or":
                orCurrentTime += Time.deltaTime;
                TimeSpan time2 = TimeSpan.FromSeconds(orCurrentTime);
                orTimeText.text = time2.ToString(@"mm\:ss\:fff");
                break;
            case "radiology":
                radiologyCurrentTime += Time.deltaTime;
                TimeSpan time3 = TimeSpan.FromSeconds(radiologyCurrentTime);
                radiologyTimeText.text = time3.ToString(@"mm\:ss\:fff");
                break;
            case "ultrasound":
                ultrasoundCurrentTime += Time.deltaTime;
                TimeSpan time5 = TimeSpan.FromSeconds(ultrasoundCurrentTime);
                ultrasoundTimeText.text = time5.ToString(@"mm\:ss\:fff");
                break;
            default:
                break;
        }
    }
}
