using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Desir : MonoBehaviour
{

    PhotonView pv;
    public GameObject debugDitsuccess;
    public GameObject notconsignment;
    public GameObject player;
    public GameObject p1, p2, p3, p4;
    public GameObject imageGuild, debugGuild;
    public GameObject debugGuildbreak;
    public GameObject invetorysysn;
    public GameObject mainEvent;
    public GameObject aquania, audrea, ayothaya, fricasia, lawaek, macyros, parisia, remania, songverderLois, talukong, tanawadee, troman;
    public int lazadiocost, shoppicacost, nefixiacost, churchcost;
    public GameObject showcostlazadio1, showcostlazadio2, showcostlazadio3, showcostlazadio4, showcostlazadio5, showcostlazadio6, showcostlazadio7, showcostlazadio8, showcostlazadio9;
    public GameObject showcostshoppica1, showcostshoppica2, showcostshoppica3, showcostshoppica4, showcostshoppica5, showcostshoppica6, showcostshoppica7, showcostshoppica8, showcostshoppica9;
    public GameObject showcostnefixia1, showcostnefixia2, showcostnefixia3, showcostnefixia4, showcostnefixia5, showcostnefixia6, showcostnefixia7, showcostnefixia8, showcostnefixia9;
    public GameObject showcostchurch1, showcostchurch2, showcostchurch3, showcostchurch4, showcostchurch5, showcostchurch6, showcostchurch7;
    public Text certificate1, certificate2, certificate3;
    public GameObject artcertificate1, artcertificate2, artcertificate3;
    public bool countdown = true;

    public void Start()
    {
        pv = PhotonView.Get(this);

    }
    private void Update()
    {
        p1 = GameObject.FindGameObjectWithTag("Player1");
        p2 = GameObject.FindGameObjectWithTag("Player2");
        p3 = GameObject.FindGameObjectWithTag("Player3");
        p4 = GameObject.FindGameObjectWithTag("Player4");
        if (p1 != null)
        {
            if (p1.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player1");
            }
            else if (p2.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player2");
            }
            else if (p3.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player3");
            }
            else if (p4.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player4");
            }
        }
        SharingDesir();
        if (lazadiocost > 9)
        {
            lazadiocost = 9;
        }
        if (shoppicacost > 9)
        {
            shoppicacost = 9;
        }
        if (nefixiacost > 9)
        {
            nefixiacost = 9;
        }
        if (churchcost >= 7)
        {
            if (countdown == false)
            {
                countdown = true;
                churchcost = 7;
                debugGuildbreak.SetActive(true);
                mainEvent.GetComponent<MainEventSys>().churchTurn = 1;
            }
        }
        if (churchcost <= 6)
        {
            if (countdown == true)
            {
                countdown = false;
                mainEvent.GetComponent<MainEventSys>().churchTurn = 0;
                mainEvent.GetComponent<MainEventSys>().churchTurn1 = 0;
            }
        }

    }
    public void LazadioRelation()
    {

        if (player.GetComponent<TacticsMove>().guildConfirm == "Desir")
        {
            imageGuild.SetActive(true);
            if (lazadiocost == 1)
            {

                showcostlazadio1.SetActive(true);
                showcostlazadio2.SetActive(false);
                showcostlazadio3.SetActive(false);
                showcostlazadio4.SetActive(false);
                showcostlazadio5.SetActive(false);
                showcostlazadio6.SetActive(false);
                showcostlazadio7.SetActive(false);
                showcostlazadio8.SetActive(false);
                showcostlazadio9.SetActive(false);
            }
            else if (lazadiocost == 2)
            {
                showcostlazadio1.SetActive(true);
                showcostlazadio2.SetActive(true);
                showcostlazadio3.SetActive(false);
                showcostlazadio4.SetActive(false);
                showcostlazadio5.SetActive(false);
                showcostlazadio6.SetActive(false);
                showcostlazadio7.SetActive(false);
                showcostlazadio8.SetActive(false);
                showcostlazadio9.SetActive(false);
            }
            else if (lazadiocost == 3)
            {
                showcostlazadio1.SetActive(true);
                showcostlazadio2.SetActive(true);
                showcostlazadio3.SetActive(true);
                showcostlazadio4.SetActive(false);
                showcostlazadio5.SetActive(false);
                showcostlazadio6.SetActive(false);
                showcostlazadio7.SetActive(false);
                showcostlazadio8.SetActive(false);
                showcostlazadio9.SetActive(false);
            }
            else if (lazadiocost == 4)
            {
                showcostlazadio1.SetActive(true);
                showcostlazadio2.SetActive(true);
                showcostlazadio3.SetActive(true);
                showcostlazadio4.SetActive(true);
                showcostlazadio5.SetActive(false);
                showcostlazadio6.SetActive(false);
                showcostlazadio7.SetActive(false);
                showcostlazadio8.SetActive(false);
                showcostlazadio9.SetActive(false);
            }
            else if (lazadiocost == 5)
            {
                showcostlazadio1.SetActive(true);
                showcostlazadio2.SetActive(true);
                showcostlazadio3.SetActive(true);
                showcostlazadio4.SetActive(true);
                showcostlazadio5.SetActive(true);
                showcostlazadio6.SetActive(false);
                showcostlazadio7.SetActive(false);
                showcostlazadio8.SetActive(false);
                showcostlazadio9.SetActive(false);
            }
            else if (lazadiocost == 6)
            {
                showcostlazadio1.SetActive(true);
                showcostlazadio2.SetActive(true);
                showcostlazadio3.SetActive(true);
                showcostlazadio4.SetActive(true);
                showcostlazadio5.SetActive(true);
                showcostlazadio6.SetActive(true);
                showcostlazadio7.SetActive(false);
                showcostlazadio8.SetActive(false);
                showcostlazadio9.SetActive(false);
            }
            else if (lazadiocost == 7)
            {
                showcostlazadio1.SetActive(true);
                showcostlazadio2.SetActive(true);
                showcostlazadio3.SetActive(true);
                showcostlazadio4.SetActive(true);
                showcostlazadio5.SetActive(true);
                showcostlazadio6.SetActive(true);
                showcostlazadio7.SetActive(true);
                showcostlazadio8.SetActive(false);
                showcostlazadio9.SetActive(false);
            }
            else if (lazadiocost == 8)
            {
                showcostlazadio1.SetActive(true);
                showcostlazadio2.SetActive(true);
                showcostlazadio3.SetActive(true);
                showcostlazadio4.SetActive(true);
                showcostlazadio5.SetActive(true);
                showcostlazadio6.SetActive(true);
                showcostlazadio7.SetActive(true);
                showcostlazadio8.SetActive(true);
                showcostlazadio9.SetActive(false);
            }
            else if (lazadiocost == 9)
            {
                showcostlazadio1.SetActive(true);
                showcostlazadio2.SetActive(true);
                showcostlazadio3.SetActive(true);
                showcostlazadio4.SetActive(true);
                showcostlazadio5.SetActive(true);
                showcostlazadio6.SetActive(true);
                showcostlazadio7.SetActive(true);
                showcostlazadio8.SetActive(true);
                showcostlazadio9.SetActive(true);
            }
        }
    }
    public void ShoppicaRelation()
    {

        if (player.GetComponent<TacticsMove>().guildConfirm == "Desir")
        {
            imageGuild.SetActive(true);
            if (shoppicacost == 1)
            {
                showcostshoppica1.SetActive(true);
                showcostshoppica2.SetActive(false);
                showcostshoppica3.SetActive(false);
                showcostshoppica4.SetActive(false);
                showcostshoppica5.SetActive(false);
                showcostshoppica6.SetActive(false);
                showcostshoppica7.SetActive(false);
                showcostshoppica8.SetActive(false);
                showcostshoppica9.SetActive(false);
            }
            else if (shoppicacost == 2)
            {
                showcostshoppica1.SetActive(true);
                showcostshoppica2.SetActive(true);
                showcostshoppica3.SetActive(false);
                showcostshoppica4.SetActive(false);
                showcostshoppica5.SetActive(false);
                showcostshoppica6.SetActive(false);
                showcostshoppica7.SetActive(false);
                showcostshoppica8.SetActive(false);
                showcostshoppica9.SetActive(false);
            }
            else if (shoppicacost == 3)
            {
                showcostshoppica1.SetActive(true);
                showcostshoppica2.SetActive(true);
                showcostshoppica3.SetActive(true);
                showcostshoppica4.SetActive(false);
                showcostshoppica5.SetActive(false);
                showcostshoppica6.SetActive(false);
                showcostshoppica7.SetActive(false);
                showcostshoppica8.SetActive(false);
                showcostshoppica9.SetActive(false);
            }
            else if (shoppicacost == 4)
            {
                showcostshoppica1.SetActive(true);
                showcostshoppica2.SetActive(true);
                showcostshoppica3.SetActive(true);
                showcostshoppica4.SetActive(true);
                showcostshoppica5.SetActive(false);
                showcostshoppica6.SetActive(false);
                showcostshoppica7.SetActive(false);
                showcostshoppica8.SetActive(false);
                showcostshoppica9.SetActive(false);
            }
            else if (shoppicacost == 5)
            {
                showcostshoppica1.SetActive(true);
                showcostshoppica2.SetActive(true);
                showcostshoppica3.SetActive(true);
                showcostshoppica4.SetActive(true);
                showcostshoppica5.SetActive(true);
                showcostshoppica6.SetActive(false);
                showcostshoppica7.SetActive(false);
                showcostshoppica8.SetActive(false);
                showcostshoppica9.SetActive(false);
            }
            else if (shoppicacost == 6)
            {
                showcostshoppica1.SetActive(true);
                showcostshoppica2.SetActive(true);
                showcostshoppica3.SetActive(true);
                showcostshoppica4.SetActive(true);
                showcostshoppica5.SetActive(true);
                showcostshoppica6.SetActive(true);
                showcostshoppica7.SetActive(false);
                showcostshoppica8.SetActive(false);
                showcostshoppica9.SetActive(false);
            }
            else if (shoppicacost == 7)
            {
                showcostshoppica1.SetActive(true);
                showcostshoppica2.SetActive(true);
                showcostshoppica3.SetActive(true);
                showcostshoppica4.SetActive(true);
                showcostshoppica5.SetActive(true);
                showcostshoppica6.SetActive(true);
                showcostshoppica7.SetActive(true);
                showcostshoppica8.SetActive(false);
                showcostshoppica9.SetActive(false);
            }
            else if (shoppicacost == 8)
            {
                showcostshoppica1.SetActive(true);
                showcostshoppica2.SetActive(true);
                showcostshoppica3.SetActive(true);
                showcostshoppica4.SetActive(true);
                showcostshoppica5.SetActive(true);
                showcostshoppica6.SetActive(true);
                showcostshoppica7.SetActive(true);
                showcostshoppica8.SetActive(true);
                showcostshoppica9.SetActive(false);
            }
            else if (shoppicacost == 9)
            {
                showcostshoppica1.SetActive(true);
                showcostshoppica2.SetActive(true);
                showcostshoppica3.SetActive(true);
                showcostshoppica4.SetActive(true);
                showcostshoppica5.SetActive(true);
                showcostshoppica6.SetActive(true);
                showcostshoppica7.SetActive(true);
                showcostshoppica8.SetActive(true);
                showcostshoppica9.SetActive(true);
            }
        }
    }
    public void NefixiaRelation()
    {
        if (player.GetComponent<TacticsMove>().guildConfirm == "Desir")
        {
            imageGuild.SetActive(true);
            if (nefixiacost == 1)
            {
                showcostnefixia1.SetActive(true);
                showcostnefixia2.SetActive(false);
                showcostnefixia3.SetActive(false);
                showcostnefixia4.SetActive(false);
                showcostnefixia5.SetActive(false);
                showcostnefixia6.SetActive(false);
                showcostnefixia7.SetActive(false);
                showcostnefixia8.SetActive(false);
                showcostnefixia9.SetActive(false);
            }
            else if (nefixiacost == 2)
            {
                showcostnefixia1.SetActive(true);
                showcostnefixia2.SetActive(true);
                showcostnefixia3.SetActive(false);
                showcostnefixia4.SetActive(false);
                showcostnefixia5.SetActive(false);
                showcostnefixia6.SetActive(false);
                showcostnefixia7.SetActive(false);
                showcostnefixia8.SetActive(false);
                showcostnefixia9.SetActive(false);
            }
            else if (nefixiacost == 3)
            {
                showcostnefixia1.SetActive(true);
                showcostnefixia2.SetActive(true);
                showcostnefixia3.SetActive(true);
                showcostnefixia4.SetActive(false);
                showcostnefixia5.SetActive(false);
                showcostnefixia6.SetActive(false);
                showcostnefixia7.SetActive(false);
                showcostnefixia8.SetActive(false);
                showcostnefixia9.SetActive(false);
            }
            else if (nefixiacost == 4)
            {
                showcostnefixia1.SetActive(true);
                showcostnefixia2.SetActive(true);
                showcostnefixia3.SetActive(true);
                showcostnefixia4.SetActive(true);
                showcostnefixia5.SetActive(false);
                showcostnefixia6.SetActive(false);
                showcostnefixia7.SetActive(false);
                showcostnefixia8.SetActive(false);
                showcostnefixia9.SetActive(false);
            }
            else if (nefixiacost == 5)
            {
                showcostnefixia1.SetActive(true);
                showcostnefixia2.SetActive(true);
                showcostnefixia3.SetActive(true);
                showcostnefixia4.SetActive(true);
                showcostnefixia5.SetActive(true);
                showcostnefixia6.SetActive(false);
                showcostnefixia7.SetActive(false);
                showcostnefixia8.SetActive(false);
                showcostnefixia9.SetActive(false);
            }
            else if (nefixiacost == 6)
            {
                showcostnefixia1.SetActive(true);
                showcostnefixia2.SetActive(true);
                showcostnefixia3.SetActive(true);
                showcostnefixia4.SetActive(true);
                showcostnefixia5.SetActive(true);
                showcostnefixia6.SetActive(true);
                showcostnefixia7.SetActive(false);
                showcostnefixia8.SetActive(false);
                showcostnefixia9.SetActive(false);
            }
            else if (nefixiacost == 7)
            {
                showcostnefixia1.SetActive(true);
                showcostnefixia2.SetActive(true);
                showcostnefixia3.SetActive(true);
                showcostnefixia4.SetActive(true);
                showcostnefixia5.SetActive(true);
                showcostnefixia6.SetActive(true);
                showcostnefixia7.SetActive(true);
                showcostnefixia8.SetActive(false);
                showcostnefixia9.SetActive(false);
            }
            else if (nefixiacost == 8)
            {
                showcostnefixia1.SetActive(true);
                showcostnefixia2.SetActive(true);
                showcostnefixia3.SetActive(true);
                showcostnefixia4.SetActive(true);
                showcostnefixia5.SetActive(true);
                showcostnefixia6.SetActive(true);
                showcostnefixia7.SetActive(true);
                showcostnefixia8.SetActive(true);
                showcostnefixia9.SetActive(false);
            }
            else if (nefixiacost == 9)
            {
                showcostnefixia1.SetActive(true);
                showcostnefixia2.SetActive(true);
                showcostnefixia3.SetActive(true);
                showcostnefixia4.SetActive(true);
                showcostnefixia5.SetActive(true);
                showcostnefixia6.SetActive(true);
                showcostnefixia7.SetActive(true);
                showcostnefixia8.SetActive(true);
                showcostnefixia9.SetActive(true);
            }
        }
    }
    public void Church()
    {
        if (player.GetComponent<TacticsMove>().guildConfirm == "Desir")
        {
            imageGuild.SetActive(true);
            if (churchcost == 1)
            {
                showcostchurch1.SetActive(true);
                showcostchurch2.SetActive(false);
                showcostchurch3.SetActive(false);
                showcostchurch4.SetActive(false);
                showcostchurch5.SetActive(false);
                showcostchurch6.SetActive(false);
                showcostchurch7.SetActive(false);
            }
            else if (churchcost == 2)
            {
                showcostchurch1.SetActive(true);
                showcostchurch2.SetActive(true);
                showcostchurch3.SetActive(false);
                showcostchurch4.SetActive(false);
                showcostchurch5.SetActive(false);
                showcostchurch6.SetActive(false);
                showcostchurch7.SetActive(false);
            }
            else if (churchcost == 3)
            {
                showcostchurch1.SetActive(true);
                showcostchurch2.SetActive(true);
                showcostchurch3.SetActive(true);
                showcostchurch4.SetActive(false);
                showcostchurch5.SetActive(false);
                showcostchurch6.SetActive(false);
                showcostchurch7.SetActive(false);
            }
            else if (churchcost == 4)
            {
                showcostchurch1.SetActive(true);
                showcostchurch2.SetActive(true);
                showcostchurch3.SetActive(true);
                showcostchurch4.SetActive(true);
                showcostchurch5.SetActive(false);
                showcostchurch6.SetActive(false);
                showcostchurch7.SetActive(false);
            }
            else if (churchcost == 5)
            {
                showcostchurch1.SetActive(true);
                showcostchurch2.SetActive(true);
                showcostchurch3.SetActive(true);
                showcostchurch4.SetActive(true);
                showcostchurch5.SetActive(true);
                showcostchurch6.SetActive(false);
                showcostchurch7.SetActive(false);
            }
            else if (churchcost == 6)
            {
                showcostchurch1.SetActive(true);
                showcostchurch2.SetActive(true);
                showcostchurch3.SetActive(true);
                showcostchurch4.SetActive(true);
                showcostchurch5.SetActive(true);
                showcostchurch6.SetActive(true);
                showcostchurch7.SetActive(false);
            }
            else if (churchcost == 7)
            {
                showcostchurch1.SetActive(true);
                showcostchurch2.SetActive(true);
                showcostchurch3.SetActive(true);
                showcostchurch4.SetActive(true);
                showcostchurch5.SetActive(true);
                showcostchurch6.SetActive(true);
                showcostchurch7.SetActive(true);
            }
        }
    }
    public void invitpromotion()
    {
        if (player.GetComponent<TacticsMove>().guildConfirm == "Desir")
        {
            if (player.GetComponent<PlayMoment>().certificate[0] == 0)
            {
                if (player.GetComponent<PlayMoment>().visitbefore == "audrea" || player.GetComponent<PlayMoment>().visitbefore == "fricasia")
                {
                    player.GetComponent<PlayMoment>().certificate[0] = 1;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    Debug.Log("ซื้อหนังสือแล้ว");
                    debugDitsuccess.SetActive(true);

                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "talukong")
                {
                    player.GetComponent<PlayMoment>().certificate[0] = 2;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "troman" || player.GetComponent<PlayMoment>().visitbefore == "remania" || player.GetComponent<PlayMoment>().visitbefore == "macyros" || player.GetComponent<PlayMoment>().visitbefore == "aquania")
                {
                    player.GetComponent<PlayMoment>().certificate[0] = 3;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "tanaowadee")
                {
                    player.GetComponent<PlayMoment>().certificate[0] = 4;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "ayothaya" || player.GetComponent<PlayMoment>().visitbefore == "lawaek")
                {
                    player.GetComponent<PlayMoment>().certificate[0] = 5;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "songverderLois" || player.GetComponent<PlayMoment>().visitbefore == "parisia")
                {
                    player.GetComponent<PlayMoment>().certificate[0] = 6;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
            }
            else if (player.GetComponent<PlayMoment>().certificate[1] == 0)
            {
                if (player.GetComponent<PlayMoment>().visitbefore == "audrea" || player.GetComponent<PlayMoment>().visitbefore == "fricasia")
                {
                    player.GetComponent<PlayMoment>().certificate[1] = 1;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "talukong")
                {
                    player.GetComponent<PlayMoment>().certificate[1] = 2;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "troman" || player.GetComponent<PlayMoment>().visitbefore == "remania" || player.GetComponent<PlayMoment>().visitbefore == "macyros" || player.GetComponent<PlayMoment>().visitbefore == "aquania")
                {
                    player.GetComponent<PlayMoment>().certificate[1] = 3;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "tanaowadee")
                {
                    player.GetComponent<PlayMoment>().certificate[1] = 4;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "ayothaya" || player.GetComponent<PlayMoment>().visitbefore == "lawaek")
                {
                    player.GetComponent<PlayMoment>().certificate[1] = 5;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "songverderLois" || player.GetComponent<PlayMoment>().visitbefore == "parisia")
                {
                    player.GetComponent<PlayMoment>().certificate[1] = 6;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
            }
            else if (player.GetComponent<PlayMoment>().certificate[2] == 0)
            {
                if (player.GetComponent<PlayMoment>().visitbefore == "audrea" || player.GetComponent<PlayMoment>().visitbefore == "fricasia")
                {
                    player.GetComponent<PlayMoment>().certificate[2] = 1;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "talukong")
                {
                    player.GetComponent<PlayMoment>().certificate[2] = 2;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "troman" || player.GetComponent<PlayMoment>().visitbefore == "remania" || player.GetComponent<PlayMoment>().visitbefore == "macyros" || player.GetComponent<PlayMoment>().visitbefore == "aquania")
                {
                    player.GetComponent<PlayMoment>().certificate[2] = 3;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "tanaowadee")
                {
                    player.GetComponent<PlayMoment>().certificate[2] = 4;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "ayothaya" || player.GetComponent<PlayMoment>().visitbefore == "lawaek")
                {
                    player.GetComponent<PlayMoment>().certificate[2] = 5;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
                else if (player.GetComponent<PlayMoment>().visitbefore == "songverderLois" || player.GetComponent<PlayMoment>().visitbefore == "parisia")
                {
                    player.GetComponent<PlayMoment>().certificate[2] = 6;
                    player.GetComponent<PlayerMoney>().money -= 300;
                    debugDitsuccess.SetActive(true);
                }
            }
            else
            {
                debugGuild.SetActive(true);
            }
        }
    }

    public void SharingDesir()
    {
        pv.RPC("Desircost", RpcTarget.AllBuffered, lazadiocost, shoppicacost, nefixiacost, churchcost);
    }

    [PunRPC]
    void Desircost(int lazadicos, int shoppicos, int nefixicos, int churchcos)
    {
        lazadiocost = lazadicos;
        shoppicacost = shoppicos;
        nefixiacost = nefixicos;
        churchcost = churchcos;
    }

    public void Consignment(int citynumber)
    {
        if (player.GetComponent<TacticsMove>().guildConfirm == "Desir" && mainEvent.GetComponent<MainEventSys>().countTurn2 != 0)
        {
            if (citynumber == 1)
            {
                aquania.GetComponent<Aquania>().aquaniainv = true;
            }
            else if (citynumber == 2)
            {
                audrea.GetComponent<Audrea>().audreainv = true;
            }
            else if (citynumber == 3)
            {
                ayothaya.GetComponent<Ayothaya>().ayothayainv = true;
            }
            else if (citynumber == 4)
            {
                fricasia.GetComponent<Fricasia>().fricasiainv = true;
            }
            else if (citynumber == 5)
            {
                lawaek.GetComponent<Lawaek>().lawaekinv = true;
            }
            else if (citynumber == 6)
            {
                macyros.GetComponent<Macyros>().macyrosinv = true;
            }
            else if (citynumber == 7)
            {
                parisia.GetComponent<Parisia>().parisiainv = true;
            }
            else if (citynumber == 8)
            {
                remania.GetComponent<Remania>().remaniainv = true;
            }
            else if (citynumber == 9)
            {
                songverderLois.GetComponent<SongverderLois>().songverderLoisinv = true;
            }
            else if (citynumber == 10)
            {
                talukong.GetComponent<Talukong>().talukonginv = true;
            }
            else if (citynumber == 11)
            {
                tanawadee.GetComponent<Tanaowadee>().tanaowadeeinv = true;
            }
            else if (citynumber == 12)
            {
                troman.GetComponent<Troman>().troman = true;
            }
        }
        else
        {
            notconsignment.SetActive(true);
        }
    }

    public void Resetvalue()
    {
        aquania.GetComponent<Aquania>().aquaniainv = false;
        audrea.GetComponent<Audrea>().audreainv = false;
        ayothaya.GetComponent<Ayothaya>().ayothayainv = false;
        fricasia.GetComponent<Fricasia>().fricasiainv = false;
        lawaek.GetComponent<Lawaek>().lawaekinv = false;
        macyros.GetComponent<Macyros>().macyrosinv = false;
        parisia.GetComponent<Parisia>().parisiainv = false;
        remania.GetComponent<Remania>().remaniainv = false;
        songverderLois.GetComponent<SongverderLois>().songverderLoisinv = false;
        talukong.GetComponent<Talukong>().talukonginv = false;
        tanawadee.GetComponent<Tanaowadee>().tanaowadeeinv = false;
        troman.GetComponent<Troman>().troman = false;
    }

    public void Spcialceti()
    {
        if (player != null)
        {
            if (player.GetComponent<PlayMoment>().guildConfirm == "Desir")
            {
                if (player.GetComponent<PlayMoment>().certificate[0] != 0)
                {
                    if (player.GetComponent<PlayMoment>().certificate[0] == 1)
                    {
                        certificate1.text = "หมู่เกาะวิงคิ";
                        artcertificate1.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[0] == 2)
                    {
                        certificate1.text = "ต้าลู่";
                        artcertificate1.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[0] == 3)
                    {
                        certificate1.text = "จักรวรรดิอีมอล";
                        artcertificate1.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[0] == 4)
                    {
                        certificate1.text = "ครีโอโปริส";
                        artcertificate1.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[0] == 5)
                    {
                        certificate1.text = "วัดสง่า";
                        artcertificate1.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[0] == 6)
                    {
                        certificate1.text = "อองมะ";
                        artcertificate1.SetActive(true);
                    }
                }
                else if (player.GetComponent<PlayMoment>().certificate[0] == 0)
                {
                    certificate1.text = "";
                    artcertificate1.SetActive(false);
                }
                if (player.GetComponent<PlayMoment>().certificate[1] != 0)
                {
                    if (player.GetComponent<PlayMoment>().certificate[1] == 1)
                    {
                        certificate2.text = "หมู่เกาะวิงคิ";
                        artcertificate2.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[1] == 2)
                    {
                        certificate2.text = "ต้าลู่";
                        artcertificate2.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[1] == 3)
                    {
                        certificate2.text = "จักรวรรดิอีมอล";
                        artcertificate2.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[1] == 4)
                    {
                        certificate2.text = "ครีโอโปริส";
                        artcertificate2.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[1] == 5)
                    {
                        certificate2.text = "วัดสง่า";
                        artcertificate2.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[1] == 6)
                    {
                        certificate2.text = "อองมะ";
                        artcertificate2.SetActive(true);
                    }
                }
                else if (player.GetComponent<PlayMoment>().certificate[1] == 0)
                {
                    certificate2.text = "";
                    artcertificate2.SetActive(false);
                }
                if (player.GetComponent<PlayMoment>().certificate[2] != 0)
                {
                    if (player.GetComponent<PlayMoment>().certificate[2] == 1)
                    {
                        certificate3.text = "หมู่เกาะวิงคิ";
                        artcertificate3.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[2] == 2)
                    {
                        certificate3.text = "ต้าลู่";
                        artcertificate3.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[2] == 3)
                    {
                        certificate3.text = "จักรวรรดิอีมอล";
                        artcertificate3.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[2] == 4)
                    {
                        certificate3.text = "ครีโอโปริส";
                        artcertificate3.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[2] == 5)
                    {
                        certificate3.text = "วัดสง่า";
                        artcertificate3.SetActive(true);
                    }
                    else if (player.GetComponent<PlayMoment>().certificate[2] == 6)
                    {
                        certificate3.text = "อองมะ";
                        artcertificate3.SetActive(true);
                    }
                }
                else if (player.GetComponent<PlayMoment>().certificate[2] == 0)
                {
                    certificate3.text = "";
                    artcertificate3.SetActive(false);
                }
            }
        }

    }
}
