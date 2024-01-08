using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MonsterController : MonoBehaviour
{
    GameManager manager;
    Vector3 minPos,maxPos;
    // Start is called before the first frame update
    private void Awake()
    {
        manager = FindObjectOfType<GameManager>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.IsCorrect)
        {
            Vector3 targetPos = manager.player.transform.position;
            float duration = 8.0f;

          
            float step = Time.deltaTime / duration;
       
            transform.position = Vector3.Lerp(transform.position, targetPos, step);
        }
    }

}
