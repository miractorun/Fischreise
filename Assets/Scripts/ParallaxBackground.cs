using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private Transform cam;
    [SerializeField] private Vector3 startPos;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
        //moveSpeed = .5f;
    }

    // Update is called once per frame
    void Update()
    {
 
        transform.Translate(-1 * moveSpeed * Time.deltaTime, 0f, 0f);

        if (transform.localPosition.x<=startPos.x-120)
        {
            transform.localPosition = new Vector3(startPos.x,transform.localPosition.y,transform.localPosition.z);
            Debug.Log("asda");
        }
        if (cam.position.x >= transform.position.x + 120) 
        {
            Debug.Log("aa");
            cam.position = new Vector2(transform.position.x + 120f, transform.position.y);
        }
    }
}
