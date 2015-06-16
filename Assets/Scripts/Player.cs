using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed= 10.0f;
	public Animator animator;
	public int playerDirection = 1;
	// Use this for initialization
	void Start () {
	
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			animator.SetTrigger("Run");

		} else if (Input.GetKeyDown(KeyCode.Space))
		{
			// animator.SetTrigger("Idle");
			animator.SetTrigger("Attack");
		} else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			animator.SetTrigger("Jump");
		}

		//if (!Input.anyKeyDown) {
		//	animator.SetTrigger("Idle");
		//}
	}
	public void PrintResult()
	{
		Debug.Log ("Da vao day");
	}
}
