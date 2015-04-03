using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class IncorrectHappyTryAgain : MonoBehaviour {

	public PhotonView phothonView;
	public RPC RPC;
	public SpriteRenderer sprite;
	public SpriteRenderer spriteP1_1sc_1;
	public GameObject gameObject;
	public GameObject gameObject2;
	public SpriteRenderer p2sprite;
	public SpriteRenderer spriteP2_1sc_1v2;
	public SpriteRenderer player1prefabv2;
	//public Script script;
	public GameObject spriteGO;

	// Use this for initialization
	void Start () {
		Debug.Log("Try again p1!");
		Vector3 p = new Vector3(18,0,-7);
		//sprite = GameObject.Find("p1_happy_incorrect(Clone)").GetComponent<SpriteRenderer>();
		//sprite.enabled = false;
		spriteP1_1sc_1 = GameObject.Find("SpriteP1_1sc_1").GetComponent<SpriteRenderer>();
		spriteP1_1sc_1.enabled = true;
		spriteGO = GameObject.Find("SpriteP1_1sc_1");
		spriteGO.SetActive(true);
		//if(GameObject.Find("p1_happy_incorrect(Clone)"))
		//{
		//	Destroy(gameObject.p1_happy_incorrect(Clone));
		//}
		//script = GameObject.Find("p1_happy_incorrect(Clone)").GetComponent<Script>();
		//script.enabled = true;
		gameObject = GameObject.Find("p1_happy_incorrect(Clone)");
		Destroy(gameObject);

		//GameObject player1prefab = PhotonNetwork.Instantiate("player1prefabv2", p, Quaternion.identity, 0);
		//player1prefabv2 = GameObject.Find("player1prefabv2(Clone)").GetComponent<SpriteRenderer>();
		//player1prefabv2.enabled = true;

		PhotonView photonView = PhotonView.Get(this);
		Player2View();
	
	}

	[RPC]
	void Player2View()
	{
		sprite = GameObject.Find("p2_happy_incorrect(Clone)").GetComponent<SpriteRenderer>();
		sprite.enabled = false;

		gameObject2 = GameObject.Find("p2_happy_incorrect(Clone)");
		Destroy(gameObject2);

		GameObject player2prefab = PhotonNetwork.Instantiate("player2prefabv2", Vector3.zero, Quaternion.identity, 0);
		spriteP2_1sc_1v2 = GameObject.Find("player2prefabv2(Clone)").GetComponent<SpriteRenderer>();
		spriteP2_1sc_1v2.enabled = true;

		PhotonView photonView = PhotonView.Get(this);
		Debug.Log("Try again p2!");
	}

}
