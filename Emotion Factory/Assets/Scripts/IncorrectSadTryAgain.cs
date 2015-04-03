using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class IncorrectSadTryAgain : MonoBehaviour {

	public PhotonView phothonView;
	public RPC RPC;
	public SpriteRenderer spriteP1_1sc_1;
	public SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		Debug.Log("Try again p1!");
		spriteP1_1sc_1 = GameObject.Find("player1prefab(Clone)").GetComponent<SpriteRenderer>();
		spriteP1_1sc_1.enabled = true;
		PhotonView photonView = PhotonView.Get(this);
		Player2View();
	
	}

	[RPC]
	void Player2View()
	{
		sprite = GameObject.Find("p2_sad_incorrect(Clone)").GetComponent<SpriteRenderer>();
		sprite.enabled = false;
		PhotonView photonView = PhotonView.Get(this);
		Debug.Log("Try again p2!");
	}
}
