using UnityEngine;


public class PickRole : MonoBehaviour{

public PhotonView myPhotonView;
public int playerWhoIsIt;

void OnGUI()
	{
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());

        /*if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
        {
            bool shoutMarco = PlayerSetup.playerWhoIsIt == PhotonNetwork.player.ID;

            if (shoutMarco && GUILayout.Button("Marco!"))
            {
                myPhotonView.RPC("Marco", PhotonTargets.All);
            }
            if (!shoutMarco && GUILayout.Button("Polo!"))
            {
                myPhotonView.RPC("Polo", PhotonTargets.All);
            }
        }*/
    }

        [RPC]
    void TaggedPlayer(int playerID)
    {
        playerWhoIsIt = playerID;
        Debug.Log("TaggedPlayer: " + playerID);
    }
}