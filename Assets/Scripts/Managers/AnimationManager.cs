using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : InstanceManager<AnimationManager>
{
    GameManager manager;
    public Animator monsterAnim;
    public Animator playerAnim;

    private void Awake()
    {
        manager = FindObjectOfType<GameManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.IsCorrect)
        {
            monsterAnim.SetBool("IsFight", true);
        }
    }
}
