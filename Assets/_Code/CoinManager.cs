using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public TMP_Text CoinText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CoinText.text = " X " + coinCount.ToString();
    }
}
