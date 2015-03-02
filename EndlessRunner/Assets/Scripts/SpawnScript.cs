using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public Transform player;

	// Use this for initialization
	void Start () {

		Invoke ("Spawn",2);
	
	}
	
	// Update is called once per frame
	void Spawn () {
		//Instantiate(obj[Random.Range (0, obj.GetLength(0))], transform.position, Quaternion.identity);
		//while(spawnMin == 1) {
		//para baron y torre Instantiate(obj[Random.Range (0,obj.GetLength(0))],new Vector3(player.position.x + 15.316,-2.2f,0), Quaternion.identity);
		Instantiate(obj[Random.Range (0,obj.Length)],new Vector3(player.position.x + 15.316f,-2.2f,0), Quaternion.identity); //Instancia hongo
		Invoke("Spawn",Random.Range (0.3f,1f));

		//}

		//Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	
	}
}
