using UnityEngine;
using UnityEngine.InputSystem;

public class Movements : MonoBehaviour
{
	[SerializeField] float moveSpeed = 10f;
	[SerializeField] float jumpSpeed = 5f;
	
	Vector2 moveInput;
	Rigidbody2D myRigidbody;
	Animator myAnimator;

	void Start()
	{
		myRigidbody = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		Run();
	}
	void OnMove(InputValue value)
	{
		moveInput = value.Get<Vector2>();
	}

    void OnJump(InputValue value)
    {
	    
        if (value.isPressed);
	    {
		    myRigidbody.linearVelocity += new Vector2(0f, jumpSpeed);
	    }
    }
	void Run()
	{
	Vector2 playerVelocity = new Vector2(moveInput.x * moveSpeed, myRigidbody.linearVelocity.y);
	myRigidbody.linearVelocity = playerVelocity;
	}
	
	void FlipSprite()
	{
		bool hasHorizontalSpeed = Mathf.Abs(myRigidbody.linearVelocity.x) > Mathf.Epsilon;
		if (hasHorizontalSpeed)
		{
			transform.localScale = new Vector2(Mathf.Sign(myRigidbody.linearVelocity.x), 1f);
		}
	}
}
