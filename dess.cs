using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class dess : MonoBehaviour
{
    PhotonView PV;

    public GameObject mapall;
    public Text startAndend;
    public GameObject turnmanager;
    public GameObject player1, player2, player3, player4;
    [SerializeField] Text countdownshow;

    public float currentTime = 15f;
    public bool readyy = true;
    public GameObject mainEventSys;

    public void Start()
    {
        PV = PhotonView.Get(this);
        startAndend.text = "StartTurn";
    }
    public void findPlayer()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player3 = GameObject.FindGameObjectWithTag("Player3");
        player4 = GameObject.FindGameObjectWithTag("Player4");
    }
    public void Starturn()
    {
        if (player3 != null && player4 == null)
        {
            Debug.Log("3 Players");
            if (turnmanager.GetComponent<Turnmanager>().player1 == true && player1.GetComponent<PhotonView>().IsMine == true && startAndend.text == "StartTurn")
            {
                countdownshow.color = Color.white;
                player1.GetComponent<PlayMoment>().visit = 1;
                player1.GetComponent<TacticsMove>().turn = true;
                currentTime = 60f;
                startAndend.text = "EndTurn";
                
            }
            else if (turnmanager.GetComponent<Turnmanager>().player1 == true && player1.GetComponent<PhotonView>().IsMine == true && startAndend.text == "EndTurn")
            {
                player1.GetComponent<PlayMoment>().visit = 0;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = true;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
                
            }

            if (turnmanager.GetComponent<Turnmanager>().player2 == true && player2.GetComponent<PhotonView>().IsMine == true && startAndend.text == "StartTurn")
            {
                countdownshow.color = Color.white;
                player2.GetComponent<PlayMoment>().visit = 1;
                player2.GetComponent<TacticsMove>().turn = true;
                currentTime = 60f;
                startAndend.text = "EndTurn";
                
            }
            else if (turnmanager.GetComponent<Turnmanager>().player2 == true && player2.GetComponent<PhotonView>().IsMine == true && startAndend.text == "EndTurn")
            {
                player2.GetComponent<PlayMoment>().visit = 0;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = true;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
                
            }
            if (turnmanager.GetComponent<Turnmanager>().player3 == true && player3.GetComponent<PhotonView>().IsMine == true && startAndend.text == "StartTurn")
            {
                countdownshow.color = Color.white;
                player3.GetComponent<PlayMoment>().visit = 1;
                player3.GetComponent<TacticsMove>().turn = true;
                currentTime = 60f;
                startAndend.text = "EndTurn";
               
            }
            else if (turnmanager.GetComponent<Turnmanager>().player3 == true && player3.GetComponent<PhotonView>().IsMine == true && startAndend.text == "EndTurn")
            {
                player3.GetComponent<PlayMoment>().visit = 0;
                turnmanager.GetComponent<Turnmanager>().player1 = true;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
                
            }
        }

        // for 4 players
        else if (player4 != null)
        {
            Debug.Log("4 Players");
            if (turnmanager.GetComponent<Turnmanager>().player1 == true && player1.GetComponent<PhotonView>().IsMine == true && startAndend.text == "StartTurn")
            {
                countdownshow.color = Color.white;
                player1.GetComponent<PlayMoment>().visit = 1;
                player1.GetComponent<TacticsMove>().turn = true;
                currentTime = 60f;
                startAndend.text = "EndTurn";
            }
            else if (turnmanager.GetComponent<Turnmanager>().player1 == true && player1.GetComponent<PhotonView>().IsMine == true && startAndend.text == "EndTurn")
            {
                player1.GetComponent<PlayMoment>().visit = 0;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = true;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }

            if (turnmanager.GetComponent<Turnmanager>().player2 == true && player2.GetComponent<PhotonView>().IsMine == true && startAndend.text == "StartTurn")
            {
                countdownshow.color = Color.white;
                player2.GetComponent<PlayMoment>().visit = 1;
                player2.GetComponent<TacticsMove>().turn = true;
                currentTime = 60f;
                startAndend.text = "EndTurn";
            }
            else if (turnmanager.GetComponent<Turnmanager>().player2 == true && player2.GetComponent<PhotonView>().IsMine == true && startAndend.text == "EndTurn")
            {
                player2.GetComponent<PlayMoment>().visit = 0;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = true;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
            if (turnmanager.GetComponent<Turnmanager>().player3 == true && player3.GetComponent<PhotonView>().IsMine == true && startAndend.text == "StartTurn")
            {
                countdownshow.color = Color.white;
                player3.GetComponent<PlayMoment>().visit = 1;
                player3.GetComponent<TacticsMove>().turn = true;
                currentTime = 60f;
                startAndend.text = "EndTurn";
            }
            else if (turnmanager.GetComponent<Turnmanager>().player3 == true && player3.GetComponent<PhotonView>().IsMine == true && startAndend.text == "EndTurn")
            {
                player3.GetComponent<PlayMoment>().visit = 0;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = true;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
            if (turnmanager.GetComponent<Turnmanager>().player4 == true && player4.GetComponent<PhotonView>().IsMine == true && startAndend.text == "StartTurn")
            {
                countdownshow.color = Color.white;
                player4.GetComponent<PlayMoment>().visit = 1;
                player4.GetComponent<TacticsMove>().turn = true;
                currentTime = 60f;
                startAndend.text = "EndTurn";
            }
            else if (turnmanager.GetComponent<Turnmanager>().player4 == true && player4.GetComponent<PhotonView>().IsMine == true && startAndend.text == "EndTurn")
            {
                player4.GetComponent<PlayMoment>().visit = 0;
                turnmanager.GetComponent<Turnmanager>().player1 = true;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }

        //for 1 players
        else
        {
            Debug.Log("2 Players");
            if (turnmanager.GetComponent<Turnmanager>().player1 == true && player1.GetComponent<PhotonView>().IsMine == true && startAndend.text == "StartTurn")
            {
                countdownshow.color = Color.white;
                player1.GetComponent<PlayMoment>().visit = 1;
                player1.GetComponent<TacticsMove>().turn = true;
                currentTime = 60f;
                startAndend.text = "EndTurn";
            }
            else if (turnmanager.GetComponent<Turnmanager>().player1 == true && player1.GetComponent<PhotonView>().IsMine == true && startAndend.text == "EndTurn")
            {
                player1.GetComponent<PlayMoment>().visit = 0;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = true;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }

            if (turnmanager.GetComponent<Turnmanager>().player2 == true && player2.GetComponent<PhotonView>().IsMine == true && startAndend.text == "StartTurn")
            {
                countdownshow.color = Color.white;
                player2.GetComponent<PlayMoment>().visit = 1;
                player2.GetComponent<TacticsMove>().turn = true;
                currentTime = 60f;
                startAndend.text = "EndTurn";
            }
            else if (turnmanager.GetComponent<Turnmanager>().player2 == true && player2.GetComponent<PhotonView>().IsMine == true && startAndend.text == "EndTurn")
            {
                player2.GetComponent<PlayMoment>().visit = 0;
                turnmanager.GetComponent<Turnmanager>().player1 = true;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }  //for 1 players

    }
    void Update()
    {
        if (player1 == null)
        {
            player1 = GameObject.FindGameObjectWithTag("Player1");
            player2 = GameObject.FindGameObjectWithTag("Player2");
            player3 = GameObject.FindGameObjectWithTag("Player3");
            player4 = GameObject.FindGameObjectWithTag("Player4");
        }
        else if (player1 != null)
        {
            if (player3 != null && player4 == null)
            {
                threePlayer();
            }
            else if (player4 != null)
            {
                fourPlayer();
            }
            else
            {
                twoPlayer();
            }
        }
    }

    public void allmapcamera()
    {
        if (mapall.activeSelf == false)
        {

            mapall.SetActive(true);
        }
        else if (mapall.activeSelf == true)
        {

            mapall.SetActive(false);
        }
    }
    public void twoPlayer()
    {
        
        if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == true && startAndend.text == "StartTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player1.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player1.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = true;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }
        else if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == true && startAndend.text == "EndTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player1.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player1.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = true;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == true && startAndend.text == "StartTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player2.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player2.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = true;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();

            }
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == true && startAndend.text == "EndTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player2.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player2.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = true;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }

        else if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == false)
        {
            startAndend.text = "WaitForPlayer";
            countdownshow.text = "00";
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == false)
        {
            startAndend.text = "WaitForPlayer";
            countdownshow.text = "00";
        }

        else if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == true && startAndend.text == "WaitForPlayer")
        {
            mainEventSys.GetComponent<MainEventSys>().turnS += 1;
            mainEventSys.GetComponent<MainEventSys>().turnV += 1;
            mainEventSys.GetComponent<MainEventSys>().turnUpdate();

            startAndend.text = "StartTurn";
            currentTime = 15f;
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == true && startAndend.text == "WaitForPlayer")
        {
            startAndend.text = "StartTurn";
            currentTime = 15f;
        }
    }
    public void threePlayer()
    {
        if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == true && startAndend.text == "StartTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player1.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player1.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = true;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }
        else if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == true && startAndend.text == "EndTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player1.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player1.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = true;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == true && startAndend.text == "StartTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player2.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player2.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = true;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();



            }
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == true && startAndend.text == "EndTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player2.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player2.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = true;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();

            }
        }

        else if (player3.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player3 == true && startAndend.text == "StartTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player3.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player3.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = true;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }
        else if (player3.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player3 == true && startAndend.text == "EndTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player3.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player3.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = true;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;

            }
        }



        else if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == false)
        {
            startAndend.text = "WaitForPlayer";
            countdownshow.text = "00";
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == false)
        {
            startAndend.text = "WaitForPlayer";
            countdownshow.text = "00";
        }
        else if (player3.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player3 == false)
        {
            startAndend.text = "WaitForPlayer";
            countdownshow.text = "00";
        }

        else if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == true && startAndend.text == "WaitForPlayer")
        {
            mainEventSys.GetComponent<MainEventSys>().turnS += 1;
            mainEventSys.GetComponent<MainEventSys>().turnV += 1;
            mainEventSys.GetComponent<MainEventSys>().turnUpdate();

            startAndend.text = "StartTurn";
            currentTime = 15f;
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == true && startAndend.text == "WaitForPlayer")
        {
            startAndend.text = "StartTurn";
            currentTime = 15f;
        }
        else if (player3.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player3 == true && startAndend.text == "WaitForPlayer")
        {
            startAndend.text = "StartTurn";
            currentTime = 15f;
        }

    }
    public void fourPlayer()
    {
        
        if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == true && startAndend.text == "StartTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player1.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player1.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = true;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }
        else if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == true && startAndend.text == "EndTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player1.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player1.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = true;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == true && startAndend.text == "StartTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player2.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player2.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = true;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();

            }
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == true && startAndend.text == "EndTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player2.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player2.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = true;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();

            }
        }

        //player3 && 4
        else if (player3.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player3 == true && startAndend.text == "StartTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player3.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player3.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = true;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }
        else if (player3.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player3 == true && startAndend.text == "EndTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player3.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player3.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = false;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = true;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }
        else if (player4.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player4 == true && startAndend.text == "StartTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player4.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player4.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = true;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }
        else if (player4.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player4 == true && startAndend.text == "EndTurn")
        {
            currentTime -= 1 * Time.deltaTime;
            countdownshow.text = currentTime.ToString("0");
            if (currentTime < 10 && currentTime > 1)
            {
                countdownshow.color = Color.red;
            }
            else if (currentTime <= 0)
            {
                player4.GetComponent<PlayMoment>().visit = 0;
                currentTime = 0;
                player4.GetComponent<TacticsMove>().turn = false;
                countdownshow.color = Color.white;
                turnmanager.GetComponent<Turnmanager>().player1 = true;
                turnmanager.GetComponent<Turnmanager>().player2 = false;
                turnmanager.GetComponent<Turnmanager>().player3 = false;
                turnmanager.GetComponent<Turnmanager>().player4 = false;
                turnmanager.GetComponent<Turnmanager>().updateTurn1();
            }
        }

        else if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == false)
        {
            startAndend.text = "WaitForPlayer";
            countdownshow.text = "00";
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == false)
        {
            startAndend.text = "WaitForPlayer";
            countdownshow.text = "00";
        }
        else if (player3.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player3 == false)
        {
            startAndend.text = "WaitForPlayer";
            countdownshow.text = "00";
        }
        else if (player4.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player4 == false)
        {
            startAndend.text = "WaitForPlayer";
            countdownshow.text = "00";
        }
        else if (player1.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player1 == true && startAndend.text == "WaitForPlayer")
        {
            mainEventSys.GetComponent<MainEventSys>().turnS += 1;
            mainEventSys.GetComponent<MainEventSys>().turnV += 1;
            mainEventSys.GetComponent<MainEventSys>().turnUpdate();

            startAndend.text = "StartTurn";
            currentTime = 15f;
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player2 == true && startAndend.text == "WaitForPlayer")
        {
            startAndend.text = "StartTurn";
            currentTime = 15f;
        }
        else if (player3.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player3 == true && startAndend.text == "WaitForPlayer")
        {
            startAndend.text = "StartTurn";
            currentTime = 15f;
        }
        else if (player4.GetComponent<PhotonView>().IsMine == true && turnmanager.GetComponent<Turnmanager>().player4 == true && startAndend.text == "WaitForPlayer")
        {
            startAndend.text = "StartTurn";
            currentTime = 15f;
        }
    }
}

