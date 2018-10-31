using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float totalTime = 0;
    public static int second;
    static int totalminus = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        totalTime -= Time.deltaTime; //スタートしてから数秒を格納
        second = (int)totalTime;

        second -= totalminus;

        GetComponent<Text>().text = second.ToString();
        /*if (second == 0) {
            
        }*/
    }

    public void returnSecond(int minusTime)
    {
        totalminus += minusTime;
    }

}
