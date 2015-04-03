using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;


public class PhotonLobbyForQA : MonoBehaviour{
public Camera camera;
public Camera maincamera;
public Canvas canvas;
public SpriteRenderer spriteP2_1sc_1;
public SpriteRenderer spriteP1_1sc_1;
public PhotonView phothonView;

public RPC RPC;
public static int playerWhoIsIt = 0;


	void Start()
	{
		PhotonNetwork.ConnectUsingSettings("0.1");
		//player1avatar = gameobject.Find("player1avatar");
	}

	

	void OnJoinedLobby()
	{
		PhotonNetwork.JoinRandomRoom();
		//RoomOptions roomOptions = new RoomOptions() { isVisible = false, maxPlayers = 2 };
		//PhotonNetwork.JoinOrCreateRoom(nameEveryFriendKnows, roomOptions, TypedLobby.Default);
	}



	void OnPhotonRandomJoinFailed()
	{
		PhotonNetwork.CreateRoom(null);
		Debug.Log("Player1");
	}

	void OnJoinedRoom()
	{
		if (PhotonNetwork.playerList.Length == 1)
        {
			Debug.Log("Someone joined room!");
			Vector3 p = new Vector3(18,0,-7);
			Vector3 q = new Vector3(17,0,-1);
			Vector3 r = new Vector3(0,0,-2);
			GameObject player1prefab = PhotonNetwork.Instantiate("p1LeverPrefab", p, Quaternion.identity, 0);
			PhotonView photonView = PhotonView.Get(this);
			//p2_1 = GameObject.Find("player1prefab(Clone)").GetComponent<SpriteRenderer>();
			//p2_1.enabled = true;
			camera = GameObject.Find("p1LeverPrefab(Clone)").GetComponent<Camera>();
			camera.enabled = true;

			canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
			canvas.enabled = true;
			maincamera = GameObject.Find("Main Camera").GetComponent<Camera>();
			maincamera.enabled = false;

			GameObject p1_0_points = PhotonNetwork.Instantiate("p1_0_points", q, Quaternion.identity, 0);
			//myPhotonView = player1prefab.GetComponent<PhotonView>();

			// game logic: if this is the only player, we're "it"
        
            playerWhoIsIt = PhotonNetwork.player.ID;
            Debug.Log("playerWhoIsIt: " + playerWhoIsIt);
        }

        else 
        {
        	Debug.Log("ELSE playerWhoIsIt: " + playerWhoIsIt);
        	Player2View();
        }
        
	
	}



	[RPC]
	void Player2View()
	{
		GameObject player2prefab = PhotonNetwork.Instantiate("p2LeverPrefab", Vector3.zero, Quaternion.identity, 0);
		GameObject p2_0_points = PhotonNetwork.Instantiate("p2_0_points", Vector3.zero, Quaternion.identity, 0);
		//spriteP2_1sc_1 = GameObject.Find("p2LeverPrefab(Clone)").GetComponent<SpriteRenderer>();
		//spriteP2_1sc_1.enabled = true;
		Debug.Log("Player 2 wants to battle!");
	}
	

	



}
