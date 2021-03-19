using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{

    PhotonView PV;

    [SerializeField] public Button[] characters;

    private Button lastClicked = null;

    private void Awake()
    {
        PV = GetComponent<PhotonView>();
    }


    [PunRPC]
    public void OnSelect(int id)
    {
        if (lastClicked != null)
        {
            lastClicked.interactable = true;
        }

        characters[id].interactable = false;
        lastClicked = characters[id];

    }

    public void OnClicked(int id)
    {
        PV.RPC("OnSelect", RpcTarget.All, id);
    }
}
