﻿//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Timer : MonoBehaviour
//{
//    [SerializeField] Text timerText;
//    [SerializeField] public bool finished = false;
//    float startTime;
//    // Start is called before the first frame update
//    void Start()
//    {
//        startTime = Time.time;

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if(finished==true)
//        {
//            return;
//        }
//        else
//        {
//            float t = Time.time - startTime;
//            string minutes = ((int)t / 60).ToString();
//            string seconds = (t % 60).ToString("f2");
//            timerText.text = minutes + ":" + seconds;
//        }
//    }

//    public void Finish()
//    {
//        finished = true;
//    }
//}
