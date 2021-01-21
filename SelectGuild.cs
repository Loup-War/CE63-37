using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectGuild : MonoBehaviour
{
    public GameObject inventory;
    public GameObject inventoryUI;
    public GameObject genaralUI;
    public GameObject iconGuild1, iconGuild2, iconGuild3, iconGuild4, iconGuild5;
    public MainEvent Event;
    public Text descriptionText;
    public Text buffDesText;
    public GameObject canvasSelect;

    public void Guilddesir()
    {
        Event.description = "Guild :  The Desir";
        descriptionText.text = Event.description;
        Event.buffDes = "สิทธิพิเศษ :  พ่อค้าของสามารถขายข้าวได้ราคาเพิ่มขึ้น 10%";
        buffDesText.text = Event.buffDes;
        inventory.GetComponent<Inventory>().guildDesir = 0.1f;
        inventory.GetComponent<Inventory>().guildAsrial = 0;
        inventory.GetComponent<Inventory>().guildLoup = 0;
        inventory.GetComponent<Inventory>().guildOrion = 0;
        inventory.GetComponent<Inventory>().guildSerment = 0;
    }
    public void GuildLoup()
    {
        Event.description = "Guild :  The Loup";
        descriptionText.text = Event.description;
        Event.buffDes = "สิทธิพิเศษ :  พ่อค้าของสมาคมสามารถขายไม้ได้ราคาเพิ่มขึ้น 10%";
        buffDesText.text = Event.buffDes;
        inventory.GetComponent<Inventory>().guildDesir = 0;
        inventory.GetComponent<Inventory>().guildAsrial = 0;
        inventory.GetComponent<Inventory>().guildLoup = 0.1f;
        inventory.GetComponent<Inventory>().guildOrion = 0;
        inventory.GetComponent<Inventory>().guildSerment = 0;
    }
    public void GuildSerment()
    {
        Event.description = "Guild :  The Serment";
        descriptionText.text = Event.description;
        Event.buffDes = "สิทธิพิเศษ :  พ่อค้าของสมาคมสามารถขายเหล็กได้ราคาเพิ่มขึ้น 10%";
        buffDesText.text = Event.buffDes;
        inventory.GetComponent<Inventory>().guildDesir = 0;
        inventory.GetComponent<Inventory>().guildAsrial = 0;
        inventory.GetComponent<Inventory>().guildLoup = 0;
        inventory.GetComponent<Inventory>().guildOrion = 0;
        inventory.GetComponent<Inventory>().guildSerment = 0.1f;
    }
    public void GuildAsrial()
    {
        Event.description = "Guild :  The Asrial";
        descriptionText.text = Event.description;
        Event.buffDes = "สิทธิพิเศษ :  พ่อค้าของสมาคมสามารถขายผ้าได้ราคาเพิ่มขึ้น 10%";
        buffDesText.text = Event.buffDes;
        inventory.GetComponent<Inventory>().guildDesir = 0;
        inventory.GetComponent<Inventory>().guildAsrial = 0.1f;
        inventory.GetComponent<Inventory>().guildLoup = 0;
        inventory.GetComponent<Inventory>().guildOrion = 0;
        inventory.GetComponent<Inventory>().guildSerment = 0;
    }
    public void GuildOrion()
    {
        Event.description = "Guild :  The Orion";
        descriptionText.text = Event.description;
        Event.buffDes = "สิทธิพิเศษ :  พ่อค้าของสมาคมสามารถขายอาวุธและชุดเกราะได้ราคาเพิ่มขึ้น 10%";
        buffDesText.text = Event.buffDes;
        inventory.GetComponent<Inventory>().guildDesir = 0;
        inventory.GetComponent<Inventory>().guildAsrial = 0;
        inventory.GetComponent<Inventory>().guildLoup = 0;
        inventory.GetComponent<Inventory>().guildOrion = 0.1f;
        inventory.GetComponent<Inventory>().guildSerment = 0;
    }
    public void NotSelectGuild()
    {
        if(inventory.GetComponent<Inventory>().guildAsrial == 0.1f)
        {
            canvasSelect.SetActive(false);
            inventoryUI.SetActive(true);
            genaralUI.SetActive(true);
            iconGuild4.SetActive(true);
            inventory.GetComponent<Inventory>().after();
        }
        else if(inventory.GetComponent<Inventory>().guildDesir == 0.1f)
        {
            canvasSelect.SetActive(false);
            inventoryUI.SetActive(true);
            genaralUI.SetActive(true);
            iconGuild1.SetActive(true);
            inventory.GetComponent<Inventory>().after();
        }
        else if (inventory.GetComponent<Inventory>().guildLoup == 0.1f)
        {
            canvasSelect.SetActive(false);
            inventoryUI.SetActive(true);
            genaralUI.SetActive(true);
            iconGuild2.SetActive(true);
            inventory.GetComponent<Inventory>().after();
        }
        else if (inventory.GetComponent<Inventory>().guildOrion == 0.1f)
        {
            canvasSelect.SetActive(false);
            inventoryUI.SetActive(true);
            genaralUI.SetActive(true);
            iconGuild5.SetActive(true);
            inventory.GetComponent<Inventory>().after();
        }
        else if (inventory.GetComponent<Inventory>().guildSerment == 0.1f)
        {
            canvasSelect.SetActive(false);
            inventoryUI.SetActive(true);
            genaralUI.SetActive(true);
            iconGuild3.SetActive(true);
            inventory.GetComponent<Inventory>().after();
        }
        else
        {
            Event.description = "Guild :  โปรดเลือกGuild";
            descriptionText.text = Event.description;
            Event.buffDes = "สิทธิพิเศษ :  ";
            buffDesText.text = Event.buffDes;
        }
    }
}
