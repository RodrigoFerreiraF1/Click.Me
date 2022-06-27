using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Limitesys : MonoBehaviour
{
    public int limite;
    public static int ll;
    public Text limitetx;
    public Text ola;

    // Start is called before the first frame update
    void Start()
    {
        limite=Xp.level;
        limitetx.text="Limite:"+ limite;
    }

    // Update is called once per frame
    void Update()
    {
        ola.text= "" + ll;
        limite=Xp.level;
        limitetx.text="Limite:"+ limite;
    }
}
