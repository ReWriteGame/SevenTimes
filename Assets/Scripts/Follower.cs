using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField]private Camera camera;

    [SerializeField] private Transform leftMaxShift;
    [SerializeField] private Transform rightMaxShift;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 position = camera.ScreenToWorldPoint(touch.position);

                if( position.x < rightMaxShift.position.x && position.x > leftMaxShift.position.x)
                    transform.position = new Vector2(position.x,  transform.position.y);
                //transform.position = position;
            }
        }
    }

    
}
