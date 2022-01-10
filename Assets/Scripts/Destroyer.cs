using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destroyer : MonoBehaviour
{
    public UnityEvent takeBallEvent;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.GetComponent<Ball>())
            takeBallEvent?.Invoke();
    }
}
