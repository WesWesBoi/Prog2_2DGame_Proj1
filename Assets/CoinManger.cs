using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManger : MonoBehaviour
{
    public int coinCount;
    public Text coinText;
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "coin Count: " + coinCount.ToString();
        if(coinCount == 14)
        {
            Destroy(Door);
        }
    }
}
