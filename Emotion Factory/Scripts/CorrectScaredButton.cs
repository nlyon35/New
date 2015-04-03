using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
public class CorrectScaredButton : MonoBehaviour {

	public PhotonView phothonView;
	public RPC RPC;
	public SpriteRenderer spritep0points;
	public Canvas panel;

	// Use this for initialization
	void Start () {
		Debug.Log(PhotonNetwork.playerList);
		Debug.Log("Used correct button!");
		Vector3 p = new Vector3(18,0,0);
		Vector3 q = new Vector3(17,0,-1);
		GameObject player1prefab = PhotonNetwork.Instantiate("p1_scared_correct", p, Quaternion.identity, 0);
		GameObject p1points = PhotonNetwork.Instantiate("p1_1_points", q, Quaternion.identity, 0);
		spritep0points = GameObject.Find("p1_0_points(Clone)").GetComponent<SpriteRenderer>();
		spritep0points.enabled = false;
		GameObject emptypoints = GameObject.Find("p1_0_points(Clone)");
		PhotonNetwork.Destroy (emptypoints);
		PhotonView photonView = PhotonView.Get(this);
		photonView.RPC("Player2View", PhotonTargets.Others);
		//Player2View();
	
	}

	[RPC]
	void Player2View()
	{
		Vector3 r = new Vector3(0,0,-2);


		GameObject player2prefab = PhotonNetwork.Instantiate("p2_scared_correct", Vector3.zero, Quaternion.identity, 0);
		GameObject p2points = PhotonNetwork.Instantiate("p2_1_points", r, Quaternion.identity, 0);
		spritep0points = GameObject.Find("p1_0_points(Clone)").GetComponent<SpriteRenderer>();
		spritep0points.enabled = false;
		GameObject emptypoints = GameObject.Find("p1_0_points(Clone)");
		PhotonNetwork.Destroy (emptypoints);

		panel = GameObject.Find("Canvas").GetComponent<Canvas>();
		panel.enabled = true;
		PhotonView photonView = PhotonView.Get(this);
		Debug.Log("Player 2 correct choice sprite rendering!");
	}
}