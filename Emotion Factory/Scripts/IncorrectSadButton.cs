using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class IncorrectSadButton : MonoBehaviour {

	public PhotonView phothonView;
	public RPC RPC;
	public SpriteRenderer spriteP1_1sc_1;
	public SpriteRenderer sprite_p1_incorrect;

	// Use this for initialization
	void Start () {
		Debug.Log("Used incorrect button!");
		Vector3 p = new Vector3(18,0,0);
		GameObject player1prefab = PhotonNetwork.Instantiate("p1_sadretry", p, Quaternion.identity, 0);
		sprite_p1_incorrect = GameObject.Find("p1_sadretry(Clone)").GetComponent<SpriteRenderer>();
		sprite_p1_incorrect.enabled = true;
		//spriteP1_1sc_1 = GameObject.Find("SpriteP1_1sc_1").GetComponent<SpriteRenderer>();
		//spriteP1_1sc_1.enabled = false;
		PhotonView photonView = PhotonView.Get(this);
		Player2View();
	
	}

	[RPC]
	void Player2View()
	{
		GameObject player2prefab = PhotonNetwork.Instantiate("p2_happy_incorrect", Vector3.zero, Quaternion.identity, 0);
		PhotonView photonView = PhotonView.Get(this);
		Debug.Log("Player 2 incorrect wrong choice sprite rendering!");
	}
}
