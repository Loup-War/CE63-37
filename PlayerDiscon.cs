using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerDiscon : MonoBehaviour
{
    PhotonView PV;
    public GameObject player1, player2, player3, player4 ,player;
    public GameObject invetory;
    public bool lastp1, lastp2;
    void Start()
    {
        PV = GetComponent<PhotonView>();
    }


    void Update()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player3 = GameObject.FindGameObjectWithTag("Player3");
        player4 = GameObject.FindGameObjectWithTag("Player4");
        if(player == null)
        {
            if(player1.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player1");
            }
            else if (player2.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player2");
            }
            else if (player3.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player3");
            }
            else if (player4.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player4");
            }
        }

        if (player3 != null && player4 == null)
        {
            ThreePlayer();
        }
        else if (player4 != null)
        {
            FourPlayer();
        }
        else if(player.GetComponent<PlayMoment>().guild != "")
        {
            TwoPlayer();
        }
    }
    void TwoPlayer()
    {
        if (player1 == null)
        {
            player2.GetComponent<PlayMoment>().playerlastone = true;
            Debug.Log("Player 2 Win");
            lastp2 = true;

        }
        else if (player2 == null)
        {
            player1.GetComponent<PlayMoment>().playerlastone = true;
            Debug.Log("Player 1 Win");
            lastp1 = true;
        }
        else if (player1.GetComponent<PhotonView>().IsMine == true && player1.GetComponent<PlayerMoney>().money == 0 && invetory.GetComponent<Inventory>().weightall == 0)
        {
            player2.GetComponent<PlayMoment>().playerlastone = true;
            Debug.Log("Player 2 Win");
            lastp2 = true;
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && player2.GetComponent<PlayerMoney>().money == 0 && invetory.GetComponent<Inventory>().weightall == 0)
        {
            player2.GetComponent<PlayMoment>().playerlastone = true;
            Debug.Log("Player 1 Win");
            lastp2 = true;
        }
    }

    void ThreePlayer()
    {
        if (player1 == null)
        {
            Debug.Log("Player 1 Lose");
            player2.tag = "Player1";
            player3.tag = "Player2";
        }
        else if (player2 == null)
        {
            Debug.Log("Player 2 Lose");
            player3.tag = "Player2";
        }
        else if (player3 == null)
        {
            Debug.Log("Player 3 Lose");
            Destroy(player3);
        }
        else if (player1.GetComponent<PhotonView>().IsMine == true && player1.GetComponent<PlayerMoney>().money <= 0 && invetory.GetComponent<Inventory>().weightall <= 0)
        {
            Debug.Log("Player 1 Lose");
            player2.tag = "Player1";
            player3.tag = "Player2";
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && player2.GetComponent<PlayerMoney>().money <= 0 && invetory.GetComponent<Inventory>().weightall <= 0)
        {
            Debug.Log("Player 2 Lose");
            player3.tag = "Player2";
        }
        else if (player3.GetComponent<PhotonView>().IsMine == true && player3.GetComponent<PlayerMoney>().money <= 0 && invetory.GetComponent<Inventory>().weightall <= 0)
        {
            Debug.Log("Player 3 Lose");
            Destroy(player3);
        }
    }

    void FourPlayer()
    {
        if (player1 == null)
        {
            Debug.Log("Player 1 Lose");
            player2.tag = "Player1";
            player3.tag = "Player2";
            player4.tag = "Player3";
        }
        else if (player2 == null)
        {
            Debug.Log("Player 2 Lose");
            player3.tag = "Player2";
            player4.tag = "Player3";
        }
        else if (player3 == null)
        {
            Debug.Log("Player 3 Lose");
            player4.tag = "Player3";
        }
        else if (player4 == null)
        {
            Destroy(player4);
        }
        else if (player1.GetComponent<PhotonView>().IsMine == true && player1.GetComponent<PlayerMoney>().money <= 0 && invetory.GetComponent<Inventory>().weightall <= 0)
        {
            Debug.Log("Player 1 Lose");
            player2.tag = "Player1";
            player3.tag = "Player2";
            player4.tag = "Player3";
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && player2.GetComponent<PlayerMoney>().money <= 0 && invetory.GetComponent<Inventory>().weightall <= 0)
        {
            Debug.Log("Player 2 Lose");
            player3.tag = "Player2";
            player4.tag = "Player3";
        }
        else if (player3.GetComponent<PhotonView>().IsMine == true && player3.GetComponent<PlayerMoney>().money <= 0 && invetory.GetComponent<Inventory>().weightall <= 0)
        {
            Debug.Log("Player 3 Lose");
            player4.tag = "Player3";
        }
        else if (player4.GetComponent<PhotonView>().IsMine == true && player4.GetComponent<PlayerMoney>().money <= 0 && invetory.GetComponent<Inventory>().weightall <= 0)
        {
            Destroy(player4);
        }
    }

}