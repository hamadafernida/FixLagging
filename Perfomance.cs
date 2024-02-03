using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perfomance : MonoBehaviour
{
    void Awake()
    {
        #if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
        #else
                Debug.unityLogger.logEnabled = false;
        #endif

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 61;

        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
