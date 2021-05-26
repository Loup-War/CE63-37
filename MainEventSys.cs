using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Debug = UnityEngine.Debug;
using System.Threading;
using Photon.Pun;
using Photon.Realtime;

public class MainEventSys : MonoBehaviour
{
    public MainEvent Event;
    public GameObject inventory;

    //public Player player;

    public GameObject OBMainEvent;
    public GameObject player;
    public GameObject player1, player2, player3, player4;
    public GameObject aquaniaEV, audreaEV, ayothayaEV, fricasiaEV, lawaekEV,
                      macyrosEV, parisiaEV, remaniaEV, songverderLoisEV, talukongEV, tanaowadeeEV, tromanEV;
    public GameObject targetAttacks;

    public GameObject desir, loup, serment, asrial, orion;
    public GameObject debugBuyChurch;
    public GameObject debugChurchAttack;
    public GameObject debugThiefSuccess;
    public GameObject debugMoneyback;
    public GameObject debugThiefFail;
    public Text moneyback;

    public GameObject soldierGuardsybol;
    public GameObject soldierRoyerGuardsybol;
    public Text soldierGuardTurn;
    public Text soldierRoyerGuardTurn;

    public Text titleText;
    public Text descriptionText;
    public Text buffDesText;
    public float Eventper;
    public int[] array = { 1, 2, 3, 4, 5, 6};
    public int[] arrayevent1 = {1,2,3,4,5,6,7,8,9};
    public int[] arrayevent2 = {1,2,3,4,5,6,7};
    public int[] arrayevent3 = {1,2,3,4,5,6,7};
    public int[] arrayevent4 = {1,2,3,4,5,6,7};
    public int[] arrayevent5 = { 1, 2, 3, 4, 5, 6, 7 };
    public int[] arrayevent6 = { 1, 2};
    public int temp;
    public int countTurn;
    public int miniTurn;
    public int BarTurn;
    public int royerTurn;
    public int inventoryTurn;
    public int countTurn1;
    public int countTurn2;
    public int churchTurn;
    public int churchTurn1;
    public int countTheifTurn;
    public int countChurchTurn;
    public int turnV = 0;
    public int turnS = 0;
    public bool eventKing;
    public int eventorder1, eventorder2, eventorder3, eventorder4, eventorder5, eventorder6, eventorder7;
    public bool notfullaquaniaEV, notfullaudreaEV, notfullayothayaEV, notfullfricasiaEV, notfulllawaekEV,
               notfullmacyrosEV, notfullparisiaEV, notfullremaniaEV, notfullsongverderLoisEV, notfulltalukongEV, notfulltanaowadeeEV, notfulltromanEV;
    public int CooldownaquaniaEV, CooldownaudreaEV, CooldownayothayaEV, CooldownfricasiaEV, CooldownlawaekEV,
               CooldownmacyrosEV, CooldownparisiaEV, CooldownremaniaEV, CooldownsongverderLoisEV, CooldowntalukongEV, CooldowntanaowadeeEV, CooldowntromanEV;

    PhotonView PV;

    public GameObject turnmanager;



    private void Start()
    {

        PV = GetComponent<PhotonView>();

        TurnSys.TurnValue = turnV;
        TurnSys.TurnShow  = turnS;
        shuffle(array);
        foreach (int value in array)
        {
        }
        shuffle(arrayevent1);
        foreach (int value in arrayevent1)
        {
        }
        shuffle(arrayevent2);
        foreach (int value in arrayevent2)
        {
        }
        shuffle(arrayevent3);
        foreach (int value in arrayevent3)
        {
        }
        shuffle(arrayevent4);
        foreach (int value in arrayevent4)
        {
        }
        shuffle(arrayevent5);
        foreach (int value in arrayevent5)
        {
        }
        shuffle(arrayevent6);
        foreach (int value in arrayevent6)
        {
        }

    }
    public void TurnStartplayer()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player3 = GameObject.FindGameObjectWithTag("Player3");
        player4 = GameObject.FindGameObjectWithTag("Player4");

        if(player1.GetComponent<PhotonView>().IsMine == true)
        {
            player = GameObject.FindGameObjectWithTag("Player1");
        }
        else if(player2.GetComponent<PhotonView>().IsMine == true)
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
    public void OpenOBMainEvent()
    { 
            
        if (TurnSys.TurnValue == 15)
        {
            Resetvalueall();
            if (array[0] == 1)
            {
                eventKing = true;
                OBMainEvent.SetActive(true);
                Event.title = "ราชโองการ";
                titleText.text = Event.title;
                if (arrayevent6[0] == 1) 
                {
                    Event.description = "   จักรพรรดิเฮนรี่ที่ 3 แห่งจักวรรดิอีมอลต้องการรับบริจาคเหรียญทอง เพื่อนำเงินนั้นไปหล่อเทวรูป ผู้ใดที่บริจาคเยอะที่สุดราชาเฮนรี่ที่ 3 จะมอบรางวัล 1 ชิ้น                                              (ของรางวัลต้องเลือก 1 อย่าง)";
                    descriptionText.text = Event.description;
                    Event.buffDes = "1 ยกเลิกภาษีเข้าเมือง     2.ลบค่าศาสนจักร 3หน่วย       3.ได้รับทหารหลวง";
                    buffDesText.text = Event.buffDes;

                    for (int i = 0; i < arrayevent6.Length - 1; i++)
                    {
                        temp = arrayevent6[i + 1];
                        arrayevent6[i + 1] = arrayevent6[i];
                        arrayevent6[i] = temp;
                    }
                }
                else if (arrayevent6[0] == 2)
                {
                    Event.description = "    เจ้าชายหลุย กุชตองที่ 10 แห่งอาณาจักรองมะต้องการรับบริจาคเหรียญทอง เพื่อนำเงินนั้นไปหล่อเทวรูป ผู้ใดที่บริจาคเยอะที่สุดเจ้าชายหลุย กุชตองที่ 10 จะมอบรางวัล 1 ชิ้น                                               (ของรางวัลต้องเลือก 1 อย่าง)";
                    descriptionText.text = Event.description;
                    Event.buffDes = "1 ยกเลิกภาษีเข้าเมือง     2.ลบค่าศาสนจักร 3หน่วย       3.ได้รับทหารหลวง";
                    buffDesText.text = Event.buffDes;
                    for (int i = 0; i < arrayevent6.Length - 1; i++)
                    {
                        temp = arrayevent6[i + 1];
                        arrayevent6[i + 1] = arrayevent6[i];
                        arrayevent6[i] = temp;
                    }
                }
                else if (arrayevent6[0] == 3)
                {
                    Event.description = "   พระมหาคำรณ แห่งอาณาจักรวัดสง่าต้องการรับบริจาคเหรียญทอง เพื่อนำเงินนั้นไปหล่อเทวรูป ผู้ใดที่บริจาคเยอะที่สุดพระมหาคำรณ จะมอบรางวัล 1 ชิ้น                                               (ของรางวัลต้องเลือก 1 อย่าง)";
                    descriptionText.text = Event.description;
                    Event.buffDes = "1 ยกเลิกภาษีเข้าเมือง     2.ลบค่าศาสนจักร 3หน่วย       3.ได้รับทหารหลวง";
                    buffDesText.text = Event.buffDes;
                    for (int i = 0; i < arrayevent6.Length - 1; i++)
                    {
                        temp = arrayevent6[i + 1];
                        arrayevent6[i + 1] = arrayevent6[i];
                        arrayevent6[i] = temp;
                    }
                }
                else if (arrayevent6[0] == 4)
                {
                    fricasiaEV.GetComponent<Fricasia>().fricasiakingEvent = true;
                    Event.description = "   ราชาฮาโรลด์ แห่งหมู่เกาะวิงคิต้องการรับบริจาคเหรียญทอง เพื่อนำเงินนั้นไปหล่อเทวรูป ผู้ใดที่บริจาคเยอะที่สุดราชาฮาโรลด์ แห่งหมู่เกาะวิงคิ จะมอบรางวัล 1 ชิ้น                                               (ของรางวัลต้องเลือก 1 อย่าง)";
                    descriptionText.text = Event.description;
                    Event.buffDes = "1 ยกเลิกภาษีเข้าเมือง     2.ลบค่าศาสนจักร 3หน่วย       3.ได้รับทหารหลวง";
                    buffDesText.text = Event.buffDes;
                    for (int i = 0; i < arrayevent6.Length - 1; i++)
                    {
                        temp = arrayevent6[i + 1];
                        arrayevent6[i + 1] = arrayevent6[i];
                        arrayevent6[i] = temp;
                    }
                }
                else if (arrayevent6[0] == 5)
                {
                    Event.description = "   ฮ่องเต้ฮั่นเซี่ยนต้องการรับบริจาคเหรียญทอง เพื่อนำเงินนั้นไปหล่อเทวรูป ผู้ใดที่บริจาคเยอะที่สุดฮ่องเต้ฮั่นเซี่ยน แห่งอาณาจักรต้าลู่ จะมอบรางวัล 1 ชิ้น                                               (ของรางวัลต้องเลือก 1 อย่าง)";
                    descriptionText.text = Event.description;
                    Event.buffDes = "1 ยกเลิกภาษีเข้าเมือง     2.ลบค่าศาสนจักร 3หน่วย       3.ได้รับทหารหลวง";
                    buffDesText.text = Event.buffDes;
                    for (int i = 0; i < arrayevent6.Length - 1; i++)
                    {
                        temp = arrayevent6[i + 1];
                        arrayevent6[i + 1] = arrayevent6[i];
                        arrayevent6[i] = temp;
                    }
                }
                turnV = 0;
                TurnSys.TurnValue = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }
            else if (array[0] == 2)
            {
                OBMainEvent.SetActive(true);
                Event.title = "ภัยแล้ง";
                titleText.text = Event.title;
                if (arrayevent1[0] == 1)
                {
                    Event.description = "   ภัยแล้งมาเยือนทำให้เมืองทรอมัน ณ จักวรรดิอีมอลขาดแคลนเสบียง ทำให้ข้าวราคาแพงยิ่งขึ้น ถ้าคุณขายข้าวให้เมืองทรอมัน ณ จักวรรดิอีมอลในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาข้าวภายในเมืองทรอมันเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    tromanEV.GetComponent<Troman>().tromanevent = true;
                    tromanEV.GetComponent<Troman>().eventrice = 0.5f;
                    for (int i = 0; i < arrayevent1.Length - 1; i++)
                    {
                        temp = arrayevent1[i + 1];
                        arrayevent1[i + 1] = arrayevent1[i];
                        arrayevent1[i] = temp;
                    }
                }
                else if (arrayevent1[0] == 2)
                {
                    Event.description = "   ภัยแล้งมาเยือนทำให้เมืองซองเวอร์เดอร์ลัว ณ อาณาจักรองมะขาดแคลนเสบียง ทำให้ข้าวราคาแพงยิ่งขึ้น ถ้าคุณขายข้าวให้เมืองซองเวอร์เดอร์ลัว ณ อาณาจักรองมะในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาข้าวภายในเมืองซองเวอร์เดอร์ลัวเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    songverderLoisEV.GetComponent<SongverderLois>().songverderLoisevent = true;
                    songverderLoisEV.GetComponent<SongverderLois>().eventrice = 0.5f;
                    for (int i = 0; i < arrayevent1.Length - 1; i++)
                    {
                        temp = arrayevent1[i + 1];
                        arrayevent1[i + 1] = arrayevent1[i];
                        arrayevent1[i] = temp;
                    }
                }
                else if (arrayevent1[0] == 3)
                {
                    Event.description = "   ภัยแล้งมาเยือนทำให้เมืองปารีเซีย ณ อาณาจักรองมะขาดแคลนเสบียง ทำให้ข้าวราคาแพงยิ่งขึ้น ถ้าคุณขายข้าวให้เมืองปารีเซีย ณ อาณาจักรองมะในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาข้าวภายในเมืองปารีเซียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    parisiaEV.GetComponent<Parisia>().parisiaevent = true;
                    parisiaEV.GetComponent<Parisia>().eventrice = 0.5f;
                    for (int i = 0; i < arrayevent1.Length - 1; i++)
                    {
                        temp = arrayevent1[i + 1];
                        arrayevent1[i + 1] = arrayevent1[i];
                        arrayevent1[i] = temp;
                    }
                }
                else if (arrayevent1[0] == 4)
                {
                    Event.description = "   ภัยแล้งมาเยือนทำให้กรุงอโยธยา ณ อาณาจักรวัดสง่าขาดแคลนเสบียง ทำให้ข้าวราคาแพงยิ่งขึ้น ถ้าคุณขายข้าวให้กรุงอโยธยา ณ อาณาจักรวัดสง่าในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาข้าวภายในเมืองกรุงอโยธยาเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    ayothayaEV.GetComponent<Ayothaya>().ayothayaevent = true;
                    ayothayaEV.GetComponent<Ayothaya>().eventrice = 0.5f;
                    for (int i = 0; i < arrayevent1.Length - 1; i++)
                    {
                        temp = arrayevent1[i + 1];
                        arrayevent1[i + 1] = arrayevent1[i];
                        arrayevent1[i] = temp;
                    }
                }
                else if (arrayevent1[0] == 5)
                {
                    Event.description = "   ภัยแล้งมาเยือนทำให้เมืองละแวก ณ อาณาจักรวัดสง่าขาดแคลนเสบียง ทำให้ข้าวราคาแพงยิ่งขึ้น ถ้าคุณขายข้าวให้เมืองละแวก ณ อาณาจักรวัดสง่าในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาข้าวภายในเมืองละแวกเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    lawaekEV.GetComponent<Lawaek>().lawaekevent = true;
                    lawaekEV.GetComponent<Lawaek>().eventrice = 0.5f;
                    for (int i = 0; i < arrayevent1.Length - 1; i++)
                    {
                        temp = arrayevent1[i + 1];
                        arrayevent1[i + 1] = arrayevent1[i];
                        arrayevent1[i] = temp;
                    }
                }
                else if (arrayevent1[0] == 6)
                {
                    Event.description = "    ภัยแล้งมาเยือนทำให้เมืองออเดรีย ณ หมู่เกาะวิงคิขาดแคลนเสบียง ทำให้ข้าวราคาแพงยิ่งขึ้น ถ้าคุณขายข้าวให้เมืองออเดรีย ณ หมู่เกาะวิงคิในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาข้าวภายในเมืองออเดรีย 50 %";
                    buffDesText.text = Event.buffDes;
                    audreaEV.GetComponent<Audrea>().audreaevent = true;
                    audreaEV.GetComponent<Audrea>().eventrice = 0.5f;
                    for (int i = 0; i < arrayevent1.Length - 1; i++)
                    {
                        temp = arrayevent1[i + 1];
                        arrayevent1[i + 1] = arrayevent1[i];
                        arrayevent1[i] = temp;
                    }
                }
                else if (arrayevent1[0] == 7)
                {
                    Event.description = "   ภัยแล้งมาเยือนทำให้เมืองฟริกาเซีย ณ หมู่เกาะวิงคิขาดแคลนเสบียง ทำให้ข้าวราคาแพงยิ่งขึ้น ถ้าคุณขายข้าวให้เมืองฟริกาเซีย ณ หมู่เกาะวิงคิในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาข้าวภายในเมืองฟริกาเซียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    fricasiaEV.GetComponent<Fricasia>().fricasiaevent = true;
                    fricasiaEV.GetComponent<Fricasia>().eventrice = 0.5f;
                    for (int i = 0; i < arrayevent1.Length - 1; i++)
                    {
                        temp = arrayevent1[i + 1];
                        arrayevent1[i + 1] = arrayevent1[i];
                        arrayevent1[i] = temp;
                    }
                }
                else if (arrayevent1[0] == 8)
                {
                    Event.description = "   ภัยแล้งมาเยือนทำให้เมืองต้าลู่กง ณ อาณาจักรต้าลู่ขาดแคลนเสบียง ทำให้ข้าวราคาแพงยิ่งขึ้น ถ้าคุณขายข้าวให้เมืองต้าลู่กง ณ อาณาจักรต้าลู่ในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาข้าวภายในเมืองต้าลู่กง 50 %";
                    buffDesText.text = Event.buffDes;
                    talukongEV.GetComponent<Talukong>().talukongevent = true;
                    talukongEV.GetComponent<Talukong>().eventrice = 0.5f;
                    for (int i = 0; i < arrayevent1.Length - 1; i++)
                    {
                        temp = arrayevent1[i + 1];
                        arrayevent1[i + 1] = arrayevent1[i];
                        arrayevent1[i] = temp;
                    }
                }
                else if (arrayevent1[0] == 9)
                {
                    Event.description = "   ภัยแล้งมาเยือนทำให้เมืองไอยคุปต์ ณ อาณาจักรครีโอโปริสขาดแคลนเสบียง ทำให้ข้าวราคาแพงยิ่งขึ้น ถ้าคุณขายข้าวให้เมืองไอยคุปต์ ณ อาณาจักรครีโอโปริสในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาข้าวภายในเมืองไอยคุปต์ 50 %";
                    buffDesText.text = Event.buffDes;
                    tanaowadeeEV.GetComponent<Tanaowadee>().tanaowadeeevent = true;
                    tanaowadeeEV.GetComponent<Tanaowadee>().eventrice = 0.5f;
                    for (int i = 0; i < arrayevent1.Length - 1; i++)
                    {
                        temp = arrayevent1[i + 1];
                        arrayevent1[i + 1] = arrayevent1[i];
                        arrayevent1[i] = temp;
                    }
                }
                turnV = 0;
                TurnSys.TurnValue = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }
            else if (array[0] == 3)
            {
                OBMainEvent.SetActive(true);
                Event.title = "สงคราม";
                titleText.text = Event.title;
                if (arrayevent2[0] == 1)
                {
                    Event.description = "   จักรพรรดิเฮนรี่ที่ 3 แห่งจักวรรดิอีมอล ทรงประกาศสงครามกับ พระมหาคำรณ แห่งอาณาจักรวัดสง่า การเกิดสงครามขึ้นระหว่างอาณาจักรวัดสง่าและจักวรรดิอีมอล ทำให้ประเทศทั้งสองต้องการอาวุธและชุดเกราะมากขึ้น ถ้าคุณขายอาวุธและชุดเกราะให้เมืองมาซีรอสและเมืองละแวก ในระยะเวลานี้ คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาอาวุธและชุดเกราะในเมืองมาซีรอสและเมืองละแวกเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    macyrosEV.GetComponent<Macyros>().macyrosevent = true;
                    macyrosEV.GetComponent<Macyros>().eventarmor = 0.5f;
                    lawaekEV.GetComponent<Lawaek>().lawaekevent = true;
                    lawaekEV.GetComponent<Lawaek>().eventarmor = 0.5f;
                    for (int i = 0; i < arrayevent2.Length - 1; i++)
                    {
                        temp = arrayevent2[i + 1];
                        arrayevent2[i + 1] = arrayevent2[i];
                        arrayevent2[i] = temp;
                    }
                }
                else if (arrayevent2[0] == 2)
                {
                    Event.description = "   จักรพรรดิเฮนรี่ที่ 3 แห่งจักวรรดิอีมอล ทรงประกาศสงครามกับ เจ้าชายหลุย กุชตองที่ 10 แห่งอาณาจักรองมะ การเกิดสงครามขึ้นระหว่างอาณาจักรอองมะและจักรวรรดิอีมอล ทำให้ประเทศทั้งสองต้องการอาวุธและชุดเกราะมากขึ้น ถ้าคุณขายอาวุธและชุดเกราะให้เมืองมาซีรอสและเมืองปารีเซีย ในระยะเวลานี้ คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาอาวุธและชุดเกราะในเมืองมาซีรอสและเมืองปารีเซียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    macyrosEV.GetComponent<Macyros>().macyrosevent = true;
                    macyrosEV.GetComponent<Macyros>().eventarmor = 0.5f;
                    parisiaEV.GetComponent<Parisia>().parisiaevent = true;
                    parisiaEV.GetComponent<Parisia>().eventarmor = 0.5f;
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        temp = arrayevent2[i + 1];
                        arrayevent2[i + 1] = arrayevent2[i];
                        arrayevent2[i] = temp;
                    }
                }
                else if (arrayevent2[0] == 3)
                {
                    Event.description = "    จักรพรรดิเฮนรี่ที่ 3 แห่งจักวรรดิอีมอล ทรงประกาศสงครามกับ ฟาโรห์นาการาซ แห่งอาณาจักรครีโอโปริส การเกิดสงครามขึ้นระหว่างอาณาจักรครีโอโปริสและจักรวรรดิอีมอล ทำให้ประเทศทั้งสองต้องการอาวุธและชุดเกราะมากขึ้น ถ้าคุณขายอาวุธและชุดเกราะให้เมืองรีมาเนียและเมืองไอยคุปต์ ในระยะเวลานี้ คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาอาวุธและชุดเกราะในเมืองมาซีรอสและเมืองไอยคุปต์เพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    macyrosEV.GetComponent<Macyros>().macyrosevent = true;
                    macyrosEV.GetComponent<Macyros>().eventarmor = 0.5f;
                    tanaowadeeEV.GetComponent<Tanaowadee>().tanaowadeeevent = true;
                    tanaowadeeEV.GetComponent<Tanaowadee>().eventarmor = 0.5f;
                    for (int i = 0; i < arrayevent2.Length - 1; i++)
                    {
                        temp = arrayevent2[i + 1];
                        arrayevent2[i + 1] = arrayevent2[i];
                        arrayevent2[i] = temp;
                    }
                }
                else if (arrayevent2[0] == 4)
                {
                    Event.description = "   จักรพรรดิเฮนรี่ที่ 3 แห่งจักวรรดิอีมอล ทรงประกาศสงครามกับ ราชาฮาโรลด์ แห่งหมู่เกาะวิงคิ การเกิดสงครามขึ้นระหว่างหมู่เกาะวิงคิและจักรวรรดิอีมอล ทำให้ประเทศทั้งสองต้องการอาวุธและชุดเกราะมากขึ้น ถ้าคุณขายอาวุธและชุดเกราะให้เมืองทรอมันและเมืองฟริกาเซีย ในระยะเวลานี้ คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาอาวุธและชุดเกราะในเมืองฟริกาเซียและเมืองทรอมันเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    fricasiaEV.GetComponent<Fricasia>().fricasiaevent = true;
                    fricasiaEV.GetComponent<Fricasia>().eventarmor = 0.5f;
                    tromanEV.GetComponent<Troman>().tromanevent = true;
                    tromanEV.GetComponent<Troman>().eventarmor = 0.5f;
                    for (int i = 0; i < arrayevent2.Length - 1; i++)
                    {
                        temp = arrayevent2[i + 1];
                        arrayevent2[i + 1] = arrayevent2[i];
                        arrayevent2[i] = temp;
                    }
                }
                else if (arrayevent2[0] == 5)
                {
                    Event.description = "   จักรพรรดิเฮนรี่ที่ 3 แห่งจักวรรดิอีมอล ทรงประกาศสงครามกับ ฮ่องเต้ฮั่นเซี่ยน แห่งอาณาจักรต้าลู่ การเกิดสงครามขึ้นระหว่างอาณาจักรต้าลู่และจักรวรรดิอีมอล ทำให้ประเทศทั้งสองต้องการอาวุธและชุดเกราะมากขึ้น ถ้าคุณขายอาวุธและชุดเกราะให้เมืองอควาเนียและเมืองต้าลู่กง ในระยะเวลานี้ คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาอาวุธและชุดเกราะในเมืองต้าลู่กงและเมืองอควเนียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    talukongEV.GetComponent<Talukong>().talukongevent = true;
                    talukongEV.GetComponent<Talukong>().eventarmor = 0.5f;
                    aquaniaEV.GetComponent<Aquania>().aquaniaevent = true;
                    aquaniaEV.GetComponent<Aquania>().eventarmor = 0.5f;
                    for (int i = 0; i < arrayevent2.Length - 1; i++)
                    {
                        temp = arrayevent2[i + 1];
                        arrayevent2[i + 1] = arrayevent2[i];
                        arrayevent2[i] = temp;
                    }
                }
                else if (arrayevent2[0] == 6)
                {
                    Event.description = "   เจ้าชายหลุย กุชตองที่ 10 แห่งอาณาจักรองมะ ทรงประกาศสงครามกับ พระมหาคำรณ แห่งอาณาจักรวัดสง่า การเกิดสงครามขึ้นระหว่างอาณาจักรวัดสง่าและอาณาจักรองมะ ทำให้ประเทศทั้งสองต้องการอาวุธและชุดเกราะมากขึ้น ถ้าคุณขายอาวุธและชุดเกราะให้กรุงอโยธยาและเมืองซองเวอร์เดอร์ลัว ในระยะเวลานี้ คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาอาวุธและชุดเกราะในกรุงอโยธยาและเมืองซองเวอร์เดอร์ลัวเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    ayothayaEV.GetComponent<Ayothaya>().ayothayaevent = true;
                    ayothayaEV.GetComponent<Ayothaya>().eventarmor = 0.5f;
                    songverderLoisEV.GetComponent<SongverderLois>().songverderLoisevent = true;
                    songverderLoisEV.GetComponent<SongverderLois>().eventarmor = 0.5f;
                    for (int i = 0; i < arrayevent2.Length - 1; i++)
                    {
                        temp = arrayevent2[i + 1];
                        arrayevent2[i + 1] = arrayevent2[i];
                        arrayevent2[i] = temp;
                    }
                }
                else if (arrayevent2[0] == 7)
                {
                    Event.description = "    เจ้าชายหลุย กุชตองที่ 10 แห่งอาณาจักรองมะ ทรงประกาศสงครามกับ ฟาโรห์นาการาซ แห่งอาณาจักรครีโอโปริส การเกิดสงครามขึ้นระหว่างอาณาจักรอองมะและอาณาจักรครีโอโปริส ทำให้ประเทศทั้งสองต้องการอาวุธและชุดเกราะมากขึ้น ถ้าคุณขายอาวุธและชุดเกราะให้เมืองไอยคุปต์และเมืองปารีเซีย ในระยะเวลานี้ คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาอาวุธและชุดเกราะในเมืองไอยคุปต์และเมืองปารีเซียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    tanaowadeeEV.GetComponent<Tanaowadee>().tanaowadeeevent = true;
                    tanaowadeeEV.GetComponent<Tanaowadee>().eventarmor = 0.5f;
                    parisiaEV.GetComponent<Parisia>().parisiaevent = true;
                    parisiaEV.GetComponent<Parisia>().eventarmor = 0.5f;
                    for (int i = 0; i < arrayevent2.Length - 1; i++)
                    {
                        temp = arrayevent2[i + 1];
                        arrayevent2[i + 1] = arrayevent2[i];
                        arrayevent2[i] = temp;
                    }
                }
                turnV = 0;
                TurnSys.TurnValue = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }
            else if (array[0] == 4)
            {
                OBMainEvent.SetActive(true);
                Event.title = "ขยายเมือง";
                titleText.text = Event.title;
                if (arrayevent3[0] == 1)
                {
                    Event.description = "    จักรพรรดิเฮนรี่ที่ 3 แห่งจักวรรดิอีมอล ทรงต้องการขยายเมืองทรอมันให้ใหญ่ขึ้น แต่ไม้ในคลังไม่เพียงพอทำให้จักวรรดิอีมอลต้องการไม้จำนวนมาก ถ้าคุณขายไม้ไปให้เมืองทรอมัน ณ จักวรรดิอีมอลในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาไม้ในเมืองทรอมันเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    tromanEV.GetComponent<Troman>().tromanevent = true;
                    tromanEV.GetComponent<Troman>().eventwood = 0.5f;
                    for (int i = 0; i < arrayevent3.Length - 1; i++)
                    {
                        temp = arrayevent3[i + 1];
                        arrayevent3[i + 1] = arrayevent3[i];
                        arrayevent3[i] = temp;
                    }
                }
                else if (arrayevent3[0] == 2)
                {
                    Event.description = "    จักรพรรดิเฮนรี่ที่ 3 แห่งจักวรรดิอีมอล ทรงต้องการขยายเมืองรีมาเนียให้ใหญ่ขึ้น แต่ไม้ในคลังไม่เพียงพอทำให้จักวรรดิอีมอลต้องการไม้จำนวนมาก ถ้าคุณขายไม้ไปให้เมืองรีมาเนีย ณ จักวรรดิอีมอลในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาไม้ในเมืองรีมาเนียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    remaniaEV.GetComponent<Remania>().remaniaevent = true;
                    remaniaEV.GetComponent<Remania>().eventwood = 0.5f;
                    for (int i = 0; i < arrayevent3.Length - 1; i++)
                    {
                        temp = arrayevent3[i + 1];
                        arrayevent3[i + 1] = arrayevent3[i];
                        arrayevent3[i] = temp;
                    }
                }
                else if (arrayevent3[0] == 3)
                {
                    Event.description = "    จ้าชายหลุย กุชตองที่ 10 แห่งอาณาจักรองมะ ทรงต้องการขยายเมืองปารีเซียให้ใหญ่ขึ้น แต่ไม้ในคลังไม่เพียงพอทำให้อาณาจักรองมะต้องการไม้จำนวนมาก ถ้าคุณขายไม้ไปให้เมืองปารีเซีย ณ อาณาจักรองมะในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาไม้ในเมืองปารีเซียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    parisiaEV.GetComponent<Parisia>().parisiaevent = true;
                    parisiaEV.GetComponent<Parisia>().eventwood = 0.5f;
                    for (int i = 0; i < arrayevent3.Length - 1; i++)
                    {
                        temp = arrayevent3[i + 1];
                        arrayevent3[i + 1] = arrayevent3[i];
                        arrayevent3[i] = temp;
                    }
                }
                else if (arrayevent3[0] == 4)
                {
                    Event.description = "     พระมหาคำรณ แห่งอาณาจักรวัดสง่า ทรงต้องการขยายเมืองละแวกให้ใหญ่ขึ้น แต่ไม้ในคลังไม่เพียงพอทำให้อาณาจักรวัดสง่าต้องการไม้จำนวนมาก ถ้าคุณขายไม้ไปให้เมืองละแวก ณ อาณาจักรวัดสง่าในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาไม้ในเมืองละแวกเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    lawaekEV.GetComponent<Lawaek>().lawaekevent = true;
                    lawaekEV.GetComponent<Lawaek>().eventwood = 0.5f;
                    for (int i = 0; i < arrayevent3.Length - 1; i++)
                    {
                        temp = arrayevent3[i + 1];
                        arrayevent3[i + 1] = arrayevent3[i];
                        arrayevent3[i] = temp;
                    }
                }
                else if (arrayevent3[0] == 5)
                {
                    Event.description = "     ราชาฮาโรลด์ แห่งหมู่เกาะวิงคิ ทรงต้องการขยายเมืองฟริกาเซียให้ใหญ่ขึ้น แต่ไม้ในคลังไม่เพียงพอทำให้หมู่เกาะวิงคิต้องการไม้จำนวนมาก ถ้าคุณขายไม้ไปให้เมืองฟริกาเซีย ณ หมู่เกาะวิงคิในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาไม้ในเมืองฟริกาเซียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    fricasiaEV.GetComponent<Fricasia>().fricasiaevent = true;
                    fricasiaEV.GetComponent<Fricasia>().eventwood = 0.5f;
                    for (int i = 0; i < arrayevent3.Length - 1; i++)
                    {
                        temp = arrayevent3[i + 1];
                        arrayevent3[i + 1] = arrayevent3[i];
                        arrayevent3[i] = temp;
                    }
                }
                else if (arrayevent3[0] == 6)
                {
                    Event.description = "      ฮ่องเต้ฮั่นเซี่ยน แห่งอาณาจักรต้าลู่ ทรงต้องการขยายเมืองต้าลู่กงให้ใหญ่ขึ้น แต่ไม้ในคลังไม่เพียงพอทำให้อาณาจักรต้าลู่ต้องการไม้จำนวนมาก ถ้าคุณขายไม้ไปให้เมืองต้าลู่กง ณ อาณาจักรต้าลู่ในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาไม้ในเมืองต้าลู่กงเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    talukongEV.GetComponent<Talukong>().talukongevent = true;
                    talukongEV.GetComponent<Talukong>().eventwood = 0.5f;
                    for (int i = 0; i < arrayevent3.Length - 1; i++)
                    {
                        temp = arrayevent3[i + 1];
                        arrayevent3[i + 1] = arrayevent3[i];
                        arrayevent3[i] = temp;
                    }
                }
                else if (arrayevent3[0] == 7)
                {
                    Event.description = "     ฟาโรห์นาการาซ แห่งอาณาจักรครีโอโปริส ทรงต้องการขยายเมืองไอยคุปต์ให้ใหญ่ขึ้น แต่ไม้ในคลังไม่เพียงพอทำให้อาณาจักรครีโอโปริสต้องการไม้จำนวนมาก ถ้าคุณขายไม้ไปให้เมืองไอยคุปต์ ณ อาณาจักรครีโอโปริสในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาไม้ในเมืองไอยคุปต์เพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    tanaowadeeEV.GetComponent<Tanaowadee>().tanaowadeeevent = true;
                    tanaowadeeEV.GetComponent<Tanaowadee>().eventwood = 0.5f;
                    for (int i = 0; i < arrayevent3.Length - 1; i++)
                    {
                        temp = arrayevent3[i + 1];
                        arrayevent3[i + 1] = arrayevent3[i];
                        arrayevent3[i] = temp;
                    }
                }
                turnV = 0;
                TurnSys.TurnValue = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }
            else if (array[0] == 5)
            {
                OBMainEvent.SetActive(true);
                Event.title = "สงครามทางเศรษฐกิจ";
                titleText.text = Event.title;
                if (arrayevent4[0] == 1)
                {
                    Event.description = "   จักรพรรดิเฮนรี่ที่ 3 แห่งจักวรรดิอีมอล ทรงต้องการแสดงความมั่งคั่งของพระองค์ ให้การซื้อขายเพชรภายในเมืองทรอมันราคาสูงขึ้น ถ้าคุณขายเพชรให้กับเมืองทรอมัน ภายในจักวรรดิอีมอลในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาเพชรในเมืองทรอมันเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    tromanEV.GetComponent<Troman>().tromanevent = true;
                    tromanEV.GetComponent<Troman>().eventgem = 0.5f;
                    for (int i = 0; i < arrayevent4.Length - 1; i++)
                    {
                        temp = arrayevent4[i + 1];
                        arrayevent4[i + 1] = arrayevent4[i];
                        arrayevent4[i] = temp;
                    }
                }
                else if (arrayevent4[0] == 2)
                {
                    Event.description = "   เจ้าชายหลุย กุชตองที่ 10 แห่งอาณาจักรองมะ ทรงต้องการแสดงความมั่งคั่งของพระองค์ ให้การซื้อขายเพชรภายในเมืองซองเวอร์เดอร์ลัวราคาสูงขึ้น ถ้าคุณขายเพชรให้กับเมืองซองเวอร์เดอร์ลัว ภายในอาณาจักรองมะในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาเพชรในเมืองซองเวอร์เดอร์ลัวเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    songverderLoisEV.GetComponent<SongverderLois>().songverderLoisevent = true;
                    songverderLoisEV.GetComponent<SongverderLois>().eventgem = 0.5f;
                    for (int i = 0; i < arrayevent4.Length - 1; i++)
                    {
                        temp = arrayevent4[i + 1];
                        arrayevent4[i + 1] = arrayevent4[i];
                        arrayevent4[i] = temp;
                    }
                }
                else if (arrayevent4[0] == 3)
                {
                    Event.description = "    เจ้าชายหลุย กุชตองที่ 10 แห่งอาณาจักรองมะ ทรงต้องการแสดงความมั่งคั่งของพระองค์ ให้การซื้อขายเพชรภายในเมืองปารีเซียราคาสูงขึ้น ถ้าคุณขายเพชรให้กับเมืองปารีเซีย ภายในอาณาจักรองมะในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาเพชรในเมืองปารีเซียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    parisiaEV.GetComponent<Parisia>().parisiaevent = true;
                    parisiaEV.GetComponent<Parisia>().eventgem = 0.5f;
                    for (int i = 0; i < arrayevent4.Length - 1; i++)
                    {
                        temp = arrayevent4[i + 1];
                        arrayevent4[i + 1] = arrayevent4[i];
                        arrayevent4[i] = temp;
                    }
                }
                else if (arrayevent4[0] == 4)
                {
                    Event.description = "    พระมหาคำรณ แห่งอาณาจักรวัดสง่า ทรงต้องการแสดงความมั่งคั่งของพระองค์ ให้การซื้อขายเพชรภายในกรุงอโยธยาราคาสูงขึ้น ถ้าคุณขายเพชรให้กับกรุงอโยธยา ภายในอาณาจักรวัดสง่าในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาเพชรในกรุงอโยธยาเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    ayothayaEV.GetComponent<Ayothaya>().ayothayaevent = true;
                    ayothayaEV.GetComponent<Ayothaya>().eventgem = 0.5f;
                    for (int i = 0; i < arrayevent4.Length - 1; i++)
                    {
                        temp = arrayevent4[i + 1];
                        arrayevent4[i + 1] = arrayevent4[i];
                        arrayevent4[i] = temp;
                    }

                }
                else if (arrayevent4[0] == 5)
                {
                    Event.description = "   ราชาฮาโรลด์ แห่งหมู่เกาะวิงคิ ทรงต้องการแสดงความมั่งคั่งของพระองค์ ให้การซื้อขายเพชรภายในเมืองออเดรียราคาสูงขึ้น ถ้าคุณขายเพชรให้กับเมืองออเดรีย ภายในหมู่เกาะวิงคิในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาเพชรในเมืองออเดรียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    audreaEV.GetComponent<Audrea>().audreaevent = true;
                    audreaEV.GetComponent<Audrea>().eventgem = 0.5f;
                    for (int i = 0; i < arrayevent4.Length - 1; i++)
                    {
                        temp = arrayevent4[i + 1];
                        arrayevent4[i + 1] = arrayevent4[i];
                        arrayevent4[i] = temp;
                    }

                }
                else if (arrayevent4[0] == 6)
                {
                    Event.description = "    ฮ่องเต้ฮั่นเซี่ยน แห่งอาณาจักรต้าลู่ ทรงต้องการแสดงความมั่งคั่งของพระองค์ ให้การซื้อขายเพชรภายในเมืองต้าลู่กงราคาสูงขึ้น ถ้าคุณขายเพชรให้กับเมืองต้าลู่กง ภายในอาณาจักรต้าลู่ในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาเพชรในเมืองต้าลู่กงเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    talukongEV.GetComponent<Talukong>().talukongevent = true;
                    talukongEV.GetComponent<Talukong>().eventgem = 0.5f;
                    for (int i = 0; i < arrayevent4.Length - 1; i++)
                    {
                        temp = arrayevent4[i + 1];
                        arrayevent4[i + 1] = arrayevent4[i];
                        arrayevent4[i] = temp;
                    }

                }
                else if (arrayevent4[0] == 7)
                {
                    Event.description = "    ฟาโรห์นาการาซ แห่งอาณาจักรครีโอโปริส ทรงต้องการแสดงความมั่งคั่งของพระองค์ ให้การซื้อขายเพชรภายในเมืองไอยคุปต์ราคาสูงขึ้น ถ้าคุณขายเพชรให้กับเมืองไอยคุปต์ ภายในอาณาจักรครีโอโปริสในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาเพชรในเมืองไอยคุปต์เพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    tanaowadeeEV.GetComponent<Tanaowadee>().tanaowadeeevent = true;
                    tanaowadeeEV.GetComponent<Tanaowadee>().eventgem = 0.5f;
                    for (int i = 0; i < arrayevent4.Length - 1; i++)
                    {
                        temp = arrayevent4[i + 1];
                        arrayevent4[i + 1] = arrayevent4[i];
                        arrayevent4[i] = temp;
                    }

                }
                turnV = 0;
                TurnSys.TurnValue = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }
            else if (array[0] == 6)
            {
                OBMainEvent.SetActive(true);
                Event.title = "ฤดูหนาวมาเยือน";
                titleText.text = Event.title;
                if (arrayevent5[0] == 1) 
                { 
                    Event.description = "   ฤดูหนาวมาเยือนทำให้เมืองทรอมัน ณ จักวรรดิอีมอลขาดแคลนเครื่องนุ่งห่ม ทำให้ราคาของผ้าแพงยิ่งขึ้น ถ้าคุณขายผ้าให้เมืองทรอมัน ณ จักวรรดิอีมอลในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาผ้าในเมืองทรอมันเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    tromanEV.GetComponent<Troman>().tromanevent = true;
                    tromanEV.GetComponent<Troman>().eventcloth = 0.5f;
                    for (int i = 0; i < arrayevent5.Length - 1; i++)
                    {
                        temp = arrayevent5[i + 1];
                        arrayevent5[i + 1] = arrayevent5[i];
                        arrayevent5[i] = temp;
                    }
                }
                else if (arrayevent5[0] == 2)
                {
                    Event.description = "   ฤดูหนาวมาเยือนทำให้เมืองรีมาเนีย ณ จักวรรดิอีมอลขาดแคลนเครื่องนุ่งห่ม ทำให้ราคาของผ้าแพงยิ่งขึ้น ถ้าคุณขายผ้าให้เมืองรีมาเนีย ณ จักวรรดิอีมอลในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาผ้าในเมืองรีมาเนียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    remaniaEV.GetComponent<Remania>().remaniaevent = true;
                    remaniaEV.GetComponent<Remania>().eventcloth = 0.5f;
                    for (int i = 0; i < arrayevent5.Length - 1; i++)
                    {
                        temp = arrayevent5[i + 1];
                        arrayevent5[i + 1] = arrayevent5[i];
                        arrayevent5[i] = temp;
                    }
                }
                else if (arrayevent5[0] == 3)
                {
                    Event.description = "   ฤดูหนาวมาเยือนทำให้เมืองซองเวอร์เดอร์ลัว ณ อาณาจักรองมะขาดแคลนเครื่องนุ่งห่ม ทำให้ราคาของผ้าแพงยิ่งขึ้น ถ้าคุณขายผ้าให้เมืองทรอมัน ณ อาณาจักรองมะในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาผ้าในเมืองซองเวอร์เดอร์ลัวเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    songverderLoisEV.GetComponent<SongverderLois>().songverderLoisevent = true;
                    songverderLoisEV.GetComponent<SongverderLois>().eventcloth = 0.5f;
                    for (int i = 0; i < arrayevent5.Length - 1; i++)
                    {
                        temp = arrayevent5[i + 1];
                        arrayevent5[i + 1] = arrayevent5[i];
                        arrayevent5[i] = temp;
                    }
                }
                else if (arrayevent5[0] == 4)
                {
                    Event.description = "   ฤดูหนาวมาเยือนทำให้เมืองละแวก ณ อาณาจักรวัดสง่าขาดแคลนเครื่องนุ่งห่ม ทำให้ราคาของผ้าแพงยิ่งขึ้น ถ้าคุณขายผ้าให้เมืองละแวก ณ อาณาจักรวัดสง่าในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาผ้าในเมืองละแวกเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    lawaekEV.GetComponent<Lawaek>().lawaekevent = true;
                    lawaekEV.GetComponent<Lawaek>().eventcloth = 0.5f;
                    for (int i = 0; i < arrayevent5.Length - 1; i++)
                    {
                        temp = arrayevent5[i + 1];
                        arrayevent5[i + 1] = arrayevent5[i];
                        arrayevent5[i] = temp;
                    }
                }
                else if (arrayevent5[0] == 5)
                {
                    Event.description = "   ฤดูหนาวมาเยือนทำให้เมืองฟริกาเซีย ณ แห่งหมู่เกาะวิงคิขาดแคลนเครื่องนุ่งห่ม ทำให้ราคาของผ้าแพงยิ่งขึ้น ถ้าคุณขายผ้าให้เมืองฟริกาเซีย ณ แห่งหมู่เกาะวิงคิในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาผ้าในเมืองฟริกาเซียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    fricasiaEV.GetComponent<Fricasia>().fricasiaevent = true;
                    fricasiaEV.GetComponent<Fricasia>().eventcloth = 0.5f;
                    for (int i = 0; i < arrayevent5.Length - 1; i++)
                    {
                        temp = arrayevent5[i + 1];
                        arrayevent5[i + 1] = arrayevent5[i];
                        arrayevent5[i] = temp;
                    }
                }
                else if (arrayevent5[0] == 6)
                {
                    Event.description = "   ฤดูหนาวมาเยือนทำให้เมืองออเดรีย ณ แห่งหมู่เกาะวิงคิขาดแคลนเครื่องนุ่งห่ม ทำให้ราคาของผ้าแพงยิ่งขึ้น ถ้าคุณขายผ้าให้เมืองออเดรีย ณ แห่งหมู่เกาะวิงคิในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาผ้าในเมืองออเดรียเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    audreaEV.GetComponent<Audrea>().audreaevent = true;
                    audreaEV.GetComponent<Audrea>().eventcloth = 0.5f;
                    for (int i = 0; i < arrayevent5.Length - 1; i++)
                    {
                        temp = arrayevent5[i + 1];
                        arrayevent5[i + 1] = arrayevent5[i];
                        arrayevent5[i] = temp;
                    }
                }
                else if (arrayevent5[0] == 7)
                {
                    Event.description = "   ฤดูหนาวมาเยือนทำให้เมืองต้าลู่กง ณ แห่งอาณาจักรต้าลู่ขาดแคลนเครื่องนุ่งห่ม ทำให้ราคาของผ้าแพงยิ่งขึ้น ถ้าคุณขายผ้าให้เมืองต้าลู่กง ณ แห่งอาณาจักรต้าลู่ในระยะเวลานี้คุณจะได้รับเงินเพิ่มขึ้น";
                    descriptionText.text = Event.description;
                    Event.buffDes = "ราคาผ้าในเมืองต้าลู่กงเพิ่มขึ้นอีก 50 %";
                    buffDesText.text = Event.buffDes;
                    talukongEV.GetComponent<Talukong>().talukongevent = true;
                    talukongEV.GetComponent<Talukong>().eventcloth = 0.5f;
                    for (int i = 0; i < arrayevent5.Length - 1; i++)
                    {
                        temp = arrayevent5[i + 1];
                        arrayevent5[i + 1] = arrayevent5[i];
                        arrayevent5[i] = temp;
                    }
                }
                turnV = 0;
                TurnSys.TurnValue = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }
            Debug.Log("บริจาคให้กิลที่สังกัด 500 ทอง");
            player.GetComponent<PlayerMoney>().money -= 500;
        }
        TurnStun();
        TurnSoldier();
        TurnMoneyback();
        TurnTheifAttack();
        TurnGuildcruch();
        TurnChurchAttack();
        TurnSolderRoyer();
        AddAmountFull();



    }
    public void AcceptEvent()
    {
        OBMainEvent.SetActive(false);
        Event.isActive = true;
        //player.Event = Event;
    }
    public void shuffle(int[] array)
    {
        int p = array.Length;
        for (int n = p - 1; n > 0; n--)
        {
            int r = Random.Range(0, n);
            int t = array[r];
            array[r] = array[n];
            array[n] = t;
        }
    }

    public void EventShuffle()
    {
        shuffle(array);
        foreach (int value in array)
        {
            Debug.Log(value);
        }
    }
    public void PathValue()
    {
        miniTurn = 1;
    }
    public void TurnStun()
    {
        if (miniTurn == 1)
        {
            countTurn = turnS;
            miniTurn = 0;
        }
        else if (countTurn == turnS - 2 && countTurn != 0)
        {
            countTurn = 0;
            player.GetComponent<PlayMoment>().move = 1;
        }
    }
    public void TurnSoldier()
    {
        if (player != null)
        {
            if (BarTurn == 1)
            {
                countTurn1 = turnS;
                BarTurn = 0;
            }
            else if (countTurn1 == turnS && countTurn1 != 0 && player.GetComponent<PlayMoment>().soldierGuard > 0)
            {
                player.GetComponent<PlayMoment>().soldierGuard -= 1;
                countTurn1 += 1;
                soldierGuardsybol.SetActive(true);
                soldierGuardTurn.text = "มีทหารคุ้มกัน " + player.GetComponent<PlayMoment>().soldierGuard.ToString() + " Turn";
            }
            else if (player.GetComponent<PlayMoment>().soldierGuard == 0 && countTurn1 != 0)
            {
                countTurn1 = 0;
                soldierGuardsybol.SetActive(false);
            }
        }
    }
    public void TurnSolderRoyer()
    {
        if (player != null)
        {
            if (player.GetComponent<PlayMoment>().soldierRoyerGuard == 10 && royerTurn == 0)
            {
                royerTurn = turnS;
            }
            else if (player.GetComponent<PlayMoment>().soldierRoyerGuard > 0 && royerTurn == turnS && royerTurn != 0)
            {
                player.GetComponent<PlayMoment>().soldierRoyerGuard -= 1;
                royerTurn += 1;
                soldierRoyerGuardsybol.SetActive(true);
                soldierRoyerGuardTurn.text = "มีทหารหลวงคุ้มกัน " + player.GetComponent<PlayMoment>().soldierRoyerGuard.ToString() + " Turn";
            }
            else if (player.GetComponent<PlayMoment>().soldierRoyerGuard == 0 && royerTurn != 0)
            {
                royerTurn = 0;
                soldierRoyerGuardsybol.SetActive(false);
            }
        }
    }

    public void TurnTheifAttack()
    {
        if (player != null)
        {
            if (player.GetComponent<PlayMoment>().thiefAttack == true && countTheifTurn == 0)
            {
                countTheifTurn = turnS;
                Debug.Log("อีก3Turn");
            }
            else if (player.GetComponent<PlayMoment>().thiefAttack == true && countTheifTurn == turnS - 3 && countTheifTurn != 0)
            {
                if (player.GetComponent<PlayMoment>().soldierGuard == 1)
                {
                    debugThiefFail.SetActive(true);
                    if (player1.GetComponent<PhotonView>().IsMine == true)
                    {
                        Debug.Log("คืนค่า");
                        targetAttacks.GetComponent<TargetAttack>().p1theifAttack = 0;
                        targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                        countTheifTurn = 0;
                    }
                    else if (player2.GetComponent<PhotonView>().IsMine == true)
                    {
                        targetAttacks.GetComponent<TargetAttack>().p2theifAttack = 0;
                        targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                        countTheifTurn = 0;
                    }
                    else if (player3.GetComponent<PhotonView>().IsMine == true)
                    {
                        targetAttacks.GetComponent<TargetAttack>().p3theifAttack = 0;
                        targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                        countTheifTurn = 0;
                    }
                    else if (player4.GetComponent<PhotonView>().IsMine == true)
                    {
                        targetAttacks.GetComponent<TargetAttack>().p4theifAttack = 0;
                        targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                        countTheifTurn = 0;
                    }
                }
                else if(player.GetComponent<PlayMoment>().soldierGuard == 0)
                {
                    debugThiefSuccess.SetActive(true);
                    player.GetComponent<PlayerMoney>().money -= (player.GetComponent<PlayerMoney>().money * 0.2f);
                    if (player1.GetComponent<PhotonView>().IsMine == true)
                    {
                        Debug.Log("คืนค่าหลังโดนปล้น");
                        targetAttacks.GetComponent<TargetAttack>().p1theifAttack = 0;
                        targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                        countTheifTurn = 0;
                    }
                    else if (player2.GetComponent<PhotonView>().IsMine == true)
                    {
                        targetAttacks.GetComponent<TargetAttack>().p2theifAttack = 0;
                        targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                        countTheifTurn = 0;
                    }
                    else if (player3.GetComponent<PhotonView>().IsMine == true)
                    {
                        targetAttacks.GetComponent<TargetAttack>().p3theifAttack = 0;
                        targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                        countTheifTurn = 0;
                    }
                    else if (player4.GetComponent<PhotonView>().IsMine == true)
                    {
                        targetAttacks.GetComponent<TargetAttack>().p4theifAttack = 0;
                        targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                        countTheifTurn = 0;
                    }
                }
            }
        }
    }

    public void TurnChurchAttack()
    {
        if (player != null)
        {
            if (player.GetComponent<PlayMoment>().churchAttack == true && countChurchTurn == 0)
            {
                countChurchTurn = turnS;
                player.GetComponent<PlayMoment>().Noshop = true;
                Debug.Log("ซื้อของไม่ได้อีก3Turn");
                debugChurchAttack.SetActive(true);

            }
            else if (player.GetComponent<PlayMoment>().churchAttack == true && countChurchTurn == turnS - 3 && countChurchTurn != 0)
            {
                debugBuyChurch.SetActive(true);
                if (player1.GetComponent<PhotonView>().IsMine == true)
                {
                    if (player1.GetComponent<PlayMoment>().guild == "Desir") 
                    {
                        desir.GetComponent<Desir>().churchcost += 1;
                    }
                    else if(player1.GetComponent<PlayMoment>().guild == "Loup")
                    {
                        loup.GetComponent<Loup>().churchcost += 1;
                    }
                    else if (player1.GetComponent<PlayMoment>().guild == "Serment")
                    {
                        serment.GetComponent<Serment>().churchcost += 1;
                    }
                    else if (player1.GetComponent<PlayMoment>().guild == "Asrial")
                    {
                        asrial.GetComponent<Asrial>().churchcost += 1;
                    }
                    else if (player1.GetComponent<PlayMoment>().guild == "Orion")
                    {
                        orion.GetComponent<Orion>().churchcost += 1;
                    }
                    player.GetComponent<PlayMoment>().churchAttack = false;
                    player.GetComponent<PlayMoment>().Noshop = false;
                    targetAttacks.GetComponent<TargetAttack>().p1churchAttack = 0;
                    targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                    countChurchTurn = 0;
                }
                else if (player2.GetComponent<PhotonView>().IsMine == true)
                {
                    if (player2.GetComponent<PlayMoment>().guildConfirm == "Desir")
                    {

                        desir.GetComponent<Desir>().churchcost += 1;
                    }
                    else if (player2.GetComponent<PlayMoment>().guildConfirm == "Loup")
                    {
                        loup.GetComponent<Loup>().churchcost += 1;
                    }
                    else if (player2.GetComponent<PlayMoment>().guildConfirm == "Serment")
                    {
                        serment.GetComponent<Serment>().churchcost += 1;
                    }
                    else if (player2.GetComponent<PlayMoment>().guildConfirm == "Asrial")
                    {
                        asrial.GetComponent<Asrial>().churchcost += 1;
                    }
                    else if (player2.GetComponent<PlayMoment>().guildConfirm == "Orion")
                    {
                        orion.GetComponent<Orion>().churchcost += 1;
                    }
                    player.GetComponent<PlayMoment>().churchAttack = false;
                    player.GetComponent<PlayMoment>().Noshop = false;
                    targetAttacks.GetComponent<TargetAttack>().p2churchAttack = 0;
                    targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                    countChurchTurn = 0;
                }
                else if (player3.GetComponent<PhotonView>().IsMine == true)
                {
                    if (player3.GetComponent<PlayMoment>().guildConfirm == "Desir")
                    {
                        desir.GetComponent<Desir>().churchcost += 1;
                    }
                    else if (player3.GetComponent<PlayMoment>().guildConfirm == "Loup")
                    {
                        loup.GetComponent<Loup>().churchcost += 1;
                    }
                    else if (player3.GetComponent<PlayMoment>().guildConfirm == "Serment")
                    {
                        serment.GetComponent<Serment>().churchcost += 1;
                    }
                    else if (player3.GetComponent<PlayMoment>().guildConfirm == "Asrial")
                    {
                        asrial.GetComponent<Asrial>().churchcost += 1;
                    }
                    else if (player3.GetComponent<PlayMoment>().guildConfirm == "Orion")
                    {
                        orion.GetComponent<Orion>().churchcost += 1;
                    }
                    player.GetComponent<PlayMoment>().churchAttack = false;
                    player.GetComponent<PlayMoment>().Noshop = false;
                    targetAttacks.GetComponent<TargetAttack>().p3churchAttack = 0;
                    targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                    countChurchTurn = 0;
                }
                else if (player4.GetComponent<PhotonView>().IsMine == true)
                {
                    if (player4.GetComponent<PlayMoment>().guildConfirm == "Desir")
                    {
                        desir.GetComponent<Desir>().churchcost += 1;
                    }
                    else if (player4.GetComponent<PlayMoment>().guildConfirm == "Loup")
                    {
                        loup.GetComponent<Loup>().churchcost += 1;
                    }
                    else if (player4.GetComponent<PlayMoment>().guildConfirm == "Serment")
                    {
                        serment.GetComponent<Serment>().churchcost += 1;
                    }
                    else if (player4.GetComponent<PlayMoment>().guildConfirm == "Asrial")
                    {
                        asrial.GetComponent<Asrial>().churchcost += 1;
                    }
                    else if (player4.GetComponent<PlayMoment>().guildConfirm == "Orion")
                    {
                        orion.GetComponent<Orion>().churchcost += 1;
                    }
                    player.GetComponent<PlayMoment>().churchAttack = false;
                    player.GetComponent<PlayMoment>().Noshop = false;
                    targetAttacks.GetComponent<TargetAttack>().p4churchAttack = 0;
                    targetAttacks.GetComponent<TargetAttack>().SharingattackAll();
                    countChurchTurn = 0;
                }
            }
        }
    }

    public void TurnGuildcruch()
    {
        if (churchTurn == 1 && churchTurn1 == 0)
        {
            churchTurn1 = turnS;
        }
        else if(churchTurn == 1 && churchTurn1 != 0 && churchTurn1 == turnS - 3)
        {
            player.GetComponent<PlayMoment>().guildConfirm = "";
            player.GetComponent<PlayMoment>().guild = "";
            churchTurn = 0;
            churchTurn1 = 0;
        }
    }
    public void TurnMoneyback()
    {
        if (inventoryTurn == 1)
        {
            countTurn2 = turnS;
            inventoryTurn = 0;
        }
        else if (countTurn2 == turnS - 3 && countTurn2 != 0)
        {
            countTurn2 = 0;
            player.GetComponent<PlayerMoney>().money += inventory.GetComponent<Inventory>().moneystack;
            moneyback.text = "ได้เงินคืนจากการฝากขาย" + inventory.GetComponent<Inventory>().moneystack.ToString();
            debugMoneyback.SetActive(true);
            inventory.GetComponent<Inventory>().moneystack = 0;

        }
    }

    public void turnUpdate()
    {

        PV.RPC("RPC_turn", RpcTarget.AllBuffered, turnV, turnS);

    }

    public void MainEventOrder()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PV.RPC("Eventorder", RpcTarget.AllBuffered, array,arrayevent1, arrayevent2,arrayevent3, arrayevent4, arrayevent5, arrayevent6);
        }
    }

    [PunRPC]
    void RPC_turn(int turnVNew, int turnSNew)
    {
        TurnSys.TurnValue = turnVNew;
        TurnSys.TurnShow = turnSNew;
        turnS = turnSNew;
        turnV = turnVNew;

    }

    [PunRPC]
    void Eventorder(int [] arrayevent ,int[] arrayeventorder1, int[] arrayeventorder2, int[] arrayeventorder3, int[] arrayeventorder4, int[] arrayeventorder5, int[] arrayeventorder6)
    {
        array = arrayevent;
        arrayevent1 = arrayeventorder1;
        arrayevent2 = arrayeventorder2;
        arrayevent3 = arrayeventorder3;
        arrayevent4 = arrayeventorder4;
        arrayevent5 = arrayeventorder5;
        arrayevent6 = arrayeventorder6;
    }

    private void Update()
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
        OpenOBMainEvent();
    }

    public void Resetvalueall()
    {
        eventKing = false;

        aquaniaEV.GetComponent<Aquania>().aquaniaevent = false;
        aquaniaEV.GetComponent<Aquania>().eventrice = 0f;
        aquaniaEV.GetComponent<Aquania>().eventarmor = 0f;
        aquaniaEV.GetComponent<Aquania>().eventcloth = 0f;
        aquaniaEV.GetComponent<Aquania>().eventgem = 0f;
        aquaniaEV.GetComponent<Aquania>().eventwood = 0f;
        aquaniaEV.GetComponent<Aquania>().eventiron = 0f;

        audreaEV.GetComponent<Audrea>().audreaevent = false;
        audreaEV.GetComponent<Audrea>().eventrice = 0f;
        audreaEV.GetComponent<Audrea>().eventarmor = 0f;
        audreaEV.GetComponent<Audrea>().eventcloth = 0f;
        audreaEV.GetComponent<Audrea>().eventgem = 0f;
        audreaEV.GetComponent<Audrea>().eventwood = 0f;
        audreaEV.GetComponent<Audrea>().eventiron = 0f;

        ayothayaEV.GetComponent<Ayothaya>().ayothayaevent = false;
        ayothayaEV.GetComponent<Ayothaya>().eventrice = 0f;
        ayothayaEV.GetComponent<Ayothaya>().eventarmor = 0f;
        ayothayaEV.GetComponent<Ayothaya>().eventcloth = 0f;
        ayothayaEV.GetComponent<Ayothaya>().eventgem = 0f;
        ayothayaEV.GetComponent<Ayothaya>().eventwood = 0f;
        ayothayaEV.GetComponent<Ayothaya>().eventiron = 0f;

        fricasiaEV.GetComponent<Fricasia>().fricasiaevent = false;
        fricasiaEV.GetComponent<Fricasia>().eventrice = 0f;
        fricasiaEV.GetComponent<Fricasia>().eventarmor = 0f;
        fricasiaEV.GetComponent<Fricasia>().eventcloth = 0f;
        fricasiaEV.GetComponent<Fricasia>().eventgem = 0f;
        fricasiaEV.GetComponent<Fricasia>().eventwood = 0f;
        fricasiaEV.GetComponent<Fricasia>().eventiron = 0f;
        fricasiaEV.GetComponent<Fricasia>().fricasiakingEvent = false;

        lawaekEV.GetComponent<Lawaek>().lawaekevent = false;
        lawaekEV.GetComponent<Lawaek>().eventrice = 0f;
        lawaekEV.GetComponent<Lawaek>().eventarmor = 0f;
        lawaekEV.GetComponent<Lawaek>().eventcloth = 0f;
        lawaekEV.GetComponent<Lawaek>().eventgem = 0f;
        lawaekEV.GetComponent<Lawaek>().eventwood = 0f;
        lawaekEV.GetComponent<Lawaek>().eventiron = 0f;

        macyrosEV.GetComponent<Macyros>().macyrosevent = false;
        macyrosEV.GetComponent<Macyros>().eventrice = 0f;
        macyrosEV.GetComponent<Macyros>().eventarmor = 0f;
        macyrosEV.GetComponent<Macyros>().eventcloth = 0f;
        macyrosEV.GetComponent<Macyros>().eventgem = 0f;
        macyrosEV.GetComponent<Macyros>().eventwood = 0f;
        macyrosEV.GetComponent<Macyros>().eventiron = 0f;

        parisiaEV.GetComponent<Parisia>().parisiaevent = false;
        parisiaEV.GetComponent<Parisia>().eventrice = 0f;
        parisiaEV.GetComponent<Parisia>().eventarmor = 0f;
        parisiaEV.GetComponent<Parisia>().eventcloth = 0f;
        parisiaEV.GetComponent<Parisia>().eventgem = 0f;
        parisiaEV.GetComponent<Parisia>().eventwood = 0f;
        parisiaEV.GetComponent<Parisia>().eventiron = 0f;

        remaniaEV.GetComponent<Remania>().remaniaevent = false;
        remaniaEV.GetComponent<Remania>().eventrice = 0f;
        remaniaEV.GetComponent<Remania>().eventarmor = 0f;
        remaniaEV.GetComponent<Remania>().eventcloth = 0f;
        remaniaEV.GetComponent<Remania>().eventgem = 0f;
        remaniaEV.GetComponent<Remania>().eventwood = 0f;
        remaniaEV.GetComponent<Remania>().eventiron = 0f;

        songverderLoisEV.GetComponent<SongverderLois>().songverderLoisevent = false;
        songverderLoisEV.GetComponent<SongverderLois>().eventrice = 0f;
        songverderLoisEV.GetComponent<SongverderLois>().eventarmor = 0f;
        songverderLoisEV.GetComponent<SongverderLois>().eventcloth = 0f;
        songverderLoisEV.GetComponent<SongverderLois>().eventgem = 0f;
        songverderLoisEV.GetComponent<SongverderLois>().eventwood = 0f;
        songverderLoisEV.GetComponent<SongverderLois>().eventiron = 0f;

        talukongEV.GetComponent<Talukong>().talukongevent = false;
        talukongEV.GetComponent<Talukong>().eventrice = 0f;
        talukongEV.GetComponent<Talukong>().eventarmor = 0f;
        talukongEV.GetComponent<Talukong>().eventcloth = 0f;
        talukongEV.GetComponent<Talukong>().eventgem = 0f;
        talukongEV.GetComponent<Talukong>().eventwood = 0f;
        talukongEV.GetComponent<Talukong>().eventiron = 0f;

        tanaowadeeEV.GetComponent<Tanaowadee>().tanaowadeeevent = false;
        tanaowadeeEV.GetComponent<Tanaowadee>().eventrice = 0f;
        tanaowadeeEV.GetComponent<Tanaowadee>().eventarmor = 0f;
        tanaowadeeEV.GetComponent<Tanaowadee>().eventcloth = 0f;
        tanaowadeeEV.GetComponent<Tanaowadee>().eventgem = 0f;
        tanaowadeeEV.GetComponent<Tanaowadee>().eventwood = 0f;
        tanaowadeeEV.GetComponent<Tanaowadee>().eventiron = 0f;

        tromanEV.GetComponent<Troman>().tromanevent = false;
        tromanEV.GetComponent<Troman>().eventrice = 0f;
        tromanEV.GetComponent<Troman>().eventarmor = 0f;
        tromanEV.GetComponent<Troman>().eventcloth = 0f;
        tromanEV.GetComponent<Troman>().eventgem = 0f;
        tromanEV.GetComponent<Troman>().eventwood = 0f;
        tromanEV.GetComponent<Troman>().eventiron = 0f; ;
    }

    public void AddAmountFull()
    {
        if(CooldownfricasiaEV == 0 && notfullfricasiaEV == true)
        {
            CooldownfricasiaEV = turnS;
        }
        else if(CooldownfricasiaEV == turnS - 3 && notfullfricasiaEV == true)
        {
            CooldownfricasiaEV = 0;
            notfullfricasiaEV = false;
            fricasiaEV.GetComponent<Fricasia>().amountlaza1 = 250;
            fricasiaEV.GetComponent<Fricasia>().amountlaza2 = 170;
            fricasiaEV.GetComponent<Fricasia>().amountlaza3 = 100;
            fricasiaEV.GetComponent<Fricasia>().amountlaza4 = 60;
            fricasiaEV.GetComponent<Fricasia>().amountlaza5 = 35;
            fricasiaEV.GetComponent<Fricasia>().amountlaza6 = 10;
            fricasiaEV.GetComponent<Fricasia>().amountlaza7 = 5;
            fricasiaEV.GetComponent<Fricasia>().amountshopp1 = 250;
            fricasiaEV.GetComponent<Fricasia>().amountshopp2 = 170;
            fricasiaEV.GetComponent<Fricasia>().amountshopp3 = 100;
            fricasiaEV.GetComponent<Fricasia>().amountshopp4 = 60;
            fricasiaEV.GetComponent<Fricasia>().amountshopp5 = 35;
            fricasiaEV.GetComponent<Fricasia>().amountshopp6 = 10;
            fricasiaEV.GetComponent<Fricasia>().amountshopp7 = 5;
            fricasiaEV.GetComponent<Fricasia>().amountnef1 = 250;
            fricasiaEV.GetComponent<Fricasia>().amountnef2 = 170;
            fricasiaEV.GetComponent<Fricasia>().amountnef3 = 100;
            fricasiaEV.GetComponent<Fricasia>().amountnef4 = 60;
            fricasiaEV.GetComponent<Fricasia>().amountnef5 = 35;
            fricasiaEV.GetComponent<Fricasia>().amountnef6 = 10;
            fricasiaEV.GetComponent<Fricasia>().amountnef7 = 5;
        }
        
        if (CooldownaudreaEV == 0 && notfullaudreaEV == true)
        {
            CooldownaudreaEV = turnS;
        }
        else if (CooldownaudreaEV == turnS - 3 && notfullaudreaEV == true)
        {
            CooldownaudreaEV = 0;
            notfullaudreaEV = false;
            audreaEV.GetComponent<Audrea>().amountlaza1 = 250;
            audreaEV.GetComponent<Audrea>().amountlaza2 = 170;
            audreaEV.GetComponent<Audrea>().amountlaza3 = 100;
            audreaEV.GetComponent<Audrea>().amountlaza4 = 60;
            audreaEV.GetComponent<Audrea>().amountlaza5 = 35;
            audreaEV.GetComponent<Audrea>().amountlaza6 = 10;
            audreaEV.GetComponent<Audrea>().amountlaza7 = 5;
            audreaEV.GetComponent<Audrea>().amountshopp1 = 250;
            audreaEV.GetComponent<Audrea>().amountshopp2 = 170;
            audreaEV.GetComponent<Audrea>().amountshopp3 = 100;
            audreaEV.GetComponent<Audrea>().amountshopp4 = 60;
            audreaEV.GetComponent<Audrea>().amountshopp5 = 35;
            audreaEV.GetComponent<Audrea>().amountshopp6 = 10;
            audreaEV.GetComponent<Audrea>().amountshopp7 = 5;
            audreaEV.GetComponent<Audrea>().amountnef1 = 250;
            audreaEV.GetComponent<Audrea>().amountnef2 = 170;
            audreaEV.GetComponent<Audrea>().amountnef3 = 100;
            audreaEV.GetComponent<Audrea>().amountnef4 = 60;
            audreaEV.GetComponent<Audrea>().amountnef5 = 35;
            audreaEV.GetComponent<Audrea>().amountnef6 = 10;
            audreaEV.GetComponent<Audrea>().amountnef7 = 5;
        }
       
        if (CooldowntalukongEV == 0 && notfulltalukongEV == true)
        {
            CooldowntalukongEV = turnS;
        }
        else if (CooldowntalukongEV == turnS - 3 && notfulltalukongEV == true)
        {
            CooldowntalukongEV = 0;
            notfulltalukongEV = false;
             talukongEV.GetComponent<Talukong>().amountlaza1 = 250;
             talukongEV.GetComponent<Talukong>().amountlaza2 = 170;
             talukongEV.GetComponent<Talukong>().amountlaza3 = 100;
             talukongEV.GetComponent<Talukong>().amountlaza4 = 60;
             talukongEV.GetComponent<Talukong>().amountlaza5 = 35;
             talukongEV.GetComponent<Talukong>().amountlaza6 = 10;
             talukongEV.GetComponent<Talukong>().amountlaza7 = 5;
             talukongEV.GetComponent<Talukong>().amountshopp1 = 250;
             talukongEV.GetComponent<Talukong>().amountshopp2 = 170;
             talukongEV.GetComponent<Talukong>().amountshopp3 = 100;
             talukongEV.GetComponent<Talukong>().amountshopp4 = 60;
             talukongEV.GetComponent<Talukong>().amountshopp5 = 35;
             talukongEV.GetComponent<Talukong>().amountshopp6 = 10;
             talukongEV.GetComponent<Talukong>().amountshopp7 = 5;
             talukongEV.GetComponent<Talukong>().amountnef1 = 250;
             talukongEV.GetComponent<Talukong>().amountnef2 = 170;
             talukongEV.GetComponent<Talukong>().amountnef3 = 100;
             talukongEV.GetComponent<Talukong>().amountnef4 = 60;
             talukongEV.GetComponent<Talukong>().amountnef5 = 35;
             talukongEV.GetComponent<Talukong>().amountnef6 = 10;
             talukongEV.GetComponent<Talukong>().amountnef7 = 5;

        }

        if (CooldowntromanEV == 0 && notfulltromanEV == true)
        {
            CooldowntromanEV = turnS;
        }
        else if (CooldowntromanEV == turnS - 3 && notfulltromanEV == true)
        {
            CooldowntromanEV = 0;
            notfulltromanEV = false;
            tromanEV.GetComponent<Troman>().amountlaza1 = 250;
            tromanEV.GetComponent<Troman>().amountlaza2 = 170;
            tromanEV.GetComponent<Troman>().amountlaza3 = 100;
            tromanEV.GetComponent<Troman>().amountlaza4 = 60;
            tromanEV.GetComponent<Troman>().amountlaza5 = 35;
            tromanEV.GetComponent<Troman>().amountlaza6 = 10;
            tromanEV.GetComponent<Troman>().amountlaza7 = 5;
            tromanEV.GetComponent<Troman>().amountshopp1 = 250;
            tromanEV.GetComponent<Troman>().amountshopp2 = 170;
            tromanEV.GetComponent<Troman>().amountshopp3 = 100;
            tromanEV.GetComponent<Troman>().amountshopp4 = 60;
            tromanEV.GetComponent<Troman>().amountshopp5 = 35;
            tromanEV.GetComponent<Troman>().amountshopp6 = 10;
            tromanEV.GetComponent<Troman>().amountshopp7 = 5;
            tromanEV.GetComponent<Troman>().amountnef1 = 250;
            tromanEV.GetComponent<Troman>().amountnef2 = 170;
            tromanEV.GetComponent<Troman>().amountnef3 = 100;
            tromanEV.GetComponent<Troman>().amountnef4 = 60;
            tromanEV.GetComponent<Troman>().amountnef5 = 35;
            tromanEV.GetComponent<Troman>().amountnef6 = 10;
            tromanEV.GetComponent<Troman>().amountnef7 = 5;
        }

        if (CooldownremaniaEV == 0 && notfullremaniaEV == true)
        {
            CooldownremaniaEV = turnS;
        }
        else if (CooldownremaniaEV == turnS - 3 && notfullremaniaEV == true)
        {
            CooldownremaniaEV = 0;
            notfullremaniaEV = false;
            remaniaEV.GetComponent<Remania>().amountlaza1 = 250;
            remaniaEV.GetComponent<Remania>().amountlaza2 = 170;
            remaniaEV.GetComponent<Remania>().amountlaza3 = 100;
            remaniaEV.GetComponent<Remania>().amountlaza4 = 60;
            remaniaEV.GetComponent<Remania>().amountlaza5 = 35;
            remaniaEV.GetComponent<Remania>().amountlaza6 = 10;
            remaniaEV.GetComponent<Remania>().amountlaza7 = 5;
            remaniaEV.GetComponent<Remania>().amountshopp1 = 250;
            remaniaEV.GetComponent<Remania>().amountshopp2 = 170;
            remaniaEV.GetComponent<Remania>().amountshopp3 = 100;
            remaniaEV.GetComponent<Remania>().amountshopp4 = 60;
            remaniaEV.GetComponent<Remania>().amountshopp5 = 35;
            remaniaEV.GetComponent<Remania>().amountshopp6 = 10;
            remaniaEV.GetComponent<Remania>().amountshopp7 = 5;
            remaniaEV.GetComponent<Remania>().amountnef1 = 250;
            remaniaEV.GetComponent<Remania>().amountnef2 = 170;
            remaniaEV.GetComponent<Remania>().amountnef3 = 100;
            remaniaEV.GetComponent<Remania>().amountnef4 = 60;
            remaniaEV.GetComponent<Remania>().amountnef5 = 35;
            remaniaEV.GetComponent<Remania>().amountnef6 = 10;
            remaniaEV.GetComponent<Remania>().amountnef7 = 5;

        }

        if (CooldownmacyrosEV == 0 && notfullmacyrosEV == true)
        {
            CooldownmacyrosEV = turnS;
        }
        else if (CooldownmacyrosEV == turnS - 3 && notfullmacyrosEV == true)
        {
            CooldownmacyrosEV = 0;
            notfullmacyrosEV = false;
            macyrosEV.GetComponent<Macyros>().amountlaza1 = 250;
            macyrosEV.GetComponent<Macyros>().amountlaza2 = 170;
            macyrosEV.GetComponent<Macyros>().amountlaza3 = 100;
            macyrosEV.GetComponent<Macyros>().amountlaza4 = 60;
            macyrosEV.GetComponent<Macyros>().amountlaza5 = 35;
            macyrosEV.GetComponent<Macyros>().amountlaza6 = 10;
            macyrosEV.GetComponent<Macyros>().amountlaza7 = 5;
            macyrosEV.GetComponent<Macyros>().amountshopp1 = 250;
            macyrosEV.GetComponent<Macyros>().amountshopp2 = 170;
            macyrosEV.GetComponent<Macyros>().amountshopp3 = 100;
            macyrosEV.GetComponent<Macyros>().amountshopp4 = 60;
            macyrosEV.GetComponent<Macyros>().amountshopp5 = 35;
            macyrosEV.GetComponent<Macyros>().amountshopp6 = 10;
            macyrosEV.GetComponent<Macyros>().amountshopp7 = 5;
            macyrosEV.GetComponent<Macyros>().amountnef1 = 250;
            macyrosEV.GetComponent<Macyros>().amountnef2 = 170;
            macyrosEV.GetComponent<Macyros>().amountnef3 = 100;
            macyrosEV.GetComponent<Macyros>().amountnef4 = 60;
            macyrosEV.GetComponent<Macyros>().amountnef5 = 35;
            macyrosEV.GetComponent<Macyros>().amountnef6 = 10;
            macyrosEV.GetComponent<Macyros>().amountnef7 = 5;

        }

        if (CooldownaquaniaEV == 0 && notfullaquaniaEV == true)
        {
            CooldownaquaniaEV = turnS;
        }
        else if (CooldownaquaniaEV == turnS - 3 && notfullaquaniaEV == true)
        {
            CooldownaquaniaEV = 0;
            notfullaquaniaEV = false;
            aquaniaEV.GetComponent<Aquania>().amountlaza1 = 250;
            aquaniaEV.GetComponent<Aquania>().amountlaza2 = 170;
            aquaniaEV.GetComponent<Aquania>().amountlaza3 = 100;
            aquaniaEV.GetComponent<Aquania>().amountlaza4 = 60;
            aquaniaEV.GetComponent<Aquania>().amountlaza5 = 35;
            aquaniaEV.GetComponent<Aquania>().amountlaza6 = 10;
            aquaniaEV.GetComponent<Aquania>().amountlaza7 = 5;
            aquaniaEV.GetComponent<Aquania>().amountshopp1 = 250;
            aquaniaEV.GetComponent<Aquania>().amountshopp2 = 170;
            aquaniaEV.GetComponent<Aquania>().amountshopp3 = 100;
            aquaniaEV.GetComponent<Aquania>().amountshopp4 = 60;
            aquaniaEV.GetComponent<Aquania>().amountshopp5 = 35;
            aquaniaEV.GetComponent<Aquania>().amountshopp6 = 10;
            aquaniaEV.GetComponent<Aquania>().amountshopp7 = 5;
            aquaniaEV.GetComponent<Aquania>().amountnef1 = 250;
            aquaniaEV.GetComponent<Aquania>().amountnef2 = 170;
            aquaniaEV.GetComponent<Aquania>().amountnef3 = 100;
            aquaniaEV.GetComponent<Aquania>().amountnef4 = 60;
            aquaniaEV.GetComponent<Aquania>().amountnef5 = 35;
            aquaniaEV.GetComponent<Aquania>().amountnef6 = 10;
            aquaniaEV.GetComponent<Aquania>().amountnef7 = 5;
        }

        if (CooldowntanaowadeeEV == 0 && notfulltanaowadeeEV == true)
        {
            CooldowntanaowadeeEV = turnS;
        }
        else if (CooldowntanaowadeeEV == turnS - 3 && notfulltanaowadeeEV == true)
        {
            CooldowntanaowadeeEV = 0;
            notfulltanaowadeeEV = false;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountlaza1 = 250;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountlaza2 = 170;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountlaza3 = 100;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountlaza4 = 60;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountlaza5 = 35;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountlaza6 = 10;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountlaza7 = 5;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountshopp1 = 250;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountshopp2 = 170;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountshopp3 = 100;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountshopp4 = 60;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountshopp5 = 35;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountshopp6 = 10;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountshopp7 = 5;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountnef1 = 250;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountnef2 = 170;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountnef3 = 100;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountnef4 = 60;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountnef5 = 35;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountnef6 = 10;
             tanaowadeeEV.GetComponent<Tanaowadee>().amountnef7 = 5;

        }

        if (CooldownayothayaEV == 0 && notfullayothayaEV == true)
        {
            CooldownayothayaEV = turnS;
        }
        else if (CooldownayothayaEV == turnS - 3 && notfullayothayaEV == true)
        {
            CooldownayothayaEV = 0;
            notfullayothayaEV = false;
            ayothayaEV.GetComponent<Ayothaya>().amountlaza1 = 250;
            ayothayaEV.GetComponent<Ayothaya>().amountlaza2 = 170;
            ayothayaEV.GetComponent<Ayothaya>().amountlaza3 = 100;
            ayothayaEV.GetComponent<Ayothaya>().amountlaza4 = 60;
            ayothayaEV.GetComponent<Ayothaya>().amountlaza5 = 35;
            ayothayaEV.GetComponent<Ayothaya>().amountlaza6 = 10;
            ayothayaEV.GetComponent<Ayothaya>().amountlaza7 = 5;
            ayothayaEV.GetComponent<Ayothaya>().amountshopp1 = 250;
            ayothayaEV.GetComponent<Ayothaya>().amountshopp2 = 170;
            ayothayaEV.GetComponent<Ayothaya>().amountshopp3 = 100;
            ayothayaEV.GetComponent<Ayothaya>().amountshopp4 = 60;
            ayothayaEV.GetComponent<Ayothaya>().amountshopp5 = 35;
            ayothayaEV.GetComponent<Ayothaya>().amountshopp6 = 10;
            ayothayaEV.GetComponent<Ayothaya>().amountshopp7 = 5;
            ayothayaEV.GetComponent<Ayothaya>().amountnef1 = 250;
            ayothayaEV.GetComponent<Ayothaya>().amountnef2 = 170;
            ayothayaEV.GetComponent<Ayothaya>().amountnef3 = 100;
            ayothayaEV.GetComponent<Ayothaya>().amountnef4 = 60;
            ayothayaEV.GetComponent<Ayothaya>().amountnef5 = 35;
            ayothayaEV.GetComponent<Ayothaya>().amountnef6 = 10;
            ayothayaEV.GetComponent<Ayothaya>().amountnef7 = 5;

        }

        if (CooldownlawaekEV == 0 && notfulllawaekEV == true)
        {
            CooldownlawaekEV = turnS;
        }
        else if (CooldownlawaekEV == turnS - 3 && notfulllawaekEV == true)
        {
            CooldownlawaekEV = 0;
            notfulllawaekEV = false;
            lawaekEV.GetComponent<Lawaek>().amountlaza1 = 250;
            lawaekEV.GetComponent<Lawaek>().amountlaza2 = 170;
            lawaekEV.GetComponent<Lawaek>().amountlaza3 = 100;
            lawaekEV.GetComponent<Lawaek>().amountlaza4 = 60;
            lawaekEV.GetComponent<Lawaek>().amountlaza5 = 35;
            lawaekEV.GetComponent<Lawaek>().amountlaza6 = 10;
            lawaekEV.GetComponent<Lawaek>().amountlaza7 = 5;
            lawaekEV.GetComponent<Lawaek>().amountshopp1 = 250;
            lawaekEV.GetComponent<Lawaek>().amountshopp2 = 170;
            lawaekEV.GetComponent<Lawaek>().amountshopp3 = 100;
            lawaekEV.GetComponent<Lawaek>().amountshopp4 = 60;
            lawaekEV.GetComponent<Lawaek>().amountshopp5 = 35;
            lawaekEV.GetComponent<Lawaek>().amountshopp6 = 10;
            lawaekEV.GetComponent<Lawaek>().amountshopp7 = 5;
            lawaekEV.GetComponent<Lawaek>().amountnef1 = 250;
            lawaekEV.GetComponent<Lawaek>().amountnef2 = 170;
            lawaekEV.GetComponent<Lawaek>().amountnef3 = 100;
            lawaekEV.GetComponent<Lawaek>().amountnef4 = 60;
            lawaekEV.GetComponent<Lawaek>().amountnef5 = 35;
            lawaekEV.GetComponent<Lawaek>().amountnef6 = 10;
            lawaekEV.GetComponent<Lawaek>().amountnef7 = 5;


        }

        if (CooldownsongverderLoisEV == 0 && notfullsongverderLoisEV == true)
        {
            CooldownsongverderLoisEV = turnS;
        }
        else if (CooldownsongverderLoisEV == turnS - 3 && notfullsongverderLoisEV == true)
        {
            CooldownsongverderLoisEV = 0;
            notfullsongverderLoisEV = false;
            songverderLoisEV.GetComponent<SongverderLois>().amountlaza1 = 250;
            songverderLoisEV.GetComponent<SongverderLois>().amountlaza2 = 170;
            songverderLoisEV.GetComponent<SongverderLois>().amountlaza3 = 100;
            songverderLoisEV.GetComponent<SongverderLois>().amountlaza4 = 60;
            songverderLoisEV.GetComponent<SongverderLois>().amountlaza5 = 35;
            songverderLoisEV.GetComponent<SongverderLois>().amountlaza6 = 10;
            songverderLoisEV.GetComponent<SongverderLois>().amountlaza7 = 5;
            songverderLoisEV.GetComponent<SongverderLois>().amountshopp1 = 250;
            songverderLoisEV.GetComponent<SongverderLois>().amountshopp2 = 170;
            songverderLoisEV.GetComponent<SongverderLois>().amountshopp3 = 100;
            songverderLoisEV.GetComponent<SongverderLois>().amountshopp4 = 60;
            songverderLoisEV.GetComponent<SongverderLois>().amountshopp5 = 35;
            songverderLoisEV.GetComponent<SongverderLois>().amountshopp6 = 10;
            songverderLoisEV.GetComponent<SongverderLois>().amountshopp7 = 5;
            songverderLoisEV.GetComponent<SongverderLois>().amountnef1 = 250;
            songverderLoisEV.GetComponent<SongverderLois>().amountnef2 = 170;
            songverderLoisEV.GetComponent<SongverderLois>().amountnef3 = 100;
            songverderLoisEV.GetComponent<SongverderLois>().amountnef4 = 60;
            songverderLoisEV.GetComponent<SongverderLois>().amountnef5 = 35;
            songverderLoisEV.GetComponent<SongverderLois>().amountnef6 = 10;
            songverderLoisEV.GetComponent<SongverderLois>().amountnef7 = 5;
            

        }

        if (CooldownparisiaEV == 0 && notfullparisiaEV == true)
        {
            CooldownparisiaEV = turnS;
        }
        else if (CooldownparisiaEV == turnS - 3 && notfullparisiaEV == true)
        {
            CooldownparisiaEV = 0;
            notfullparisiaEV = false;
            parisiaEV.GetComponent<Parisia>().amountlaza1 = 250;
            parisiaEV.GetComponent<Parisia>().amountlaza2 = 170;
            parisiaEV.GetComponent<Parisia>().amountlaza3 = 100;
            parisiaEV.GetComponent<Parisia>().amountlaza4 = 60;
            parisiaEV.GetComponent<Parisia>().amountlaza5 = 35;
            parisiaEV.GetComponent<Parisia>().amountlaza6 = 10;
            parisiaEV.GetComponent<Parisia>().amountlaza7 = 5;
            parisiaEV.GetComponent<Parisia>().amountshopp1 = 250;
            parisiaEV.GetComponent<Parisia>().amountshopp2 = 170;
            parisiaEV.GetComponent<Parisia>().amountshopp3 = 100;
            parisiaEV.GetComponent<Parisia>().amountshopp4 = 60;
            parisiaEV.GetComponent<Parisia>().amountshopp5 = 35;
            parisiaEV.GetComponent<Parisia>().amountshopp6 = 10;
            parisiaEV.GetComponent<Parisia>().amountshopp7 = 5;
            parisiaEV.GetComponent<Parisia>().amountnef1 = 250;
            parisiaEV.GetComponent<Parisia>().amountnef2 = 170;
            parisiaEV.GetComponent<Parisia>().amountnef3 = 100;
            parisiaEV.GetComponent<Parisia>().amountnef4 = 60;
            parisiaEV.GetComponent<Parisia>().amountnef5 = 35;
            parisiaEV.GetComponent<Parisia>().amountnef6 = 10;
            parisiaEV.GetComponent<Parisia>().amountnef7 = 5;

        }

    }

}