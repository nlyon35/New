using UnityEngine;
using System.Collections;

public class LeverFailureScript : MonoBehaviour {

	public PhotonView phothonView;
	public RPC RPC;
	public SpriteRenderer p2Sprite;
	public GameObject gameObject;

	// Use this for initialization
	void Start () {

	Player2View();
	}

	[RPC]
	void Player2View(){
		//p2Sprite = GameObject.Find("SpriteP2Failure").GetComponent<SpriteRenderer>();
		//p2Sprite.enabled = false;
		GameObject player2prefab = PhotonNetwork.Instantiate("p2Failure", Vector3.zero, Quaternion.identity, 0);
		PhotonView photonView = PhotonView.Get(this);
		//gameObject = GameObject.Find("SpriteP2Failure");
		//gameObject.SetActive(true);

	}
	
}