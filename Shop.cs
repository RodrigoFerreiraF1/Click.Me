using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PolyLabs;


public class Shop : MonoBehaviour
   
{
    //test
    public int all;
    public Text t1,t2,t3,t4,t5;
    public Text p1,p2,p3,p4,p5;
    public Text limit;
    public Text y1,y2,y3,y4,y5,y6,y7,y8,y9,y10;
    public static int buymultiplier=1 ;
    public double b1,b2,b3,b4,b5;
    public Image i1,i2,i3,i4,i5;
    public int test;
    public static int mreb=0;
    public static int numero;
    public double price1,price2,price3,price4,price5;
    public  double a1 , a2 , a3 , a4 , a5;
    public Button wip;
    public int l1,l2,l3,l4,l5;
    public Button bt1 , bt2 , bt3 , bt4 , bt5;
   // public string a1s=a1.ToString() ,a2s=a2.ToString();
    void Start()
    {
        //Xp.level=1;
        price1=250;
        price2=100;
        price3=1050;
        price4=3650;
        price5=1450000;
        t3.text="1X";
        t4.text = "1X";
        t1.text = "1X";
        t2.text = "1X";
        buymultiplier = 1;
        a1=MainPotatos.coin_double/price1;
        a2=MainPotatos.coin_double/price2;
            y1.text="+"+0;
            y2.text="+"+1;
            y3.text="+"+1;
            y4.text="+"+0;
            y5.text="+"+5;
            y6.text="+"+5;
            y7.text="+"+70;
            y8.text="+"+90;
            y9.text="+"+400;
            y10.text="+"+400;
        wip.enabled=false;
        l1=Xp.level;
        l2=Xp.level;
        l3=Xp.level;
        l4=Xp.level;
        l5=Xp.level;
            }
    void Update()
    {
        limit.text="Limit:"+Xp.level;
         b1 =MainPotatos.coin_double/price1;
         b2 =MainPotatos.coin_double/price2;
         b3 =MainPotatos.coin_double/price3;
         b4 =MainPotatos.coin_double/price4;
         b5 =MainPotatos.coin_double/price5;
         if(Xp.level >=10){
            i1.enabled=false;
            }else{
             i1.enabled=true;      
            }
        if(Xp.level >=20){
            i2.enabled=false;
            }else{
             i2.enabled=true;      
            }
        if(Xp.level >=50){
            i3.enabled=false;
            }else{
             i3.enabled=true;      
            }
        if(Xp.level >=100){
            i4.enabled=false;
            }else{
             i4.enabled=true;      
            }
        if(Xp.level >=150){
            i5.enabled=false;
            }else{
             i5.enabled=true;      
            }
    }
        public void change(int oi)
    {
       
        if (oi == 1)
        {
            t3.text="1X";
            t4.text ="1X";
            t1.text ="1X";
            t2.text ="1X";
            t5.text="1X";
            buymultiplier = 1;
            p1.text=""+250*buymultiplier;
            p2.text =""+100*buymultiplier;
            p3.text =""+1050*buymultiplier;
            p4.text =""+3650*buymultiplier;
            p5.text=""+145000*buymultiplier;
            y1.text="+"+0*buymultiplier;
            y2.text="+"+1*buymultiplier;
            y3.text="+"+1*buymultiplier;
            y4.text="+"+0*buymultiplier;
            y5.text="+"+5*buymultiplier;
            y6.text="+"+5*buymultiplier;
            y7.text="+"+70*buymultiplier;
            y8.text="+"+90*buymultiplier;
            y9.text="+"+400*buymultiplier;
            y10.text="+"+400*buymultiplier;
           


        }
        if (oi == 2)
        {
            t3.text = "10X";
            t4.text = "10X";
            t1.text = "10X";
            t2.text = "10X";
            t5.text="10X";
            buymultiplier = 10;
             p1.text=""+250*buymultiplier;
            p2.text =""+100*buymultiplier;
            p3.text =""+1050*buymultiplier;
            p4.text =""+3650*buymultiplier;
            p5.text=""+145000*buymultiplier;
             y1.text="+"+0*buymultiplier;
            y2.text="+"+1*buymultiplier;
            y3.text="+"+1*buymultiplier;
            y4.text="+"+0*buymultiplier;
            y5.text="+"+5*buymultiplier;
            y6.text="+"+5*buymultiplier;
            y7.text="+"+70*buymultiplier;
            y8.text="+"+90*buymultiplier;
            y9.text="+"+400*buymultiplier;
            y10.text="+"+400*buymultiplier;
        }
        if (oi == 3)
        {
            t3.text = "100X";
            t4.text = "100X";
            t1.text = "100X";
            t2.text = "100X";
            t5.text="100X";
            buymultiplier = 100;
            p1.text=""+250*buymultiplier;
            p2.text =""+100*buymultiplier;
            p3.text =""+1050*buymultiplier;
            p4.text =""+3650*buymultiplier;
            p5.text=""+145000*buymultiplier;
            y1.text="+"+0*buymultiplier;
            y2.text="+"+1*buymultiplier;
            y3.text="+"+1*buymultiplier;
            y4.text="+"+0*buymultiplier;
            y5.text="+"+5*buymultiplier;
            y6.text="+"+5*buymultiplier;
            y7.text="+"+70*buymultiplier;
            y8.text="+"+90*buymultiplier;
            y9.text="+"+400*buymultiplier;
            y10.text="+"+400*buymultiplier;
            
        

        }
        if(oi==4)
        {
            
            t1.text = ""+b1.ToString("N0");
            t2.text = ""+b2.ToString("N0");
            t3.text = ""+b3.ToString("N0");
            t4.text = ""+b4.ToString("N0");
            t5.text = ""+b5.ToString("N0");
            
            //refazer

            p1.text=""+b1*250;
            p2.text =""+b2*100;
            p3.text =""+b3*1050;
            p4.text =""+b4*3650;
            p5.text =""+b5*145000;
             y1.text="+"+0*b1;
            y2.text=""+1*b1;
            y3.text=""+1*b2;
            y4.text=""+0*b2;
            y5.text=""+5*b3;
            y6.text=""+5*b3;
            y7.text=""+70*b4;
            y8.text=""+90*b4;
            y9.text=""+400*b5;
            y10.text=""+400*b5;
            
        }
    }
  
    public void LALALA(int num)
    {
      
        if (num == 1 && MainPotatos.coin_double >= 250 * buymultiplier && Xp.level >= 10 )
        {
            MainPotatos.podevender += buymultiplier;
            MainPotatos.coin_double -= 250*buymultiplier;
           l1+=1;
           if(l1==Xp.level){
                bt1.enabled=false;
           }else{
                bt1.enabled=true;
           }
           

            
        
        }
        else
        {
            
        }
        if (num == 2 && MainPotatos.coin_double >= 100 * buymultiplier && Xp.level >= 20 )
        {
            MainPotatos.multiplier += 1* buymultiplier;
            MainPotatos.coin_double -= 100 * buymultiplier;
           l2+=1;
           if(l2==Xp.level){
                bt2.enabled=false;
           }else{
               bt2.enabled=true;
           }

        }
        if (num == 3 && MainPotatos.coin_double >= 1050 * buymultiplier && Xp.level >= 50) 
        {
            MainPotatos.podevender += 5 * buymultiplier;
            MainPotatos.multiplier += 5 * buymultiplier;
            MainPotatos.coin_double -= 1050 * buymultiplier;
           l3+=1;
           if(l3==Xp.level){
                bt3.enabled=false;
           }else{
               bt3.enabled=true;
           }
         
        }
        if(num==4 && MainPotatos.coin_double >= 3650 * buymultiplier && Xp.level >= 100)
        {
            MainPotatos.podevender += 90 * buymultiplier;
            MainPotatos.multiplier += 70* buymultiplier;
            MainPotatos.coin_double -= 3650 * buymultiplier;
        l4+=1;
           if(l4==Xp.level){
                bt4.enabled=false;
           }else{
               bt4.enabled=true;
           }
        }
          if(num==5 && MainPotatos.coin_double >= 145000 * buymultiplier && Xp.level >= 150)
        {
            MainPotatos.podevender += 90 * buymultiplier;
            MainPotatos.multiplier += 70* buymultiplier;
            MainPotatos.coin_double -= 145000 * buymultiplier;
          l5+=1;
           if(l5==Xp.level){
                bt5.enabled=false;
           }else{
               bt5.enabled=true;
           }
        }

    }
    public void rebshop(int nun)
    {
        if(nun==1&& MainPotatos.rebirth >= 1)
        {//aumenta a quantidade de upgrades que pode comprar por vez
            MainPotatos.rebirth -= 1;
            Limitesys.ll+=1;
           
        }
        if (nun == 2 && MainPotatos.rebirth >= 3)
        {//aumenta a quantidade de batatas por click
            MainPotatos.rebirth -= 3;
            MainPotatos.multiplier = MainPotatos.multiplier + 100;
            Limitesys.ll+=1;
        }
        if (nun == 3 && MainPotatos.rebirth >= 7)
        {//aumenta a quantidade de coins por venda 
            MainPotatos.rebirth -= 7;
            //MainPotatos.podevender+=

        }
        if (nun == 4 && MainPotatos.rebirth >= 10)
        {//aumenta a quantidad de rebirth que da por vez sem aumentar o pre�o
            MainPotatos.rebirth -= 10;
            mreb += 2;

        }
    }
 
}
