using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacles : MonoBehaviour
{
    private float lowRangeX = -7.36f;
    private float highRangeX = 7.39f;
    private Vector3 rangeRange = new Vector3(0.0f, 4.64f, 0.0f);

    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Create(){
        while(true)
        {
            float thisX = Random.Range(lowRangeX, highRangeX);

            Instantiate(obstacle, new Vector3(thisX, rangeRange.y, rangeRange.z), transform.rotation);

            float timeBetween = Random.Range(1.0f, 5.0f);

            yield return new WaitForSeconds(timeBetween);
        }
    }
}
