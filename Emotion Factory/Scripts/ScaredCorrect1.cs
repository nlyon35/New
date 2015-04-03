using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ScaredCorrect1 : MonoBehaviour {

	public GameObject g;

	// Use this for initialization
	void Start () {


	//MasterScript.changeViewOfCurrentPlayerScaredCorrect1a();
	//MasterScript.photonView.rpc("changeViewOfOtherPlayerScaredCorrect1b", PhotonTargets.Others);
	
	g.GetComponent<MasterScript>().changeViewOfCurrentPlayerScaredCorrect1a();
	Debug.Log("dalalala");

	PhotonView photonView = GameObject.Find("Scripts").GetComponent<PhotonView>();
	photonView.RPC("changeViewOfOtherPlayerScaredCorrect1b()", PhotonTargets.Others);

	//photonView.RPC("g.GetComponent<MasterScript>changeViewOfOtherPlayerScaredCorrect1b()", PhotonTargets.Others);

	//g.GetComponent<MasterScript>().changeViewOfOtherPlayerScaredCorrect1b();
	
	}

}
