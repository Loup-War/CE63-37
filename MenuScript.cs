using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Transports.UNET;
using UnityEngine.UI;
using System;

public class MenuScript : MonoBehaviour
{
    public GameObject menuPanel;
    public InputField InputField;

    private void Start()
    {
        NetworkingManager.Singleton.ConnectionApprovalCallback += ApprovalCheck;
    }

    private void ApprovalCheck(byte[] ConnectionData, ulong clientID, NetworkingManager.ConnectionApprovedDelegate callback)
    {
        bool approve = false;
        String password = System.Text.Encoding.ASCII.GetString(ConnectionData);
        if (password == "mygame")
        {
            approve = true ;
        }
        Debug.Log($"Approval:{approve}");
        callback(true, null, approve,new Vector3(0, 10, 0), Quaternion.identity);
    }

    public void Host()
    {
        NetworkingManager.Singleton.StartHost();
        menuPanel.SetActive(false);
    }

    public void Join()

    {
        if (InputField.text.Length<=0)
        {
            NetworkingManager.Singleton.GetComponent<UnetTransport>().ConnectAddress = "192.168.1.39";
        }
        else
        {
            NetworkingManager.Singleton.GetComponent<UnetTransport>().ConnectAddress =  InputField.text;
        }
        NetworkingManager.Singleton.NetworkConfig.ConnectionData = System.Text.Encoding.ASCII.GetBytes("mygame");
        NetworkingManager.Singleton.StartClient();
        menuPanel.SetActive(false);

    }


}