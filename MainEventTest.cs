using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainEventTest : MonoBehaviour
{
    public MainEvent Event;
    public MainEL MainEventList;

    public Player player;

    public GameObject OBMainEvent;
    public Text titleText;
    public Text descriptionText;
    public Text goldText;
    public Text silverText;
    public Text buffText;
    public int num;
    //public Text buffRText;
    //Random random = new Random();

    public void OpenOBMainEvent()
    {
        TurnSys.TurnValue += 1;
        TurnSys.TurnShow += 1;

        num = Random.Range(1,2);
        if (TurnSys.TurnValue == 15)
        {
            
            OBMainEvent.SetActive(true);
            //if (num == 1)
            //{
                //Event.ML.Sell();
                titleText.text = MainEventList.Event.title;
                descriptionText.text = Event.description;
                goldText.text = Event.goldR.ToString();
                silverText.text = Event.silverR.ToString();
                buffText.text = Event.buffDes.ToString();
            //}

            //if (num == 2)
            //{
            //    Event.ML.Auction();
            //    titleText.text = Event.title;
            //    descriptionText.text = Event.description;
            //    goldText.text = Event.goldR.ToString();
            //    silverText.text = Event.silverR.ToString();
            //    buffText.text = Event.buffDes.ToString();
            //}
            //titleText.text = Event.title;
            //descriptionText.text = Event.description;
            //goldText.text = Event.goldR.ToString();
            //silverText.text = Event.silverR.ToString();
            //buffText.text = Event.buffDes.ToString();
            TurnSys.TurnValue = 0;
        //buffRText.text = Event.buffR.ToString();
        }

    }

    public void AcceptEvent()
    {
        OBMainEvent.SetActive(false);
        Event.isActive = true;
        player.Event = Event;
    }
}
