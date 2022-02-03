using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleColor : MonoBehaviour
{
    public bool dangerous = false;      // orange when true, yellow when false
    private SpriteRenderer thisRenderer;
    // Start is called before the first frame update
    void Start()
    {
        thisRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(CycleColors());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CycleColors(){
        while (true){
            if (dangerous){
                thisRenderer.color = new Color(0.973f,1.0f,0.0f,1.0f);
                dangerous = false;
            } else {
                thisRenderer.color = new Color(1.0f,0.616f,0.0f,1.0f);
                dangerous = true;
            }
            yield return new WaitForSeconds(2.0f);
        }
    }
}
