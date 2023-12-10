using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public enum ObjeOnRoad
    {
        Stars,
        Beach,
        Sea,
        Wave,
        Night
    }
    public ObjeOnRoad currentObje;
    [SerializeField] private Vector3 startPos;
    [SerializeField] private float moveSpeed;
   
    void Start()
    {
        startPos = transform.localPosition;

        switch (currentObje)
        {
            case ObjeOnRoad.Stars:
                moveSpeed = .2f*2;
                break;
            case ObjeOnRoad.Beach:
                moveSpeed = 1.7f*2;
                break;
            case ObjeOnRoad.Wave:
                moveSpeed = 1*2;
                break;
            case ObjeOnRoad.Sea:
                moveSpeed = .4f*2;
                break;
            case ObjeOnRoad.Night:
                moveSpeed = .2f*2;
                break;
               }
    }

   
    void Update()
    {
 
        transform.Translate(-1 * moveSpeed * Time.deltaTime, 0f, 0f);

        if (transform.localPosition.x<=startPos.x-120)
        {
            transform.localPosition = new Vector3(startPos.x,transform.localPosition.y,transform.localPosition.z);
        }
       
    }
}
