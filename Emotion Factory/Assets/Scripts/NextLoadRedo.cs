using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class NextLoadRedo : MonoBehaviour {

public Canvas canvas;
public Canvas panel;
public SpriteRenderer spriteP2;
public SpriteRenderer spriteP1;
public SpriteRenderer spriteP1_1sc_1;
public Camera camera;
public Camera camera2;
public PhotonView phothonView;

public RPC RPC;


	void Start()
	{
		Vector3 p = new Vector3(36,0,-7);
		Vector3 q = new Vector3(36,0,-1);
		GameObject p1_1sc_2h_speaker = PhotonNetwork.Instantiate("p1_1sc_2h_speaker", p, Quaternion.identity, 0);
		GameObject p1_0_points = PhotonNetwork.Instantiate("p1_0_points", q, Quaternion.identity, 0);
		camera = GameObject.Find("player1prefab(Clone)").GetComponent<Camera>();
		camera.enabled = false;
		PhotonView photonView = PhotonView.Get(this);
		Player2View();        
		canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
		canvas.enabled = false;
	
	}



	[RPC]
	void Player2View()
	{
		Vector3 r = new Vector3(0,0,-2);
		GameObject p2_1sc_2h_listener = PhotonNetwork.Instantiate("p2_1sc_2h_listener", Vector3.zero, Quaternion.identity, 0);
		panel = GameObject.Find("Canvas").GetComponent<Canvas>();
		panel.enabled = true;
		GameObject player2canvas = PhotonNetwork.Instantiate("Canvas2", r, Quaternion.identity, 0);
		canvas = GameObject.Find("Canvas2(Clone)").GetComponent<Canvas>();
		canvas.enabled = true;
		camera = GameObject.Find("player1prefab(Clone)").GetComponent<Camera>();
		camera.enabled = false;
		camera2 = GameObject.Find("p1_1sc_2h_speaker(Clone)").GetComponent<Camera>();
		camera2.enabled = false;
	}
	

	



}
