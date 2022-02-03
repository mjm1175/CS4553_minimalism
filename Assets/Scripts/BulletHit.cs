using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletHit : MonoBehaviour
{
    PlaneMove _plane;
    // Start is called before the first frame update
    void Start()
    {
        _plane = FindObjectOfType<PlaneMove>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Obstacle")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            _plane.updateScore();
        }
    }
}
