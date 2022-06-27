using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePlayed : MonoBehaviour
{
    public static int playtime = 0;
    public static int seconds = 0;
    public static int minutes = 0;
    public static int hours = 0;
    public static int days = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("playtimer");
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("playtimer");
    }
     IEnumerator playtimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playtime += 1;
            seconds = (playtime % 60);
            minutes=(playtime  /60) %60;
            hours = (playtime / 3600) % 24 ;
            days = (playtime / 85400) % 365 ;

        }
    }
}
