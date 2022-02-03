using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlaneMove : MonoBehaviour
{
    public GameObject restartMenu;
    public GameObject bullet;
    public Transform spawnPoint;
    public TextMeshProUGUI bulletLabel;
    public TextMeshProUGUI bulletText;
    public TextMeshProUGUI scoreLabel;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalText;
    int currBulletCount = 0;
    int currScore = 0;

    float distance = 16;
    float speed = .3f;
    float startX;

    void Start()
    {
        startX = transform.position.x;
        restartMenu.SetActive(false);
        StartCoroutine(AddBullet());
    }

    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x = Mathf.SmoothStep(startX, startX + distance, Mathf.PingPong(Time.time * speed, 1));
        transform.position = newPosition;

        if (Input.GetKeyDown("f"))
        {
            if (currBulletCount > 0)
            {
                Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                --currBulletCount;
                bulletText.text = currBulletCount.ToString();
            }
        }
    }

    // IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    // {
    //     var i = 0.0f;
    //     var rate = 1.0f / time;
    //     while (i < 1.0f)
    //     {
    //         i += Time.deltaTime * rate;
    //         thisTransform.position = Vector3.Lerp(startPos, endPos, i);
    //         yield return null;
    //     }
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {

            ObstacleColor obsColor = other.GetComponent<ObstacleColor>();

            // TODO: DECIDE IF THIS MAKES SENSE TO INCLUDE
            // keeping you from dying if obstacle is too low to shoot
            //if (other.transform.position.y >= -2.06f){
            if (obsColor.dangerous)
            {
                gameObject.SetActive(false);
                bulletLabel.gameObject.SetActive(false);
                bulletText.gameObject.SetActive(false);
                scoreLabel.gameObject.SetActive(false);
                scoreText.gameObject.SetActive(false);
                restartMenu.SetActive(true);

                finalText.text = currScore.ToString();
                //}                
            }
        }
    }

    IEnumerator AddBullet()
    {
        while (true)
        {
            ++currBulletCount;
            bulletText.text = currBulletCount.ToString();
            yield return new WaitForSeconds(3f);
        }
    }

    public void updateScore()
    {
        currScore += 10;
        scoreText.text = currScore.ToString();
    }
}