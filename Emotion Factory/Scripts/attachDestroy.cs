using UnityEngine;
using System.Collections;

public class attachDestroy : MonoBehaviour {

	PhotonView myPhotonView;

	// Use this for initialization
	void Start () {
		myPhotonView = GetComponent<PhotonView>();
	}

	[RPC]
	void CommitSuicide() {
		PhotonNetwork.Destroy(myPhotonView);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
