using UnityEngine;
using System.Collections;

public class TextOffsetScroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public float scrollSpeed = 0.2F;
	// Update is called once per frame
	void Update () {
		float offset = Time.time * scrollSpeed;
		GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	
	}
}
