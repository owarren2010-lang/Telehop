using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public Transform[] Coinspot;
    public GameObject CoinspotPrefab;
    int coins;
    public TextMeshProUGUI coinText;

    public void AddCoins()
    { 
       coinText.text = "Coins: " + coins;
       coins++;
        int randomIndex = Random.Range(0, Coinspot.Length);

        Instantiate(CoinspotPrefab, Coinspot[randomIndex].position, CoinspotPrefab.transform.rotation);
    }
  
}
