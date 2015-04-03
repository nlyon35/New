using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class NextLoad1 : MonoBehaviour {

public Canvas canvas;
public Canvas origpanel;
public Canvas newCanvas;
public SpriteRenderer spriteP2;
public SpriteRenderer spriteP1;
public SpriteRenderer spriteP1_1sc_1;
public Camera camera;
public Camera camera2;
public PhotonView photonView;
public PhotonView scriptPhotonView;
public PhotonView canvasPhotonView;

public RPC RPC;


	void Start()
	{	

		//scriptPhotonView = GameObject.Find("NextLoad1Script").GetComponent<PhotonView>();
		Vector3 p = new Vector3(36,0,-7);
		Vector3 q = new Vector3(36,0,-1);
		Vector3 r = new Vector3(0,0,-2);
		//GameObject p1_1sc_2h_speaker = PhotonNetwork.Instantiate("p1_1sc_2h_speaker", p, Quaternion.identity, 0);
		//GameObject p1_0_points = PhotonNetwork.Instantiate("p1_0_points", q, Quaternion.identity, 0);
		//camera = GameObject.Find("player1prefab(Clone)").GetComponent<Camera>();
		//camera.enabled = false;
		//PhotonView photonView = PhotonView.Get(this);

    	origpanel = GameObject.Find("Canvas").GetComponent<Canvas>();
		origpanel.enabled = false;
		GameObject player2canvas = PhotonNetwork.Instantiate("Canvas2", r, Quaternion.identity, 0);

		newCanvas = GameObject.Find("Canvas2(Clone)").GetComponent<Canvas>();
		newCanvas.enabled = false;

		//Player2CallPanel(PhotonTargets.MasterClient);  
		Player2CallPanel();  

		//original canvas instantiation plan

		//canvas = GameObject.Find("Canvas2(Clone)").GetComponent<Canvas>();
		//canvas.enabled = false;
		//canvas2 object plan
		//canvas = GameObject.Find("Canvas2").GetComponent<Canvas>();
		//canvas.enabled = false;

  

		/*//destructionSection
		GameObject destroyThis = GameObject.Find("p1_0_points(Clone)");
		PhotonNetwork.Destroy(destroyThis.GetComponent<PhotonView>());
		GameObject destroyThat = GameObject.Find("p1_scared_correct(Clone)");
		PhotonNetwork.Destroy(destroyThat.GetComponent<PhotonView>());
		GameObject destroyAnother = GameObject.Find("player1prefab(Clone)");
		PhotonNetwork.Destroy(destroyAnother.GetComponent<PhotonView>());*/

		Debug.Log("Next Load Start Happened");

	
	}



	[RPC]
	void Player2CallPanel()
	{	

		Debug.Log(PhotonNetwork.playerList);

		Vector3 r = new Vector3(0,0,-2);
		//original canvas instantiation plan

		GameObject p2_1sc_2h_listener = PhotonNetwork.Instantiate("p2_1sc_2h_listener", r, Quaternion.identity, 0);


		//canvasPhotonView = GameObject.Find("Canvas2(Clone)").GetComponent<PhotonView>();
		//canvas = GameObject.Find("Canvas2(Clone)").GetComponent<Canvas>();
		//canvas.enabled = false;

		//canvasPhotonView = GameObject.Find("Canvas").GetComponent<PhotonView>();
		//origpanel = GameObject.Find("Canvas").GetComponent<Canvas>();
		//origpanel.enabled = true;
		//canvas2 object plan
		//canvas = GameObject.Find("Canvas2").GetComponent<Canvas>();
		//canvas.enabled = true;

		/*//destructionSection
		GameObject destroyThis = GameObject.Find("p2_0_points(Clone)");
		PhotonNetwork.Destroy(destroyThis.GetComponent<PhotonView>());
		GameObject destroyThat = GameObject.Find("p2_scared_correct(Clone)");
		PhotonNetwork.Destroy(destroyThat.GetComponent<PhotonView>());*/
		//GameObject destroyAnother = GameObject.Find("player2prefab(Clone)");
		//PhotonNetwork.Destroy(destroyAnother.GetComponent<PhotonView>());
		//camera = GameObject.Find("player1prefab(Clone)").GetComponent<Camera>();
		//camera.enabled = false;
		//camera2 = GameObject.Find("p1_1sc_2h_speaker(Clone)").GetComponent<Camera>();
		//camera2.enabled = false;

		Debug.Log("Next Load RPC Happened");
	}
	

	



}
