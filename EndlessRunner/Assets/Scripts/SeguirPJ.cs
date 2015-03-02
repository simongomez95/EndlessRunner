using UnityEngine;
using System.Collections;

public class SeguirPJ : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (player.position.x + 1, transform.position.y, transform.position.z);
	
	}
}
