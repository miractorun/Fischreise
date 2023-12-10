using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = .5f;
    [SerializeField] private float offset;
    //[SerializeField] private Material backgroundMaterial;

    private void Start()
    {
      //  backgroundMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    private void Update()
    {
        offset += (scrollSpeed * Time.deltaTime)/10;
        transform.position = new Vector2(transform.position.x + offset, transform.position.y);
        //backgroundMaterial.SetTextureOffset("_MainTex", new Vector2(offset, 0));   //bu ne ?
        
    }
}
