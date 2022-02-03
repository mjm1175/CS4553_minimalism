using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
    public GameObject restartMenu;
    // Start is called before the first frame update
    void Start()
    {
        restartMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Obstacle")){

            ObstacleColor obsColor = other.GetComponent<ObstacleColor>();

            // TODO: DECIDE IF THIS MAKES SENSE TO INCLUDE
            // keeping you from dying if obstacle is too low to shoot
                //if (other.transform.position.y >= -2.06f){
            if (obsColor.dangerous){

                gameObject.SetActive(false);

                restartMenu.SetActive(true);                
                //}                
            }
        }
    }
}
