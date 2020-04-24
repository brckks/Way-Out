using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public Transform[] enemyPoints;
	public float moveSpeed = 1f;

	private int currentPoint=0;

	// Use this for initialization
	void Start () {
		transform.position = enemyPoints [0].position;

	}
	
	// Update is called once per frame
	void Update () {


		if(transform.position == enemyPoints[currentPoint].position)
		{
			currentPoint++;
		}

		if (currentPoint >= enemyPoints.Length) 
		{
			currentPoint = 0;
		}

		transform.position = Vector3.MoveTowards (transform.position, enemyPoints[currentPoint].position, moveSpeed * Time.deltaTime);
		
	}
}
