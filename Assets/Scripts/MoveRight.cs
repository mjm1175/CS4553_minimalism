using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 startPos;
    public Vector3 endPos;
    private bool isMoving;
    public float speed = 5.0f;
    void Start()
    {
        startPos = transform.position;
        StartCoroutine(Move());
        isMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        print(isMoving);
        if (!isMoving){
            Destroy(gameObject);
        }
    }

    IEnumerator Move(){
        float timeElapsed = 0.0f;
        while (timeElapsed < 1.0){
            transform.position = Vector3.Lerp(startPos, endPos, timeElapsed);
            timeElapsed += Time.deltaTime * (1.0f/speed);
            yield return null;
        }
        isMoving = false;
        //Destroy(gameObject);
    }
}
