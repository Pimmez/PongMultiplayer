using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class BallController : NetworkBehaviour {

	[SerializeField] private GameObject ballPrefab;
	[SerializeField] private float BallSpeed = 18;
	[SerializeField] private float MaxBallSpeed = 30;

	private Rigidbody rigid;

	void Start()
	{
		rigid = GetComponent<Rigidbody> ();
		GetComponent<Rigidbody> ().velocity = Vector3.right * BallSpeed;
	}

	float hitFactor(Vector3 Ballpos, Vector3 Racketpos, float RacketHeight)
	{
		return (Ballpos.y - Racketpos.y) / RacketHeight;
	}

	void Update()
	{

		if (BallSpeed >= MaxBallSpeed) 
		{
			BallSpeed = MaxBallSpeed;
		}

	}

	void OnCollisionExit(Collision col)
	{

		BallSpeed = BallSpeed + 0.2f;

		rigid.velocity = rigid.velocity.normalized * BallSpeed;
	}

	void OnConnectedToServer()
	{
		Network.Instantiate (ballPrefab, transform.position, transform.rotation, 0);
	}
		
}