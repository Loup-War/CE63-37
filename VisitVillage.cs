using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class VisitVillage : MonoBehaviour
{
    public GameObject player;
    public GameObject player1, player2, player3, player4;
    public bool thorimberg, logos, harimdal, changAn, xiaoBei, pingYuan, xingye, surus, poros, makhkha,
                      kosol, wachchi, sriwichay, chiangSaen, phukam, jenla, thorus, normangdy, renes, dijon,ramus;
    public GameObject vinking, vinkingspcial, talu, taluspcial, emol, emolspcial, creoporis, wadsnga, wadsngaspcial, aongma, aongmaspcial;

    public void Start()
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
    }
    public void visit()
    {
        if (player.GetComponent<TacticsMove>().visit == 1)
        {
            if (logos == true || harimdal)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                vinking.SetActive(true);
            }
            else if (xiaoBei == true || pingYuan == true || xingye == true)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                talu.SetActive(true);
            }
            else if (poros == true)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                emol.SetActive(true);
            }
            else if (makhkha == true || wachchi == true || kosol == true || ramus == true)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                creoporis.SetActive(true);
            }
            else if (phukam == true || jenla == true)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                wadsnga.SetActive(true);
            }
            else if (normangdy == true || renes == true || dijon == true)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                aongma.SetActive(true);
            }
            else if (thorus == true)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                aongmaspcial.SetActive(true);
            }
            else if (chiangSaen == true)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                wadsngaspcial.SetActive(true);
            }
            else if (surus == true)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                emolspcial.SetActive(true);
            }
            else if (changAn == true)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                taluspcial.SetActive(true);
            }
            else if(thorimberg == true)
            {
                player.GetComponent<TacticsMove>().visit = 0;
                vinkingspcial.SetActive(true);
            }
        }

    }
}
