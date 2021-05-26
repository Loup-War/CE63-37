using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public bool endgame = false;
    public bool lastp1, lastp2;
    public GameObject player, player1, player2, player3, player4, inventory1;
    public GameObject victoryscore, moneysharingg;
    public GameObject disconnet;
    public Text one, two, three, four, moneyone, moneytwo, moneythree, moneyfour;
    public float tem1, tem2, tem3, tem4;

    void Start()
    {
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
        else if (player != null)
        {
            if (TurnSys.TurnShow == 200)
            {
                if (player4 != null)
                {
                    float playMon1 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                    float playMon2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                    float playMon3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                    float playMon4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                    float[] arr = { playMon1, playMon2, playMon3, playMon4 };
                    float temp;
                    int spare;
                    for (int j = 0; j <= arr.Length - 2; j++)
                    {
                        for (int i = 0; i <= arr.Length - 2; i++)
                        {
                            if (arr[i] < arr[i + 1])
                            {
                                spare = i + 1;
                                temp = arr[spare];
                                arr[i + 1] = arr[i];
                                arr[i] = temp;
                            }
                        }
                    }
                    if (tem1 == 0)
                    {
                        if (playMon1 == arr[0])
                        {
                            tem1 = playMon1;
                            one.text = "Player 1";
                        }
                        else if (playMon2 == arr[0])
                        {
                            tem1 = playMon2;
                            one.text = "Player 2";
                        }
                        else if (playMon3 == arr[0])
                        {
                            tem1 = playMon3;
                            one.text = "Player 3";
                        }
                        else if (playMon4 == arr[0])
                        {
                            tem1 = playMon4;
                            one.text = "Player 4";
                        }
                        moneyone.text = "" + tem1.ToString() + " G ";
                    }
                    if (tem2 == 0)
                    {
                        if (playMon1 == arr[1])
                        {
                            tem2 = playMon1;
                            two.text = "Player 1";
                        }
                        else if (playMon2 == arr[1])
                        {
                            tem2 = playMon2;
                            two.text = "Player 2";
                        }
                        else if (playMon3 == arr[1])
                        {
                            tem2 = playMon3;
                            two.text = "Player 3";
                        }
                        else if (playMon4 == arr[1])
                        {
                            tem2 = playMon4;
                            two.text = "Player 4";
                        }
                        moneytwo.text = "" + tem2.ToString() + " G ";
                    }
                    if (tem3 == 0)
                    {
                        if (playMon1 == arr[2])
                        {
                            tem3 = playMon1;
                            three.text = "Player 1";
                        }
                        else if (playMon2 == arr[2])
                        {
                            tem3 = playMon2;
                            three.text = "Player 2";
                        }
                        else if (playMon3 == arr[2])
                        {
                            tem3 = playMon3;
                            three.text = "Player 3";
                        }
                        else if (playMon4 == arr[2])
                        {
                            tem3 = playMon4;
                            three.text = "Player 4";
                        }
                        moneythree.text = "" + tem3.ToString() + " G ";
                    }
                    if (tem4 == 0)
                    {
                        if (playMon1 == arr[3])
                        {
                            tem4 = playMon1;
                            four.text = "Player 1";
                        }
                        else if (playMon2 == arr[3])
                        {
                            tem4 = playMon2;
                            four.text = "Player 2";
                        }
                        else if (playMon3 == arr[3])
                        {
                            tem4 = playMon3;
                            four.text = "Player 3";
                        }
                        else if (playMon4 == arr[3])
                        {
                            tem4 = playMon4;
                            four.text = "Player 4";
                        }
                        moneyfour.text = "" + tem4.ToString() + " G ";
                    }
                }
                else if (player3 != null && player4 == null)
                {
                    if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp2)
                    {
                        tem1 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                        tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                        if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                        {
                            if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                            {
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                one.text = "Player 1";
                                two.text = "Player 2";
                                three.text = "Player 3";
                                moneyone.text = "" + tem1.ToString() + " G ";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                four.text = "";
                                moneyfour.text = "";

                            }
                            else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 < moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                            {
                                tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                one.text = "Player 1";
                                two.text = "Player 3";
                                three.text = "Player 2";
                                moneyone.text = "" + tem1.ToString() + " G ";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                four.text = "";
                                moneyfour.text = "";
                            }
                        }
                        else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 < moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                        {
                            tem1 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            one.text = "Player 3";
                            two.text = "Player 1";
                            three.text = "Player 2";
                            moneyone.text = "" + tem1.ToString() + " G ";
                            moneytwo.text = "" + tem2.ToString() + " G ";
                            moneythree.text = "" + tem3.ToString() + " G ";
                            four.text = "";
                            moneyfour.text = "";
                        }
                    }
                    else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp1)
                    {
                        tem1 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                        tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                        if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                        {
                            if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                            {
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                one.text = "Player 2";
                                two.text = "Player 1";
                                three.text = "Player 3";
                                moneyone.text = "" + tem1.ToString() + " G ";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                four.text = "";
                                moneyfour.text = "";
                            }
                            else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 < moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                            {
                                tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                one.text = "Player 2";
                                two.text = "Player 3";
                                three.text = "Player 1";
                                moneyone.text = "" + tem1.ToString() + " G ";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                four.text = "";
                                moneyfour.text = "";
                            }
                        }
                        else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 < moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                        {
                            tem1 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            one.text = "Player 3";
                            two.text = "Player 2";
                            three.text = "Player 1";
                            moneyone.text = "" + tem1.ToString() + " G ";
                            moneytwo.text = "" + tem2.ToString() + " G ";
                            moneythree.text = "" + tem3.ToString() + " G ";
                            four.text = "";
                            moneyfour.text = "";
                        }
                    }
                }
                else if (player2 != null && player3 == null && player4 == null)
                {
                    if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp2)
                    {
                        tem1 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                        tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                        one.text = "Player 1";
                        two.text = "Player 2";
                        moneyone.text = "" + tem1.ToString() + " G ";
                        moneytwo.text = "" + tem2.ToString() + " G ";
                        three.text = "";
                        moneythree.text = "";
                        four.text = "";
                        moneyfour.text = "";
                    }
                    else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp1)
                    {
                        tem1 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                        tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                        one.text = "Player 2";
                        two.text = "Player 1";
                        moneyone.text = tem1.ToString() + " G ";
                        moneytwo.text = tem2.ToString() + " G ";
                        three.text = "";
                        moneythree.text = "";
                        four.text = "";
                        moneyfour.text = "";
                    }
                }

                victoryscore.SetActive(true);
            }
            else if (endgame == true)
            {
                if (player4 != null)
                {
                    if (moneysharingg.GetComponent<CharingMoney>().mystoreShowp1 == true)
                    {
                        one.text = "Player 1";
                        moneyone.text = "บรรลุเป้าหมาย";
                        if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                            if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                    two.text = "Player 2";
                                    three.text = "Player 3";
                                    four.text = "Player 4";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                                else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                    two.text = "Player 2";
                                    three.text = "Player 4";
                                    four.text = "Player 3";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                            }
                            else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                two.text = "Player 4";
                                three.text = "Player 2";
                                four.text = "Player 3";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                moneyfour.text = "" + tem4.ToString() + " G ";
                            }
                        }
                        else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 > moneysharingg.GetComponent<CharingMoney>().moneyshowp2)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                    two.text = "Player 3";
                                    three.text = "Player 2";
                                    four.text = "Player 4";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                                else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                    two.text = "Player 3";
                                    three.text = "Player 4";
                                    four.text = "Player 2";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                            }
                            else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                two.text = "Player 4";
                                three.text = "Player 3";
                                four.text = "Player 2";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                moneyfour.text = "" + tem4.ToString() + " G ";
                            }
                        }
                    }
                    else if (moneysharingg.GetComponent<CharingMoney>().mystoreShowp2 == true)
                    {
                        one.text = "Player 2";
                        moneyone.text = "บรรลุเป้าหมาย";
                        if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                            if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                    two.text = "Player 1";
                                    three.text = "Player 3";
                                    four.text = "Player 4";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                                else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                    two.text = "Player 1";
                                    three.text = "Player 4";
                                    four.text = "Player 3";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                            }
                            else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                                tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                two.text = "Player 4";
                                three.text = "Player 1";
                                four.text = "Player 3";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                moneyfour.text = "" + tem4.ToString() + " G ";
                            }
                        }
                        else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 > moneysharingg.GetComponent<CharingMoney>().moneyshowp1)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                    two.text = "Player 3";
                                    three.text = "Player 1";
                                    four.text = "Player 4";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                                else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                                    two.text = "Player 3";
                                    three.text = "Player 4";
                                    four.text = "Player 1";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                            }
                            else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                                two.text = "Player 4";
                                three.text = "Player 3";
                                four.text = "Player 1";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                moneyfour.text = "" + tem4.ToString() + " G ";
                            }
                        }
                    }
                    else if (moneysharingg.GetComponent<CharingMoney>().mystoreShowp3 == true)
                    {
                        one.text = "Player 3";
                        moneyone.text = "บรรลุเป้าหมาย";
                        if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp2)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                    two.text = "Player 1";
                                    three.text = "Player 2";
                                    four.text = "Player 4";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                                else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                    two.text = "Player 1";
                                    three.text = "Player 4";
                                    four.text = "Player 2";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                            }
                            else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                                tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                two.text = "Player 4";
                                three.text = "Player 1";
                                four.text = "Player 2";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                moneyfour.text = "" + tem4.ToString() + " G ";
                            }
                        }
                        else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp1)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                    two.text = "Player 2";
                                    three.text = "Player 1";
                                    four.text = "Player 4";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                                else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                                {
                                    tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                                    two.text = "Player 2";
                                    three.text = "Player 4";
                                    four.text = "Player 1";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                            }
                            else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 < moneysharingg.GetComponent<CharingMoney>().moneyshowp4)
                            {
                                tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp4;
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                                two.text = "Player 4";
                                three.text = "Player 2";
                                four.text = "Player 1";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                moneyfour.text = "" + tem4.ToString() + " G ";
                            }
                        }
                    }
                    else if (moneysharingg.GetComponent<CharingMoney>().mystoreShowp4 == true)
                    {
                        one.text = "Player 4";
                        moneyone.text = "บรรลุเป้าหมาย";
                        if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp2)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                            {
                                if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                                {
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                    two.text = "Player 1";
                                    three.text = "Player 2";
                                    four.text = "Player 3";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                                else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 < moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                                {
                                    tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                    two.text = "Player 1";
                                    three.text = "Player 3";
                                    four.text = "Player 2";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                            }
                            else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 < moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                            {
                                tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                                tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                two.text = "Player 3";
                                three.text = "Player 1";
                                four.text = "Player 2";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                moneyfour.text = "" + tem4.ToString() + " G ";
                            }
                        }
                        else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp1)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                            {
                                if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                                {
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                    two.text = "Player 2";
                                    three.text = "Player 1";
                                    four.text = "Player 3";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                                else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 < moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                                {
                                    tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                    tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                                    two.text = "Player 2";
                                    three.text = "Player 3";
                                    four.text = "Player 1";
                                    moneytwo.text = "" + tem2.ToString() + " G ";
                                    moneythree.text = "" + tem3.ToString() + " G ";
                                    moneyfour.text = "" + tem4.ToString() + " G ";
                                }
                            }
                            else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 < moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                            {
                                tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                                tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                                tem4 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                                two.text = "Player 3";
                                three.text = "Player 2";
                                four.text = "Player 1";
                                moneytwo.text = "" + tem2.ToString() + " G ";
                                moneythree.text = "" + tem3.ToString() + " G ";
                                moneyfour.text = "" + tem4.ToString() + " G ";
                            }
                        }
                    }
                    victoryscore.SetActive(true);
                }
                else if (player3 != null && player4 == null)
                {
                    if (moneysharingg.GetComponent<CharingMoney>().mystoreShowp1 == true)
                    {
                        one.text = "Player 1";
                        moneyone.text = "บรรลุเป้าหมาย";
                        if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                            two.text = "Player 2";
                            three.text = "Player 3";
                            moneytwo.text = "" + tem2.ToString() + " G ";
                            moneythree.text = "" + tem3.ToString() + " G ";
                            four.text = "";
                            moneyfour.text = "";
                        }
                        else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 > moneysharingg.GetComponent<CharingMoney>().moneyshowp2)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            two.text = "Player 3";
                            three.text = "Player 2";
                            moneytwo.text = tem2.ToString() + " G ";
                            moneythree.text = tem3.ToString() + " G ";
                            four.text = "";
                            moneyfour.text = "";
                        }

                    }
                    if (moneysharingg.GetComponent<CharingMoney>().mystoreShowp2 == true)
                    {
                        one.text = "Player 2";
                        moneyone.text = "บรรลุเป้าหมาย";
                        if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp3)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                            two.text = "Player 1";
                            three.text = "Player 3";
                            moneytwo.text = "" + tem2.ToString() + " G ";
                            moneythree.text = "" + tem3.ToString() + " G ";
                            four.text = "";
                            moneyfour.text = "";
                        }
                        else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp3 > moneysharingg.GetComponent<CharingMoney>().moneyshowp1)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp3;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            two.text = "Player 3";
                            three.text = "Player 1";
                            moneytwo.text = tem2.ToString() + " G ";
                            moneythree.text = tem3.ToString() + " G ";
                            four.text = "";
                            moneyfour.text = "";
                        }
                    }
                    if (moneysharingg.GetComponent<CharingMoney>().mystoreShowp3 == true)
                    {
                        one.text = "Player 3";
                        moneyone.text = "บรรลุเป้าหมาย";
                        if (moneysharingg.GetComponent<CharingMoney>().moneyshowp1 > moneysharingg.GetComponent<CharingMoney>().moneyshowp2)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            two.text = "Player 1";
                            three.text = "Player 2";
                            moneytwo.text = "" + tem2.ToString() + " G ";
                            moneythree.text = "" + tem3.ToString() + " G ";
                            four.text = "";
                            moneyfour.text = "";
                        }
                        else if (moneysharingg.GetComponent<CharingMoney>().moneyshowp2 > moneysharingg.GetComponent<CharingMoney>().moneyshowp1)
                        {
                            tem2 = moneysharingg.GetComponent<CharingMoney>().moneyshowp2;
                            tem3 = moneysharingg.GetComponent<CharingMoney>().moneyshowp1;
                            two.text = "Player 2";
                            three.text = "Player 1";
                            moneytwo.text = tem2.ToString() + " G ";
                            moneythree.text = tem3.ToString() + " G ";
                            four.text = "";
                            moneyfour.text = "";
                        }
                    }

                    victoryscore.SetActive(true);
                }
                else if (player2 != null && player3 == null && player4 == null)
                {
                    if (moneysharingg.GetComponent<CharingMoney>().mystoreShowp1 == true)
                    {
                        one.text = "Player 1";
                        moneyone.text = "บรรลุเป้าหมาย";
                        two.text = "Player 2";
                        moneytwo.text = moneysharingg.GetComponent<CharingMoney>().moneyshowp2.ToString() + " G ";
                        victoryscore.SetActive(true);
                    }
                    else if (moneysharingg.GetComponent<CharingMoney>().mystoreShowp2 == true)
                    {
                        one.text = "Player 2";
                        moneyone.text = "บรรลุเป้าหมาย";
                        two.text = "Player 1";
                        moneytwo.text = moneysharingg.GetComponent<CharingMoney>().moneyshowp1.ToString() + " G ";
                        victoryscore.SetActive(true);
                    }
                }
            }
            else if (player.GetComponent<PlayMoment>().playerlastone == true)
            {
                if (disconnet.GetComponent<PlayerDiscon>().lastp1 == true)
                {
                    one.text = "Player 1";
                    moneyone.text = "บรรลุเป้าหมาย";
                    two.text = "Player 2";
                    moneytwo.text = " ออก ";
                }
                else if (disconnet.GetComponent<PlayerDiscon>().lastp2 == true)
                {
                    one.text = "Player 2";
                    moneyone.text = "บรรลุเป้าหมาย";
                    two.text = "Player 1";
                    moneytwo.text = " ออก ";
                }
                victoryscore.SetActive(true);
            }
        }
    }
    public void BuyStore()
    {
        if (player.GetComponent<PlayerMoney>().money > 100000)
        {
            player.GetComponent<PlayerMoney>().money -= 100000;
            player.GetComponent<PlayMoment>().myStore = true;
            moneysharingg.GetComponent<CharingMoney>().EndGameStore();
        }

    }
    public void BacktoLobby()
    {
        {
            StartCoroutine(DisconnectAndLoad());
        }
    }
    IEnumerator DisconnectAndLoad()
    {
        PhotonNetwork.Disconnect();
        Destroy(NetworkManager.Instance);
        Destroy(RoomManager.Instance);
        PhotonNetwork.LeaveRoom();
        while (PhotonNetwork.InRoom)
            yield return null;
        SceneManager.LoadScene("Lobby");
        //PhotonNetwork.ConnectUsingSettings();
        //Debug.Log("Connected to master");
        //PhotonNetwork.JoinLobby();
        //PhotonNetwork.AutomaticallySyncScene = true;
    }

    public void Click_ExitGame()
    {
        Application.Quit();
    }



}