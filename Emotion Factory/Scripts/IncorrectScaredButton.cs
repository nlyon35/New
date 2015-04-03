using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class IncorrectScaredButton : MonoBehaviour {

	public PhotonView phothonView;
	public RPC RPC;

	// Use this for initialization
	void Start () {
		Debug.Log("Used incorrect button!");
		Vector3 p = new Vector3(18,0,-1);
		GameObject player1prefab = PhotonNetwork.Instantiate("p1_sad_incorrect", p, Quaternion.identity, 0);
		PhotonView photonView = PhotonView.Get(this);
		Player2View();
	
	}

	[RPC]
	void Player2View()
	{
		GameObject player2prefab = PhotonNetwork.Instantiate("p2_sad_incorrect", Vector3.zero, Quaternion.identity, 0);
		PhotonView photonView = PhotonView.Get(this);
		Debug.Log("Player 2 incorrect wrong choice sprite rendering!");
	}
}
