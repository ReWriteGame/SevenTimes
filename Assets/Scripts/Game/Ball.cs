using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.GetComponent<Platform>())
            gameObject.GetComponent<Destroyable>().Destroy();
    }
}
