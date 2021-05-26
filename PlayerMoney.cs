using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMoney : MonoBehaviour
{
    public int money ;
    public Text MoneyText;

    void start()
    {
        Update();
    }
    public void AddGold(int amount)
    {
        money += amount;
        Update();
    }
    public void ReducedGold(int amount)
    {
        money -= amount;
        Update();
    }
    void Update()
    {
    }
}
