﻿using UnityEngine;
using System.Collections;
public class Transport : OVRMonoscopic
    
{
    public Transform startPos, endPos;
    //public bool repeatable = false;
    public float speed = 1.0f;
    public float duration = 3.0f;
    float startTime, totalDistance;
    IEnumerator Start()
    {
        startTime = Time.time;
        totalDistance = Vector3.Distance(startPos.position, endPos.position);
        /// while (repeatable)//Maybe could be to move back to the sun or something]
        {
            //     yield return RepeatLerp(startPos.position, endPos.position, duration);
            //     yield return RepeatLerp(endPos.position, startPos.position, duration);
            yield return null;
        }
    }
    void Update()
    {
        //if (!repeatable)
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton4))
            {
                float currentDuration = (Time.time - startTime) * speed;
                float journeyFraction = currentDuration / totalDistance;
                transform.position = Vector3.Lerp(startPos.position, endPos.position, journeyFraction);
            }
        }
    }
    //  public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time)
    // {
    //     float i = 0.0f;
    //      float rate = (1.0f / time) * speed;
    //      while (i < 1.0f)
    //      {
    //        i += Time.deltaTime * rate;
    //        this.transform.position = Vector3.Lerp(a, b, i);
    //       yield return null;
    // }
    //}
}