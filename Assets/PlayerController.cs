using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody2D theRB;
	public float speed;
	float directionX;
	float directionY;
	
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {	
        directionX = Input.GetAxisRaw("Horizontal");
        directionY = Input.GetAxisRaw("Vertical");
        
    	if ((Input.GetKey(KeyCode.LeftShift)) || (Input.GetKey(KeyCode.RightShift))) {
    		run();
    	} else {
    		walk();
    	}
    }
    
    void walk()
    {
    	theRB.velocity = new Vector2(directionX * speed, directionY * speed);
    }
    
    void run()
    {
    	theRB.velocity = new Vector2(directionX * speed * 2f, directionY * speed);
    	Debug.Log("run");
    }
}
