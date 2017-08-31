using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCubeBehaviour : MonoBehaviour {

	public float radius = 1;
	public float speed;
	public float offset;

	private float rotateAngle;

	void Awake () {
		rotateAngle = offset;
	}
	
	void Update () {
		transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Cos(rotateAngle) * radius, Mathf.Sin(rotateAngle) * radius);
		rotateAngle += speed * Time.deltaTime;
	}
}
