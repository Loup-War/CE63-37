using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Photon.Pun;

public class PlayMoment : TacticsMove
{
    PhotonView pv;
    public GameObject p1, p2, p3, p4;
    public bool playerlastone;

    public Camera camera1;
    void Start()
    {
        Init();
        pv = PhotonView.Get(this);

    }

    void Update()
    {
        p1 = GameObject.FindGameObjectWithTag("Player1");
        p2 = GameObject.FindGameObjectWithTag("Player2");
        p3 = GameObject.FindGameObjectWithTag("Player3");
        p4 = GameObject.FindGameObjectWithTag("Player4");
     
        if (!turn)
        {
            return;
        }
        if (!moving)
        {
            FindSelectableTiles();
            CheckMouse();
        }
        else
        {
            Move();

        }
    }
    void CheckMouse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = camera1.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Tile")
                {
                    Tile t = hit.collider.GetComponent<Tile>();

                    if (t.selectable)
                    {
                        MoveToTile(t);
                    }
                }
            }
        }
    }
   

    public void sharingGuild()
    {
        if (pv.IsMine == true && pv.ViewID > 1000 && pv.ViewID < 2000)
        {
            pv.RPC("RPCguildSelectedP1", RpcTarget.All, guildConfirm);
        }
        else if (pv.IsMine == true && pv.ViewID > 2000 && pv.ViewID < 3000)
        {
            pv.RPC("RPCguildSelectedP2", RpcTarget.All, guildConfirm);
        }
        else if (pv.IsMine == true && pv.ViewID > 3000 && pv.ViewID < 4000)
        {
            pv.RPC("RPCguildSelectedP3", RpcTarget.All, guildConfirm);
        }
        else if (pv.IsMine == true && pv.ViewID > 4000 && pv.ViewID < 5000)
        {
            pv.RPC("RPCguildSelectedP4", RpcTarget.All, guildConfirm);
        }
    }

    [PunRPC]
    void RPCguildSelectedP1(string guildshar1)
    {
        p1.GetComponent<PlayMoment>().guild = guildshar1;

    }
    [PunRPC]
    void RPCguildSelectedP2(string guildshar2)
    {
        p2.GetComponent<PlayMoment>().guild = guildshar2;

    }
    [PunRPC]
    void RPCguildSelectedP3(string guildshar3)
    {
        p3.GetComponent<PlayMoment>().guild = guildshar3;

    }
    [PunRPC]
    void RPCguildSelectedP4(string guildshar4)
    {
        p4.GetComponent<PlayMoment>().guild = guildshar4;

    }
}
