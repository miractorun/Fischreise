using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 minPos, maxPos;
    [SerializeField] float time;
    // Start is called before the first frame update
    void Start()
    {
        minPos = transform.GetChild(transform.childCount - 1).transform.position;
        maxPos = transform.GetChild(transform.childCount - 2).transform.position;

        LeanTween.moveLocalY(gameObject, minPos.y, time)
            .setOnComplete(OnTweenCompleteMin);
    }



    void OnTweenCompleteMin()
    {
        LeanTween.moveLocalY(gameObject, maxPos.y, time)
            .setOnComplete(OnTweenCompleteMax);
        
    }

    void OnTweenCompleteMax()
    {
        LeanTween.moveLocalY(gameObject, minPos.y, time)
            .setOnComplete(OnTweenCompleteMin);
    }
}
