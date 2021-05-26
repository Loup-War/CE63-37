using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class TargetAttack : MonoBehaviour
{
    PhotonView pv;
    public GameObject shoppanel1,shoppanel2,shoppanel3,notpass;
    public GameObject guildpanel;

    public GameObject eventking;
    public GameObject player;
    public GameObject player1, player2, player3, player4;
    public GameObject buttonEnimy1_1, buttonEnimy1_2, buttonEnimy1_3, buttonEnimy2_1, buttonEnimy2_2, buttonEnimy2_3, buttonEnimy3_1, buttonEnimy3_2, buttonEnimy3_3, buttonEnimy4_1, buttonEnimy4_2, buttonEnimy4_3;
    public GameObject buttonEnimychurch1_1, buttonEnimychurch1_2, buttonEnimychurch1_3, buttonEnimychurch2_1, buttonEnimychurch2_2, buttonEnimychurch2_3, buttonEnimychurch3_1, buttonEnimychurch3_2, buttonEnimychurch3_3,
                      buttonEnimychurch4_1, buttonEnimychurch4_2, buttonEnimychurch4_3;
    public GameObject buttonthief, imagecardthief, buttonchurch, imagecardchurch;
    public GameObject thief, church;
    public int p1theifAttack,p2theifAttack,p3theifAttack,p4theifAttack;
    public int p1churchAttack, p2churchAttack, p3churchAttack, p4churchAttack;

    private void Start()
    {
        pv = PhotonView.Get(this);
    }

    void Update()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player3 = GameObject.FindGameObjectWithTag("Player3");
        player4 = GameObject.FindGameObjectWithTag("Player4");
        if (player == null)
        {
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
        }
        CheckThiefAttack();
        CheckChurchAttack();
    }
    
    public void OpenCardSpecial()
    {
        if(player != null)
        {
           if(player.GetComponent<PlayMoment>().cardAttack[0] == 1)
            {
                thief.SetActive(true);
                buttonthief.SetActive(true);
                imagecardthief.SetActive(true);
            }
            else if(player.GetComponent<PlayMoment>().cardAttack[0] == 0)
            {
                thief.SetActive(false);
                buttonthief.SetActive(false);
                imagecardthief.SetActive(false);
            }
            if(player.GetComponent<PlayMoment>().cardAttack[1] == 1)
            {
                church.SetActive(true);
                buttonchurch.SetActive(true);
                imagecardchurch.SetActive(true);
            }
            else if (player.GetComponent<PlayMoment>().cardAttack[1] == 0)
            {
                church.SetActive(false);
                buttonchurch.SetActive(false);
                imagecardchurch.SetActive(false);
            }
        }
    }
    public void OpenThief()
    {
        if(player4 != null)
        {
            if(player1.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimy2_1.SetActive(true);
                buttonEnimy3_2.SetActive(true);
                buttonEnimy4_3.SetActive(true);
            }
            else if(player2.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimy1_1.SetActive(true);
                buttonEnimy3_2.SetActive(true);
                buttonEnimy4_3.SetActive(true);
            }
            else if (player3.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimy1_1.SetActive(true);
                buttonEnimy2_2.SetActive(true);
                buttonEnimy4_3.SetActive(true);
            }
            else if (player4.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimy1_1.SetActive(true);
                buttonEnimy2_2.SetActive(true);
                buttonEnimy3_3.SetActive(true);
            }
        }
        else if(player3 != null)
        {
            if (player1.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimy2_1.SetActive(true);
                buttonEnimy3_3.SetActive(true);
            }
            else if (player2.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimy1_1.SetActive(true);
                buttonEnimy3_3.SetActive(true);
            }
            else if (player3.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimy1_1.SetActive(true);
                buttonEnimy2_3.SetActive(true);
            }
        }
        else if (player2 != null)
        {
            if (player1.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimy2_2.SetActive(true);
            }
            else if (player2.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimy1_2.SetActive(true);
            }
        }
    }

    public void OpenChurch()
    {
        if (player4 != null)
        {
            if (player1.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimychurch2_1.SetActive(true);
                buttonEnimychurch3_2.SetActive(true);
                buttonEnimychurch4_3.SetActive(true);
            }
            else if (player2.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimychurch1_1.SetActive(true);
                buttonEnimychurch3_2.SetActive(true);
                buttonEnimychurch4_3.SetActive(true);
            }
            else if (player3.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimychurch1_1.SetActive(true);
                buttonEnimychurch2_2.SetActive(true);
                buttonEnimychurch4_3.SetActive(true);
            }
            else if (player4.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimychurch1_1.SetActive(true);
                buttonEnimychurch2_2.SetActive(true);
                buttonEnimychurch3_3.SetActive(true);
            }
        }
        else if (player3 != null)
        {
            if (player1.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimychurch2_1.SetActive(true);
                buttonEnimychurch3_3.SetActive(true);
            }
            else if (player2.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimychurch1_1.SetActive(true);
                buttonEnimychurch3_3.SetActive(true);
            }
            else if (player3.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimychurch1_1.SetActive(true);
                buttonEnimychurch2_3.SetActive(true);
            }
        }
        else if (player2 != null)
        {
            if (player1.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimychurch2_2.SetActive(true);
            }
            else if (player2.GetComponent<PhotonView>().IsMine == true)
            {
                buttonEnimychurch1_2.SetActive(true);
            }
        }
    }

    public void TargetThief(int id)
    {
        if(player.GetComponent<PlayMoment>().cardAttack[0] == 1)
        {
            if(id == 1)
            {
                if (p1theifAttack == 0)
                {
                    thief.SetActive(false);
                    buttonthief.SetActive(false);
                    imagecardthief.SetActive(false);
                    p1theifAttack = 1;
                    Debug.Log(" —Ëß‚®¡µ’·≈È«");
                    player.GetComponent<PlayMoment>().cardAttack[0] = 0;
                    SharingattackAll();
                }
                else if(p1theifAttack == 1)
                {

                }
            }
            else if(id == 2)
            {
                if (p2theifAttack == 0)
                {
                    thief.SetActive(false);
                    buttonthief.SetActive(false);
                    imagecardthief.SetActive(false);
                    p2theifAttack = 1;
                    Debug.Log(" —Ëß‚®¡µ’·≈È«");
                    player.GetComponent<PlayMoment>().cardAttack[0] = 0;
                    SharingattackAll();
                }
                else if(p2theifAttack == 1)
                {

                }
            }
            else if(id == 3)
            {
                if (p3theifAttack == 0)
                {
                    thief.SetActive(false);
                    buttonthief.SetActive(false);
                    imagecardthief.SetActive(false);
                    p3theifAttack = 1;
                    Debug.Log(" —Ëß‚®¡µ’·≈È«");
                    player.GetComponent<PlayMoment>().cardAttack[0] = 0;
                    SharingattackAll();
                }
                else if(p3theifAttack == 1)
                {

                }
            }
            else if(id == 4)
            {
                if (p4theifAttack == 0)
                {
                    thief.SetActive(false);
                    buttonthief.SetActive(false);
                    imagecardthief.SetActive(false);
                    p4theifAttack = 1;
                    Debug.Log(" —Ëß‚®¡µ’·≈È«");
                    player.GetComponent<PlayMoment>().cardAttack[0] = 0;
                    SharingattackAll();
                }
                else if(p4theifAttack == 1)
                {

                }
            }
        }
    }

    public void Targetchurch(int id)
    {
        if (player.GetComponent<PlayMoment>().cardAttack[1] == 1)
        {
            if (id == 1)
            {
                if (p1churchAttack == 0)
                {
                    church.SetActive(false);
                    buttonchurch.SetActive(false);
                    imagecardchurch.SetActive(false);
                    p1churchAttack = 1;
                    Debug.Log(" —Ëß‚®¡µ’·≈È«");
                    player.GetComponent<PlayMoment>().cardAttack[1] = 0;
                    SharingattackAll();
                }
                else if(p1churchAttack == 1)
                {

                }
            }
            else if (id == 2)
            {
                if (p2churchAttack == 0)
                {
                    church.SetActive(false);
                    buttonchurch.SetActive(false);
                    imagecardchurch.SetActive(false);
                    p2churchAttack = 1;
                    Debug.Log(" —Ëß‚®¡µ’·≈È«");
                    player.GetComponent<PlayMoment>().cardAttack[1] = 0;
                    SharingattackAll();
                }
                else if(p2churchAttack == 1)
                {

                }
            }
            else if (id == 3)
            {
                if (p3churchAttack == 0)
                {
                    church.SetActive(false);
                    buttonchurch.SetActive(false);
                    imagecardchurch.SetActive(false);
                    p3churchAttack = 1;
                    Debug.Log(" —Ëß‚®¡µ’·≈È«");
                    player.GetComponent<PlayMoment>().cardAttack[1] = 0;
                    SharingattackAll();
                }
                else if(p3churchAttack == 1)
                {

                }
            }
            else if (id == 4)
            {
                if (p4churchAttack == 0)
                {
                    church.SetActive(false);
                    buttonchurch.SetActive(false);
                    imagecardchurch.SetActive(false);
                    p4churchAttack = 1;
                    Debug.Log(" —Ëß‚®¡µ’·≈È«");
                    player.GetComponent<PlayMoment>().cardAttack[1] = 0;
                    SharingattackAll();
                }
                else if(p4churchAttack == 1)
                {

                }
            }
        }
    }

    public void CheckThiefAttack() 
    {
        if (p1theifAttack == 1 )
        {
            player1.GetComponent<PlayMoment>().thiefAttack = true;
        }
        else if(p2theifAttack == 1 )
        {
            player2.GetComponent<PlayMoment>().thiefAttack = true;
        }
        else if(p3theifAttack == 1 )
        {
            player3.GetComponent<PlayMoment>().thiefAttack = true;
        }
        else if (p4theifAttack == 1 )
        {
            player4.GetComponent<PlayMoment>().thiefAttack = true;
        }
        else
        {
            if(player4 != null)
            {
                player1.GetComponent<PlayMoment>().thiefAttack = false;
                player2.GetComponent<PlayMoment>().thiefAttack = false;
                player3.GetComponent<PlayMoment>().thiefAttack = false;
                player4.GetComponent<PlayMoment>().thiefAttack = false;
            }
            else if(player3 != null)
            {
                player1.GetComponent<PlayMoment>().thiefAttack = false;
                player2.GetComponent<PlayMoment>().thiefAttack = false;
                player3.GetComponent<PlayMoment>().thiefAttack = false;
            }
            else if(player2 != null && player1 != null)
            {
                player1.GetComponent<PlayMoment>().thiefAttack = false;
                player2.GetComponent<PlayMoment>().thiefAttack = false;
            }
            else if(player1 != null)
            {
                player1.GetComponent<PlayMoment>().thiefAttack = false;
            }
        }
    }

    public void CheckChurchAttack()
    {
        if (p1churchAttack == 1)
        {
            player1.GetComponent<PlayMoment>().churchAttack = true;
        }
        else if (p2churchAttack == 1)
        {
            player2.GetComponent<PlayMoment>().churchAttack = true;
        }
        else if (p3churchAttack == 1)
        {
            player3.GetComponent<PlayMoment>().churchAttack = true;
        }
        else if (p4churchAttack == 1)
        {
            player4.GetComponent<PlayMoment>().churchAttack = true;
        }
        else
        {
            if (player4 != null)
            {
                player1.GetComponent<PlayMoment>().churchAttack = false;
                player2.GetComponent<PlayMoment>().churchAttack = false;
                player3.GetComponent<PlayMoment>().churchAttack = false;
                player4.GetComponent<PlayMoment>().churchAttack = false;
            }
            else if (player3 != null)
            {
                player1.GetComponent<PlayMoment>().churchAttack = false;
                player2.GetComponent<PlayMoment>().churchAttack = false;
                player3.GetComponent<PlayMoment>().churchAttack = false;
            }
            else if (player2 != null && player1 != null)
            {
                player1.GetComponent<PlayMoment>().churchAttack = false;
                player2.GetComponent<PlayMoment>().churchAttack = false;
            }
            else if (player1 != null)
            {
                player1.GetComponent<PlayMoment>().churchAttack = false;
            }
        }
    }

    public void SharingattackAll()
    {
        pv.RPC("SharingstateAll", RpcTarget.AllBuffered, p1theifAttack, p2theifAttack, p3theifAttack, p4theifAttack, p1churchAttack, p2churchAttack, p3churchAttack, p4churchAttack);
    }

    [PunRPC]
    void SharingstateAll(int p1thife, int p2thife, int p3thife, int p4thife,int p1church,int p2church,int p3church,int p4church)
    {
        p1theifAttack = p1thife;
        p2theifAttack = p2thife;
        p3theifAttack = p3thife;
        p4theifAttack = p4thife;
        p1churchAttack = p1church;
        p2churchAttack = p2church;
        p3churchAttack = p3church;
        p4churchAttack = p4church;
    }


    public void CantOpen()
    {
        if (player.GetComponent<PlayMoment>().Noshop == true)
        {
            notpass.SetActive(true);

        }
        else if (player.GetComponent<PlayMoment>().Noshop == false)
        {
            eventking.SetActive(false);
            shoppanel2.SetActive(true);
            shoppanel3.SetActive(false);
        }
    }

    public void checkguild()
    {
        if(player.GetComponent<PlayMoment>().guild == "Desir" || player.GetComponent<PlayMoment>().guild == "Loup" || player.GetComponent<PlayMoment>().guild == "Serment" || player.GetComponent<PlayMoment>().guild == "Asrial" || player.GetComponent<PlayMoment>().guild == "Orion")
        {
            guildpanel.SetActive(true);
        }
    }
}
