﻿using UnityEngine;
using System.Collections;

public class MoveTowards : MonoBehaviour {
	public Transform target;
	public float speed;
	void Update() {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}
