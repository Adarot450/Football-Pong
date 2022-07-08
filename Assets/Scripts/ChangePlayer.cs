using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public GameObject TopWall;
    public GameObject LeftWall;
    public GameObject BotWall;
    public GameObject RightWall;
    public GameObject Player1Logo;
    public GameObject Player2Logo;
    public GameObject leftPlayer;
    public GameObject RightPlayer;
    public Sprite TAA;
    public Sprite Ronaldo;
    public Sprite Maguire;
    public Sprite Messi;
    public Sprite VVD;
    public Sprite Zlatan;
    public Sprite LiverPool;
    public Sprite RealMadrid;
    public Sprite ManUTD;
    public Sprite Barca;
    public Sprite Milan;

    void Awake()
    {
        //For Player1
        if (Button.Player1 == "TAA")
        {
            //set sprite
            leftPlayer.GetComponent<SpriteRenderer>().sprite = TAA;
            //set size
            leftPlayer.GetComponent<Transform>().localScale = new Vector3(-0.15f, 0.15f, 1);
            //reset collider
            Destroy(leftPlayer.GetComponent<PolygonCollider2D>());
            leftPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            TopWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            LeftWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            //change logo
            Player1Logo.GetComponent<SpriteRenderer>().sprite = LiverPool;
        }

        if (Button.Player1 == "Ronaldo")
        {
            //set sprite
            leftPlayer.GetComponent<SpriteRenderer>().sprite = Ronaldo;
            //set size
            leftPlayer.GetComponent<Transform>().localScale = new Vector3(-0.12f, 0.12f, 1);
            //reset collider
            Destroy(leftPlayer.GetComponent<PolygonCollider2D>());
            leftPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            TopWall.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            LeftWall.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            //change logo
            Player1Logo.GetComponent<SpriteRenderer>().sprite = RealMadrid;
        }
        if (Button.Player1 == "Maguire")
        {
            //set sprite
            leftPlayer.GetComponent<SpriteRenderer>().sprite = Maguire;
            //set size
            leftPlayer.GetComponent<Transform>().localScale = new Vector3(-0.8f, 0.8f, 1);
            //reset collider
            Destroy(leftPlayer.GetComponent<PolygonCollider2D>());
            leftPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            TopWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            LeftWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            //change logo sprite and size  .6
            Player1Logo.GetComponent<SpriteRenderer>().sprite = ManUTD;
            Player1Logo.GetComponent<Transform>().localScale = new Vector3(0.6f, 0.6f, 1);
        }
        if (Button.Player1 == "Messi")
        {
            //set sprite
            leftPlayer.GetComponent<SpriteRenderer>().sprite = Messi;
            //set size
            leftPlayer.GetComponent<Transform>().localScale = new Vector3(-0.85f, 0.85f, 1);
            //reset collider
            Destroy(leftPlayer.GetComponent<PolygonCollider2D>());
            leftPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            TopWall.GetComponent<SpriteRenderer>().color = new Color(0.8745098f, 0.8156863f, 0.2666667f);
            LeftWall.GetComponent<SpriteRenderer>().color = new Color(0.8745098f, 0.8156863f, 0.2666667f);
            //change logo
            Player1Logo.GetComponent<SpriteRenderer>().sprite = Barca;
        }
        if (Button.Player1 == "VVD")
        {
            //set sprite
            leftPlayer.GetComponent<SpriteRenderer>().sprite = VVD;
            //set size
            leftPlayer.GetComponent<Transform>().localScale = new Vector3(-0.43f, 0.43f, 1);
            //reset collider
            Destroy(leftPlayer.GetComponent<PolygonCollider2D>());
            leftPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            TopWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            LeftWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            //change logo
            Player1Logo.GetComponent<SpriteRenderer>().sprite = LiverPool;
        }
        if (Button.Player1 == "Zlatan")
        {
            //set sprite
            leftPlayer.GetComponent<SpriteRenderer>().sprite = Zlatan;
            //set size
            leftPlayer.GetComponent<Transform>().localScale = new Vector3(0.13f, 0.13f, 1);
            //reset collider
            Destroy(leftPlayer.GetComponent<PolygonCollider2D>());
            leftPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            TopWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            LeftWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            //change logo sprite and size
            Player1Logo.GetComponent<SpriteRenderer>().sprite = Milan;
            Player1Logo.GetComponent<Transform>().localScale = new Vector3(0.3f, 0.3f, 1);
        }

        //For Player2

        if (Button.Player2 == "TAA")
        {
            //set sprite
            RightPlayer.GetComponent<SpriteRenderer>().sprite = TAA;
            //set size
            RightPlayer.GetComponent<Transform>().localScale = new Vector3(0.15f, 0.15f, 1);
            //reset collider
            Destroy(RightPlayer.GetComponent<PolygonCollider2D>());
            RightPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            BotWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            RightWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            //change logo
            Player2Logo.GetComponent<SpriteRenderer>().sprite = LiverPool;
        }

        if (Button.Player2 == "Ronaldo")
        {
            //set sprite
            RightPlayer.GetComponent<SpriteRenderer>().sprite = Ronaldo;
            //set size
            RightPlayer.GetComponent<Transform>().localScale = new Vector3(0.12f, 0.12f, 1);
            //reset collider
            Destroy(RightPlayer.GetComponent<PolygonCollider2D>());
            RightPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            BotWall.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            RightWall.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            //change logo
            Player2Logo.GetComponent<SpriteRenderer>().sprite = RealMadrid;
        }
        if (Button.Player2 == "Maguire")
        {
            //set sprite
            RightPlayer.GetComponent<SpriteRenderer>().sprite = Maguire;
            //set size
            RightPlayer.GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 1);
            //reset collider
            Destroy(RightPlayer.GetComponent<PolygonCollider2D>());
            RightPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            BotWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            RightWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            //change logo sprite and size  .6
            Player2Logo.GetComponent<SpriteRenderer>().sprite = ManUTD;
            Player2Logo.GetComponent<Transform>().localScale = new Vector3(0.6f, 0.6f, 1);
        }
        if (Button.Player2 == "Messi")
        {
            //set sprite
            RightPlayer.GetComponent<SpriteRenderer>().sprite = Messi;
            //set size
            RightPlayer.GetComponent<Transform>().localScale = new Vector3(0.85f, 0.85f, 1);
            //reset collider
            Destroy(RightPlayer.GetComponent<PolygonCollider2D>());
            RightPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            BotWall.GetComponent<SpriteRenderer>().color = new Color(0.8745098f, 0.8156863f, 0.2666667f);
            RightWall.GetComponent<SpriteRenderer>().color = new Color(0.8745098f, 0.8156863f, 0.2666667f);
            //change logo
            Player2Logo.GetComponent<SpriteRenderer>().sprite = Barca;
        }
        if (Button.Player2 == "VVD")
        {
            //set sprite
            RightPlayer.GetComponent<SpriteRenderer>().sprite = VVD;
            //set size
            RightPlayer.GetComponent<Transform>().localScale = new Vector3(0.43f, 0.43f, 1);
            //reset collider
            Destroy(RightPlayer.GetComponent<PolygonCollider2D>());
            RightPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            BotWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            RightWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            //change logo
            Player2Logo.GetComponent<SpriteRenderer>().sprite = LiverPool;
        }
        if (Button.Player2 == "Zlatan")
        {
            //set sprite
            RightPlayer.GetComponent<SpriteRenderer>().sprite = Zlatan;
            //set size
            RightPlayer.GetComponent<Transform>().localScale = new Vector3(-0.13f, 0.13f, 1);
            //reset collider
            Destroy(RightPlayer.GetComponent<PolygonCollider2D>());
            RightPlayer.AddComponent<PolygonCollider2D>();
            //change wall color
            BotWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            RightWall.GetComponent<SpriteRenderer>().color = new Color(0.9294118f, 0.2196079f, 0.2f);
            //change logo sprite and size
            Player2Logo.GetComponent<SpriteRenderer>().sprite = Milan;
            Player2Logo.GetComponent<Transform>().localScale = new Vector3(0.3f, 0.3f, 1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
