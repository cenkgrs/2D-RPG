using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody2D theRB;
	public float speed;
	float directionX;
	float directionY;
	
	public Animator animator;
	
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {	
        directionX = Input.GetAxisRaw("Horizontal");
        directionY = Input.GetAxisRaw("Vertical");
        
        // Set last turned location
        if (directionX == 1 || directionX == -1 || directionY == 1 || directionY == -1) {
    		animator.SetFloat("lastMoveX", directionX);
			animator.SetFloat("lastMoveY", directionY);
		}
        
    	if ((Input.GetKey(KeyCode.LeftShift)) || (Input.GetKey(KeyCode.RightShift))) {
    		animator.SetFloat("moveX", theRB.velocity.x);
    		animator.SetFloat("moveY", theRB.velocity.y * 2f);

    		
    		run();
    	} else {
    		animator.SetFloat("moveX", theRB.velocity.x);
    		animator.SetFloat("moveY", theRB.velocity.y);
    		
    		walk();
    	}
    }
    
    void walk()
    {
    	theRB.velocity = new Vector2(directionX * speed, directionY * speed);
    }
    
    void run()
    {
    	theRB.velocity = new Vector2(directionX * speed * 2f, directionY * speed * 2f);
    }
}
