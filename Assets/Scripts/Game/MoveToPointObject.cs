using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPointObject : MonoBehaviour
{
    [SerializeField] private Transform pointOne;
    [SerializeField] private Transform pointTwo;
    [SerializeField] private float speed = 10;
    private Coroutine currentCoroutine = null;

    public void MoveToPointOne(float speed = -1)
    {
        if (speed == -1) speed = this.speed;
        if(currentCoroutine != null)StopCoroutine(currentCoroutine);
        currentCoroutine = StartCoroutine(MoveOverSpeedCor(transform,pointOne.position,speed) );
    }
    public void MoveToPointTwo(float speed = -1)
    {
        if (speed == -1) speed = this.speed;
        if(currentCoroutine != null)StopCoroutine(currentCoroutine);
        currentCoroutine = StartCoroutine(MoveOverSpeedCor(transform,pointTwo.position,speed) );
    }

    public IEnumerator MoveOverSpeedCor(Transform objectToMove, Vector3 end, float speed)
    {
        // speed should be 1 unit per second
        while (objectToMove.position != end)
        {
            objectToMove.position = Vector3.MoveTowards(objectToMove.position, end, speed * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
        objectToMove.position = end;
    }
}
