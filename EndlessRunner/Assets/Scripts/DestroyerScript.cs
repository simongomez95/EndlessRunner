using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {



	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Debug.Break ();
			return;
		} else if (other.tag == "Item") {
			Destroy(other.gameObject);
		}

//		if(other.gameObject.transform.parent) {
//			Destroy(other.gameObject.transform.parent.gameObject);
//		}
//		else {
//			Destroy(other.gameObject);
//		}
	}
}
