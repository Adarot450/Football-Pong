using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MoveBall : MonoBehaviour
{ 
    public float speed = 5;
    public Text scoreRightTXT;
    public Text scoreLeftTXT;
    int scoreRight;
    int scoreLeft;
    public Text Win;
    public static bool Player1Won;
    public static bool Player2Won;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    float hitfactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        //At the top of pong --> 1
        //At the mid of pong --> 0
        //At the bottem of pong --> -1
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // hit the left racket
        if (col.gameObject.name == "Left Player")
        {
            //calculate hit factor
            float y = hitfactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            //calculate direction make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            //make velocity dir*speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }


        //hit the right racket
        if(col.gameObject.name == "Right Player")
        {
            //calc hit factor
            float y = hitfactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            //calc direction make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            //make velocity dir*speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }


        if(col.gameObject.name == "Right Wall")
        {
            scoreLeft++;
            //conver int to string and put it in the text
            scoreLeftTXT.text = scoreLeft.ToString();
            //scoreLeftTXT.fontSize += 5;
            //scoreLeftTXT.color = Random.ColorHSV();
            transform.position = new Vector2(0, 0);

        }

        if (col.gameObject.name == "Left Wall")
        {
            scoreRight++;
            //convert int to string and put it in the text
            scoreRightTXT.text = scoreRight.ToString();
            //scoreRightTXT.fontSize += 5;
            //scoreRightTXT.color = Random.ColorHSV();
            transform.position = new Vector2(0, 0);
        }

        if (scoreLeft == Button.ScoreToBeat)
        {
            Player1Won = true;
            SceneManager.LoadScene("Win Scene");


            //Time.timeScale = 0;

            //Win.text = "Player1 Won";
        }

        if (scoreRight == Button.ScoreToBeat)
        {
            Player2Won = true;
            SceneManager.LoadScene("Win Scene");


            //Time.timeScale = 0;

            //Win.text = "Player2 Won";
        }

    }
}
