using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

    Rigidbody2D rbody;
    Animator animator;
    public float speed;


	// Use this for initialization
	void Start () {

        rbody = GetComponent<Rigidbody2D> ();
        animator = GetComponent<Animator> ();

            
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movement_vector != Vector2.zero)
        {
            animator.SetBool("isWalking", true);
            animator.SetFloat("Input_x", movement_vector.x);
            animator.SetFloat("input_y", movement_vector.y);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime * speed);

    }
}
