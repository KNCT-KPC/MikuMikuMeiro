using UnityEngine;
using System.Collections;

public class IdleRunJump : MonoBehaviour {


	protected Animator animator;
	public float DirectionDampTime = .25f;
	public bool ApplyGravity = true;
	private CharacterController controller; 


	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator>();
		
		if(animator.layerCount >= 2)
			animator.SetLayerWeight(1, 1);
		controller = GetComponent<CharacterController>();
	}
		
	// Update is called once per frame
	void Update () 
	{
		//Vector3 pos = transform.position;
		//pos.y = 0;
		//transform.position = pos;
		if (animator)
		{
			AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);			
			if (stateInfo.IsName("Base Layer.Run"))
			{
				if (Input.GetButton("Fire1")) {  
					animator.SetTrigger("Atack");           
				}
				
    		}
			else
			{
				animator.SetBool("Jump", false);                
            }
			if(Input.GetButtonDown("Fire2") && animator.layerCount >= 2)
			{
				animator.SetBool("Hi", !animator.GetBool("Hi"));
			}
			
		
      		float h = Input.GetAxis("Horizontal");
        	float v = Input.GetAxis("Vertical");
			
			animator.SetFloat("Speed", h*h+v*v);
            animator.SetFloat("Direction", h, DirectionDampTime, Time.deltaTime);
            if (h != 0 || v != 0)
    			controller.Move(transform.forward*Time.deltaTime);
    		}   		  
	}
	
	void OnControllerColliderHit(ControllerColliderHit other) {
		if (other.gameObject.tag == "Enemy") {
			Debug.Log("HIT");
		} 
	}
}
