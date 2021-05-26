using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class miniEvent : MonoBehaviour
{

    public GameObject OBMINIEvent1, OBMINIEvent2, OBMINIEvent3, OBMINIEvent4, OBMINIEvent5, OBMINIEvent6;

    public GameObject player1, player2, player3, player4;
    public GameObject player;
    public int RanDomEvent;
    public float money;
    public int RandomNum;
    public MainEventSys EventShuffleCard;
    public int SolidierTurn = 0;
    public int TurnCount;

    private void Start()
    {
        EventShuffleCard = GameObject.FindObjectOfType<MainEventSys>();

    }


    public void OnTriggerEnter(Collider col)
    {
        
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player3 = GameObject.FindGameObjectWithTag("Player3");
        player4 = GameObject.FindGameObjectWithTag("Player4");
        if (player1.GetComponent<PhotonView>().IsMine == true)
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

        money = player.GetComponent<PlayerMoney>().money;
        if (col.gameObject.tag == "Player1" && player1.GetComponent<PhotonView>().IsMine == true)
        {
            RanDomEvent = Random.Range(1, 5);
            {
                if (RanDomEvent == 1)
                {
                    if (player.GetComponent<PlayMoment>().soldierGuard == 1)
                    {
                        Debug.Log("ป้องกันการโดนปล้นได้เพราะมีทหารคุ้มกัน");
                        OBMINIEvent1.SetActive(true);
                    }
                    else
                    {
                        OBMINIEvent2.SetActive(true);
                        Debug.Log("โดนโจรปล้น");
                        player.GetComponent<PlayerMoney>().money = (money - (money * 0.2f));
                    }
                }
                else if (RanDomEvent == 2)
                {
                    OBMINIEvent3.SetActive(true);

                    Debug.Log("NoProble");
                }
                else if (RanDomEvent == 3)
                {
                    OBMINIEvent4.SetActive(true);

                    Debug.Log("A fallen tree blocking the way");
                    player.GetComponent<PlayMoment>().move = 0;
                    EventShuffleCard.PathValue();

                }
                else if (RanDomEvent == 4)
                {
                    Debug.Log("Special offer");
                    RandomNum = Random.Range(1, 3);
                    if (RandomNum == 1)
                    {
                        OBMINIEvent5.SetActive(true);
                        Debug.Log("Ture");
                        player.GetComponent<PlayerMoney>().money += 100;
                        EventShuffleCard.EventShuffle();
                    }
                    else
                    {
                        OBMINIEvent6.SetActive(true);
                        Debug.Log("False");
                        player.GetComponent<PlayerMoney>().money -= 200;
                    }
                }
            }
        }
        else if (col.gameObject.tag == "Player2" && player2.GetComponent<PhotonView>().IsMine == true)
        {
            RanDomEvent = Random.Range(1, 5);
            {
                if (RanDomEvent == 1)
                {


                    if (player.GetComponent<PlayMoment>().soldierGuard == 1)
                    {
                        Debug.Log("ป้องกันการโดนปล้นได้เพราะมีทหารคุ้มกัน");
                        OBMINIEvent1.SetActive(true);
                    }
                    else
                    {
                        OBMINIEvent2.SetActive(true);
                        Debug.Log("โดนโจรปล้น");
                        player.GetComponent<PlayerMoney>().money = (money - (money * 0.2f));
                    }
                }
                else if (RanDomEvent == 2)
                {
                    OBMINIEvent3.SetActive(true);

                    Debug.Log("NoProble");
                }
                else if (RanDomEvent == 3)
                {
                    OBMINIEvent4.SetActive(true);

                    Debug.Log("A fallen tree blocking the way");
                    player.GetComponent<PlayMoment>().move = 0;
                    EventShuffleCard.PathValue();

                }
                else if (RanDomEvent == 4)
                {
                    Debug.Log("Special offer");
                    RandomNum = Random.Range(1, 3);
                    if (RandomNum == 1)
                    {
                        OBMINIEvent5.SetActive(true);
                        Debug.Log("Ture");
                        player.GetComponent<PlayerMoney>().money += 100;
                        EventShuffleCard.EventShuffle();
                    }
                    else
                    {
                        OBMINIEvent6.SetActive(true);
                        Debug.Log("False");
                        player.GetComponent<PlayerMoney>().money -= 200;
                    }
                }
            }
        }
        else if (col.gameObject.tag == "Player3" && player3.GetComponent<PhotonView>().IsMine == true)
        {
            RanDomEvent = Random.Range(1, 5);
            {
                if (RanDomEvent == 1)
                {


                    if (player.GetComponent<PlayMoment>().soldierGuard == 1)
                    {
                        Debug.Log("ป้องกันการโดนปล้นได้เพราะมีทหารคุ้มกัน");
                        OBMINIEvent1.SetActive(true);
                    }
                    else
                    {
                        OBMINIEvent2.SetActive(true);
                        Debug.Log("โดนโจรปล้น");
                        player.GetComponent<PlayerMoney>().money = (money - (money * 0.2f));
                    }
                }
                else if (RanDomEvent == 2)
                {
                    OBMINIEvent3.SetActive(true);

                    Debug.Log("NoProble");
                }
                else if (RanDomEvent == 3)
                {
                    OBMINIEvent4.SetActive(true);

                    Debug.Log("A fallen tree blocking the way");
                    player.GetComponent<PlayMoment>().move = 0;
                    EventShuffleCard.PathValue();

                }
                else if (RanDomEvent == 4)
                {
                    Debug.Log("Special offer");
                    RandomNum = Random.Range(1, 3);
                    if (RandomNum == 1)
                    {
                        OBMINIEvent5.SetActive(true);
                        Debug.Log("Ture");
                        player.GetComponent<PlayerMoney>().money += 100;
                        EventShuffleCard.EventShuffle();
                    }
                    else
                    {
                        OBMINIEvent6.SetActive(true);
                        Debug.Log("False");
                        player.GetComponent<PlayerMoney>().money -= 200;
                    }
                }
            }
        }
        else if (col.gameObject.tag == "Player4" && player4.GetComponent<PhotonView>().IsMine == true)
        {
            RanDomEvent = Random.Range(1, 5);
            {
                if (RanDomEvent == 1)
                {


                    if (player.GetComponent<PlayMoment>().soldierGuard == 1)
                    {
                        Debug.Log("ป้องกันการโดนปล้นได้เพราะมีทหารคุ้มกัน");
                        OBMINIEvent1.SetActive(true);
                    }
                    else
                    {
                        OBMINIEvent2.SetActive(true);
                        Debug.Log("โดนโจรปล้น");
                        player.GetComponent<PlayerMoney>().money = (money - (money * 0.2f));
                    }
                }
                else if (RanDomEvent == 2)
                {
                    OBMINIEvent3.SetActive(true);

                    Debug.Log("NoProble");
                }
                else if (RanDomEvent == 3)
                {
                    OBMINIEvent4.SetActive(true);

                    Debug.Log("A fallen tree blocking the way");
                    player.GetComponent<PlayMoment>().move = 0;
                    EventShuffleCard.PathValue();

                }
                else if (RanDomEvent == 4)
                {
                    Debug.Log("Special offer");
                    RandomNum = Random.Range(1, 3);
                    if (RandomNum == 1)
                    {
                        OBMINIEvent5.SetActive(true);
                        Debug.Log("Ture");
                        player.GetComponent<PlayerMoney>().money += 100;
                        EventShuffleCard.EventShuffle();
                    }
                    else
                    {
                        OBMINIEvent6.SetActive(true);
                        Debug.Log("False");
                        player.GetComponent<PlayerMoney>().money -= 200;
                    }
                }
            }
        }
            money = player.GetComponent<PlayerMoney>().money;
        }
    void Update()
    {
        
    }

}

