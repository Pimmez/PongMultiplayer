using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour {

	[SerializeField] private float Sensentivity = 20;
	//private SpawnPoint spawnpoint;

	void Start()
	{
		//spawnpoint = GetComponent<SpawnPoint>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		
		if (!isLocalPlayer)
		{
			return;
		}

		float v = Input.GetAxisRaw("Vertical");
		GetComponent<Rigidbody>().velocity = new Vector3(0, 0, v) * Sensentivity;
	
	}

		//Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		//transform.position = new Vector3 (transform.position.x, 0f, ray.GetPoint (Sensentivity).z);

	public override void OnStartLocalPlayer()
	{
		//spawnpoint.Spawn ();
		GetComponent<MeshRenderer> ().material.color = Color.yellow;
	}

}
