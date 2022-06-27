using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using PolyLabs;

public class MainPotatos : MonoBehaviour
{
    public static double potatos_double;
    public static double coin_double;
    public static double rebirth;
    public Text PotatoA;
    public static int  rebcost;
    public double coins;
   

    public Text coinDisplay;
    public static int multiplier=1;
    public static int podevender=1;
    public Text CoinDisplay2;

    public GameObject g1,g2,g3,g4;
    public GameObject a1,a2,a3,a4;



    void Start() {


       
        potatos_double = PlayerPrefs.GetInt("potatos", 0);
        coin_double = PlayerPrefs.GetInt("coin", 0);
        multiplier = PlayerPrefs.GetInt("multi", 1);
        podevender = PlayerPrefs.GetInt("podevender", 1);
        Xp.level = PlayerPrefs.GetInt("level", 0);
        Xp.exp = PlayerPrefs.GetInt("xp", 0);
        Xp.tragetxp = PlayerPrefs.GetInt("txp", 1);
        rebirth = PlayerPrefs.GetInt("reb", 0);
        Shop.buymultiplier = PlayerPrefs.GetInt("buymult", 2);
        
    }

    // Update is called once per frame
    void Update()
    {

            if(a1.activeSelf==true){
                g1.SetActive(true);
            }else   {
                g1.SetActive(false);
            }
             if(a2.activeSelf==true){
                g2.SetActive(true);
            }else   {
                g2.SetActive(false);
            }
             if(a3.activeSelf==true){
                g3.SetActive(true);
            }else   {
                g3.SetActive(false);
            }
             if(a4.activeSelf==true){
                g4.SetActive(true);
            }else   {
                g4.SetActive(false);
            }

            if(a1.activeSelf){
                a2.SetActive(false);
                a3.SetActive(false);
                a4.SetActive(false);
                
            }
             if(a2.activeSelf){
                a1.SetActive(false);
                a3.SetActive(false);
                a4.SetActive(false);
                
            }
             if(a3.activeSelf){
                a1.SetActive(false);
                a2.SetActive(false);
                a4.SetActive(false);
                
            }
             if(a4.activeSelf){
                a1.SetActive(false);
                a2.SetActive(false);
                a3.SetActive(false);
                
            }
        coins = coin_double;
        PotatoA.text = ShortScale.ParseDouble(potatos_double);  
        coinDisplay.text = ShortScale.ParseDouble(coin_double);  
        CoinDisplay2.text = ShortScale.ParseDouble(coin_double);
        
     
        

        //save

        rebcost = 1000000;
        PlayerPrefs.SetInt("potatos", (int)potatos_double);
        PlayerPrefs.SetInt("coin", (int)coin_double);
        PlayerPrefs.SetInt("multi",(int) multiplier);
        PlayerPrefs.SetInt("podevender",(int) podevender);
        PlayerPrefs.SetInt("xp", Xp.exp);
        PlayerPrefs.SetInt("level", Xp.level);
        PlayerPrefs.SetInt("txp", Xp.tragetxp);
        PlayerPrefs.SetInt("reb", (int)rebirth);
        PlayerPrefs.SetInt("buymult", Shop.buymultiplier);

    }

   
    
public void secret()
    { 
       
        potatos_double = 1;
        coin_double = 1;
        rebirth = 0;
        multiplier = 1;
        podevender = 1;
      Stats.rebcost = 1000000;
        Xp.level = 0;
        Xp.exp = 0;
        Xp.tragetxp= 1;
       Stats.playtime = 0;
    }


}