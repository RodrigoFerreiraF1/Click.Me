using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Allbt : MonoBehaviour
{
    public Image im1;
    // Start is called before the first frame update
    void Start()
    {
        im1.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Xp.level<=10){
            im1.enabled=true;
        }else{
            im1.enabled=false;
        }
        
    }
}
