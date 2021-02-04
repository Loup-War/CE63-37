using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asrial : MonoBehaviour
{
    public GameObject player;
    public GameObject imageGuild;
    public int lazadiocost, shoppicacost, nefixiacost;
    public GameObject showcostlazadio1, showcostlazadio2, showcostlazadio3, showcostlazadio4, showcostlazadio5, showcostlazadio6, showcostlazadio7, showcostlazadio8, showcostlazadio9;
    public GameObject showcostshoppica1, showcostshoppica2, showcostshoppica3, showcostshoppica4, showcostshoppica5, showcostshoppica6, showcostshoppica7, showcostshoppica8, showcostshoppica9;
    public GameObject showcostnefixia1, showcostnefixia2, showcostnefixia3, showcostnefixia4, showcostnefixia5, showcostnefixia6, showcostnefixia7, showcostnefixia8, showcostnefixia9;
    public void LazadioRelation()
    {
        if (player.GetComponent<TacticsMove>().guild == "Asrial")
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
        if (player.GetComponent<TacticsMove>().guild == "Asrial")
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
        if (player.GetComponent<TacticsMove>().guild == "Asrial")
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
                showcostnefixia6.SetActive(false);
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
}
