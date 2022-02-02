using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 startPos;
    private Vector3 endPos;
    private bool isMoving;
    public float speed = 1.0f;
    void Start()
    {
        startPos = transform.position;
        endPos.x = startPos.x;
        endPos.z = startPos.z;
        endPos.y = startPos.y + 7.61f;

        isMoving = true;
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        //print(isMoving);
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
