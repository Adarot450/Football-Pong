using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public float speed = 10;
    public string axis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis) * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,v); 
    }
}
