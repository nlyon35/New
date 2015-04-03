using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class TryAgain : MonoBehaviour {

	public PhotonView phothonView;
	public RPC RPC;
	public SpriteRenderer sprite;
	public SpriteRenderer sprite2;

	// Use this for initialization
	void Start () {
		Debug.Log("Try again p1!");
		GameObject.Find("p1_happy_incorrect(Clone)").GetComponent<SpriteRenderer>();
		sprite.enabled = false;
		GameObject.Find("p1_sad_incorrect(Clone)").GetComponent<SpriteRenderer>();
		sprite.enabled = false;
		PhotonView photonView = PhotonView.Get(this);
		Player2View();
	
	}

	[RPC]
	void Player2View()
	{
		GameObject player2prefab = PhotonNetwork.Instantiate("p2_happy_incorrect", Vector3.zero, Quaternion.identity, 0);
		PhotonView photonView = PhotonView.Get(this);
		Debug.Log("Try again p2!");
	}
}