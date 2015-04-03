using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class IncorrectHappyButton : MonoBehaviour {

	public PhotonView phothonView;
	public RPC RPC;
	//public SpriteRenderer spriteP1_1sc_1;
	public GameObject spriteP1_1sc_1;
	public SpriteRenderer sprite_p1_incorrect;
	public SpriteRenderer spriteplayer1prefab;
	public SpriteRenderer spriteplayer1prefab1;

	// Use this for initialization
	void Start () {
		Vector3 p = new Vector3(18,0,0);

		GameObject player1prefab = PhotonNetwork.Instantiate("p1_happy_incorrect", p, Quaternion.identity, 0);
		Debug.Log("Used incorrect button!");

		if (GameObject.Find("p1_happy_incorrect(Clone)") == false)
		{
		GameObject player1prefab1 = PhotonNetwork.Instantiate("p1_happy_incorrect", p, Quaternion.identity, 0);
		//spriteP1_1sc_1 = GameObject.Find("SpriteP1_1sc_1");
		//spriteP1_1sc_1.SetActive(false);
		}


		sprite_p1_incorrect = GameObject.Find("p1_happy_incorrect(Clone)").GetComponent<SpriteRenderer>();
		sprite_p1_incorrect.enabled = true;
		//spriteP1_1sc_1 = GameObject.Find("SpriteP1_1sc_1").GetComponent<SpriteRenderer>();
		//spriteP1_1sc_1.enabled = false;
		spriteplayer1prefab = GameObject.Find("player1prefab(Clone)").GetComponent<SpriteRenderer>();
		spriteplayer1prefab.enabled = false;
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
