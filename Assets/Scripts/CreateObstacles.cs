using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacles : MonoBehaviour
{
    float lowRangeX = -8f;
    float highRangeX = 8f;
    float height = 5f;

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

    IEnumerator Create()
    {
        while (true)
        {
            float currX = Random.Range(lowRangeX, highRangeX);

            Instantiate(obstacle, new Vector3(currX, height, 0), transform.rotation);

            float timeBetween = Random.Range(0.5f, 4.0f);

            yield return new WaitForSeconds(timeBetween);
        }
    }
}
