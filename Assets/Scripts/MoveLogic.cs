using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoveLogic : MonoBehaviour
{
    [SerializeField] private MoveToPointObject move;
    [SerializeField] private Vector2 timeChangeDirection;
    [SerializeField] private Vector2 randomSpeed;

    private Coroutine currentCoroutine = null;
  
    public void StartMove()
    {
        currentCoroutine = StartCoroutine(ChangeMoveObjectCor());
    }
    public void StopMove()
    {
        if(currentCoroutine != null)StopCoroutine(currentCoroutine);
    }

    public IEnumerator ChangeMoveObjectCor()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(timeChangeDirection.x, timeChangeDirection.y));
            if((int)Random.Range(0,2) == 1)move.MoveToPointOne(Random.Range(randomSpeed.x,randomSpeed.y));
            else move.MoveToPointTwo(Random.Range(randomSpeed.x,randomSpeed.y));
        }
    }
}
