using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class LeaveGame : MonoBehaviour
{
    public void Click_LeaveRoom()
    {
        StartCoroutine(DisconnectAndLoad());
    }

    IEnumerator DisconnectAndLoad()
    {
        PhotonNetwork.Disconnect();
        PhotonNetwork.LeaveRoom();
        while (PhotonNetwork.IsConnected)
            yield return null;
        SceneManager.LoadScene("Lobby");
    }

    public void Click_ExitGame()
    {
        Application.Quit();
    }
}
