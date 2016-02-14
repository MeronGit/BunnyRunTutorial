using UnityEngine;
using System.Collections;

public class JumpBunnyController : MonoBehaviour {

    private Rigidbody2D myRigidBunny;
    private Animator myAnimator;
    public float bunnyJumpForceShit = 500f;

	// Use this for initialization
	void Start () {
        myRigidBunny = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Jump with spacebar, unity keybindings
        if (Input.GetButtonUp("Jump"))
            {
            myRigidBunny.AddForce(transform.up * bunnyJumpForceShit);
            }
        //myAnimator.SetFloat("vVelocity", Mathf.Abs(myRigidBunny.velocity.y));
        myAnimator.SetFloat("vVelocity", myRigidBunny.velocity.y);
    }
}
