﻿using UnityEngine;
using System.Collections;

public class LeverSwapPanel2Panel3 : MonoBehaviour {

	public PhotonView phothonView;
	public RPC RPC;
	public SpriteRenderer p2Sprite;
	public GameObject gameObject;

	// Use this for initialization
	void Start () {
		Vector3 p = new Vector3(18,0,-7);
		Vector3 q = new Vector3(17,0,-1);
		Vector3 r = new Vector3(0,0,-2);
		GameObject p1_1_points = PhotonNetwork.Instantiate("p1_2_points", q, Quaternion.identity, 0);



		PhotonView photonView = PhotonView.Get(this);

//Find what I wanna destroy
		GameObject destroyThis = GameObject.Find("p1_1_points(Clone)");
		PhotonNetwork.Destroy(destroyThis.GetComponent<PhotonView>());
		//destroyThis.GetComponent<PhotonView>().RPC("CommitSuicide", PhotonTargets.All);
		//Send an RPC call to CommitSuicide on that object
		Player2View();
	}

	[RPC]
	void Player2View(){
		//p2Sprite = GameObject.Find("SpriteP2ReadyS").GetComponent<SpriteRenderer>();
		//p2Sprite.enabled = false;
		//PhotonNetwork.Destroy("p2_0_points");
		GameObject p2_1_points = PhotonNetwork.Instantiate("p2_2_points", Vector3.zero, Quaternion.identity, 0);
		//GameObject player2prefab = PhotonNetwork.Instantiate("p2LeverReadyS", Vector3.zero, Quaternion.identity, 0);

		GameObject destroyThis = GameObject.Find("p2_1_points(Clone)");
		PhotonNetwork.Destroy(destroyThis.GetComponent<PhotonView>());

		PhotonView photonView = PhotonView.Get(this);
		//gameObject = GameObject.Find("SpriteP2ReadyS");
		//gameObject.SetActive(true);

	}
	
}