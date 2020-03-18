using UnityEngine;
using System.Collections;
public class Shooter : MonoBehaviour {
	public Rigidbody bullet;
	public float power = 1500f;
	public float moveSpeed = 2f;
	void Start () {}
	void Update () {
		if (Input.GetButtonUp ("Fire1")) {
		Rigidbody instance = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody;
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		instance.AddForce(fwd*power);
		}
	}
}