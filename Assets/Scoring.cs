using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static int scorep1;
    public static int scorep2;

    // Start is called before the first frame update
    void Start()
    {
        scorep1 = 0;
        scorep2 = 0;
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10,200, 30), "Chosen One: " + scorep1);
        GUI.Box(new Rect(Screen.width-200, 10, 200, 30), "Betty Aka Master Pain: " + scorep2);
    }

}
