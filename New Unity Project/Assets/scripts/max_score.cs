using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class max_score : MonoBehaviour
{
    public Text max_L1F1,max_L1F2, max_L1B1, max_L1B2, max_L2F1, max_L2F2, max_L2B1, max_L2B2;
    float smax_L1F1, smax_L1F2, smax_L1B1, smax_L1B2, smax_L2F1, smax_L2F2, smax_L2B1, smax_L2B2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void maxscore(){
        smax_L1F1 = L1Fmuscle.max1;
        smax_L1F2 = L1Fmuscle.max2;
        smax_L1B1 = L1Bmuscle.max1;
        smax_L1B2 = L1Bmuscle.max2;
        smax_L2F1 = L2Fmuscle.max1;
        smax_L2F2 = L2Fmuscle.max2;
        smax_L2B1 = L2Bmuscle.max1;
        smax_L2B2 = L2Bmuscle.max2;
        max_L1F1.text = smax_L1F1.ToString("00.0");
        max_L1F2.text = smax_L1F2.ToString("00.0");
        max_L1B1.text = smax_L1B1.ToString("00.0");
        max_L1B2.text = smax_L1B2.ToString("00.0");
        max_L2F1.text = smax_L2F1.ToString("00.0");
        max_L2F2.text = smax_L2F2.ToString("00.0");
        max_L2B1.text = smax_L2B1.ToString("00.0");
        max_L2B2.text = smax_L2B2.ToString("00.0");
    }
    
}
