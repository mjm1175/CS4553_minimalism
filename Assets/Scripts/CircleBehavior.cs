using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBehavior : MonoBehaviour
{
    //this is goin ont he note not the button
    private bool onTop; // when the note is on the button
    // Start is called before the first frame update
    void Start()
    {
        onTop = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Circle")){
            onTop = true;
            print("colliding");
        }
    }*/

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Circle")){
            onTop = true;
            //print("colliding");
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Circle")){
            onTop = false;
        }        
    }
    /*private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Circle")){
            onTop = false;
        }
    }*/

    public void ButtonPress(){
        if (onTop){
            Destroy(gameObject);
        }
    }
}
