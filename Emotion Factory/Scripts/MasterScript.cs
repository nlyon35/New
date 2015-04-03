using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

/*
button correct
	public instacnatscrpt;
	THESCRIPT.changeViewOfCurrentPlayer1a()
	THESCRIPT.THEphotonview.rpc("changeViewOfCurrentPlayer1b", OTHER)
	




another script called THESCRIPT
void changeViewOfCurrentPlayer1a
public THEphotonview

	Destroy(dsadsa)	
	Instanciet(dsfsads)
	Instanciet(dsfsads)
	Instanciet(dsfsads)

void changeViewOfOtherPlayer()
	Destroy(dsadsa)	
	Instanciet(dsfsads)
	Instanciet(dsfsads)
	Instanciet(dsfsads)

Individual button script
	public instantiatescript;

	MasterScript.changeViewOfCurrentPlayerScaredCorrect1a();
	MasterScript.photonView.rpc("changeViewOfOtherPlayerScaredCorrect1b", PhotonTargets.Others);

	*/


public class MasterScript : MonoBehaviour {

	public PhotonView photonView;

	public void changeViewOfCurrentPlayerScaredCorrect1a() {
		Debug.Log("MasterScript IS actually getting called");
		Vector3 p = new Vector3(18,0,0);

		//Destroy
		GameObject origP1Sprite = GameObject.Find("SpriteP1_1sc_1");
		Destroy (origP1Sprite);
		//GameObject origP1SpritePrefab = GameObject.Find("player1prefab(Clone)");
		//Destroy (origP1SpritePrefab);
		//Instantiate
		//GameObject p1ScaredCorrect = (GameObject)Resources.Load("p1_scared_correct", typeof (GameObject)); 
		//GameObject newObj = Instantiate(p1ScaredCorrect, p, Quaternion.identity) as GameObject;
		GameObject p1ScaredCorrect = Instantiate(Resources.Load("p1_scared_correct"),p , Quaternion.identity) as GameObject;
	}

	[RPC]
	public void changeViewOfOtherPlayerScaredCorrect1b() {




		//Destroy
		GameObject origP2Sprite = GameObject.Find("player2prefab(Clone)");
		Destroy (origP2Sprite);



		//Instantiate

		GameObject p2ScaredCorrect = Instantiate(Resources.Load("p2_scared_correct")) as GameObject;

		//PhotonView[] nViews = p2ScaredCorrect.GetComponentsInChildren<PhotonView>();
    	//nViews[0].viewID = 2;

	}
}