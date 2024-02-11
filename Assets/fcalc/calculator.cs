using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class calculator : MonoBehaviour
{
    public Text display;
    float n1=0 , n2=0,temp = 0, sum = 0;
    string ope = "";
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnnumberclick(int n)
    {
        display.text = float.Parse(display.text+n).ToString();    
    }

    public void dot()
    {
        if(!display.text.Contains("."))
        {
            display.text += ".";
        }
    }

    public void plus()
    {
        n1 = float.Parse(display.text);
        display.text = "";
        ope = "plus";
    }
    public void min()
    {
        n1 = float.Parse(display.text);
        display.text = "";
        ope = "min";
    }

    public void mul()
    {
        n1 = float.Parse(display.text);
        display.text = "";
        ope = "mul";
    }

    public void div()
    {
        n1 = float.Parse(display.text);
        display.text = "";
        ope = "div";
    }
    public void mod()
    {
        n1 = float.Parse(display.text);
        display.text = "";
        ope = "mod";
    }

    public void pm()
    {
        float n3 = float.Parse(display.text);
        sum = 0 - (n3);
        display.text= sum.ToString();
    }
    public void equal()
    {
        n2 = float.Parse(display.text);
        if(ope.Equals("plus"))
        {
            sum = n1 + n2;
        }
        if(ope.Equals("min"))
        {
            sum = n1 - n2;
        }
        if (ope.Equals("mul"))
        {
            sum = n1 * n2;
        }
        if (ope.Equals("div"))
        {
            sum = n1 / n2;
        }
        if(ope.Equals("mod"))
        {
            sum = n1 % n2;
        }
        display.text = sum.ToString();
    }
    
    public void clear()
    {
        display.text = "";
    }

    public void back()
    {
        if (display.text.Length > 0)
        {
            display.text = display.text.Substring(0, display.text.Length - 1);
        }
    }
}