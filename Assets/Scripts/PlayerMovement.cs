using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	public Vector3 input;
	public GameObject deathParlicles;
	public AudioClip[] audioClip;

	private Vector3 spawn;
	private Rigidbody rbody;
	private float maxSpeed = 16f;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
		spawn = transform.position;


	}
	
	// Update is called once per frame
	void Update () {

		input = new Vector3 (Input.GetAxisRaw("Horizontal"), 0 , Input.GetAxisRaw("Vertical"));

		if (rbody.velocity.magnitude < maxSpeed) 
		{
			rbody.AddRelativeForce(moveSpeed * input);
		}

		if (transform.position.y < 0) {
			Die ();
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "enemy") {
			PlaySound (1);
			//print ("I hit enemy");
			Die ();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "goal") {
			PlaySound (0);
			GameManager.CompleteLevel();
			print ("I hit goal");
		}
	}

	void Die()
	{
		Instantiate (deathParlicles, transform.position, Quaternion.Euler(270,0,0));
		transform.position = spawn;
		print ("I died");
	}

	void PlaySound(int clip)
	{
		GetComponent<AudioSource>().clip  = audioClip [clip];
		GetComponent<AudioSource> ().Play ();
	}
}
