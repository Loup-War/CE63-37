using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Turnmanager : MonoBehaviour
{
    PhotonView PV;
    public bool player1, player2, player3, player4;
    public MainEventSys endRound;

    private void Start()
    {
        PV = GetComponent<PhotonView>();
        endRound = GameObject.FindObjectOfType<MainEventSys>();

        player1 = true;
        player2 = false;
        player3 = false;
        player4 = false;
    }
    public void updateTurn1()
    {
        //Debug.Log(" Updated TURN1");
        updateTurn2(player1, player2, player3, player4);
    }

    public void updateTurn2(bool player1, bool player2, bool player3, bool player4)
    {
        //Debug.Log(" Updated TURN2");
        PV.RPC("RPC_UpdateTurn", RpcTarget.AllBuffered, player1, player2, player3, player4);
    }

    [PunRPC]
    void RPC_UpdateTurn(bool player1New, bool player2New, bool player3New, bool player4New)
    {
        //Debug.Log(" Updated TURN3");

        player1 = player1New;
        player2 = player2New;
        player3 = player3New;
        player4 = player4New;
    }
}
