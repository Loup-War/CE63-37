using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Photon.Realtime;
using System.Linq;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public static NetworkManager Instance;
    [SerializeField] TMP_InputField roomName;
    [SerializeField] TMP_Text errorText;
    [SerializeField] TMP_Text roomnameText;
    [SerializeField] GameObject roomListPrefab;
    [SerializeField] Transform roomListContent;
    [SerializeField] GameObject playerListPrefab;
    [SerializeField] Transform playerListContent;
    [SerializeField] GameObject startGame;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }


    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to master");
        PhotonNetwork.JoinLobby();
        PhotonNetwork.AutomaticallySyncScene = true;

    }

    public override void OnJoinedLobby()
    {
        MenuManager.Instance.OpenMenu("title");
        Debug.Log("Joined Suc");
        PhotonNetwork.NickName = "Player " + Random.Range(0, 100).ToString("000");
    }

    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(roomName.text))
        {
            return;
        }
        PhotonNetwork.CreateRoom(roomName.text);
        MenuManager.Instance.OpenMenu("loading");

    }

    public void JoinRoom(RoomInfo info)
    {
        PhotonNetwork.JoinRoom(info.Name);
        MenuManager.Instance.OpenMenu("loading");
    }


    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        MenuManager.Instance.OpenMenu("loading");
    }

    public void StartGame()
    {
        PhotonNetwork.LoadLevel(1);
    }


    public override void OnJoinedRoom()
    {
        MenuManager.Instance.OpenMenu("room");
        roomnameText.text = PhotonNetwork.CurrentRoom.Name;
       

        Player[] players = PhotonNetwork.PlayerList;
        foreach(Transform child in playerListContent)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < players.Count(); i++)
        {
            Instantiate(playerListPrefab, playerListContent).GetComponent<PlayerList>().SetUp(players[i]);
        }
        startGame.SetActive(PhotonNetwork.IsMasterClient);

    }

    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        startGame.SetActive(PhotonNetwork.IsMasterClient);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        errorText.text = "Create Failed : " + message;
        MenuManager.Instance.OpenMenu("error");
    }
    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach (Transform trans in roomListContent)
        {
            Destroy(trans.gameObject);
        }

        for (int i = 0; i < roomList.Count; i++)
        {
            if (roomList[i].RemovedFromList)
                continue;
            Instantiate(roomListPrefab, roomListContent).GetComponent<RoomList>().SetUp(roomList[i]);
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Instantiate(playerListPrefab, playerListContent).GetComponent<PlayerList>().SetUp(newPlayer);
    }
}
