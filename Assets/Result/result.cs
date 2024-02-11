using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class result : MonoBehaviour
{
    public InputField inp1, inp2,inp3,inp4,inp5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void res()
    {
        int temp = 0,per =0;
        int a = int.Parse(inp1.text);
        int b = int.Parse(inp2.text);
        int d = int.Parse(inp4.text);
        int e = int.Parse(inp5.text);
        int c = int.Parse(inp3.text);

        int total = a + b + c + d + e;

        print(total);

        if (a < b && a < c && a < d && a < e)
        {
            Debug.Log("a is min");
        }
        else if (b < c && b < d && b < e)
        {
            Debug.Log("b is min");
        }
        else if (c < d && c < e)
        {
            Debug.Log("c is min");
        }
        else if (d < e)
        {
            Debug.Log("d is min");
        }
        else
        {
            Debug.Log("e is min");
        }

        if (a > b && a > c && a > d && a > e)
        {
            Debug.Log("a is max");
        }
        else if (b > c && b > d && b > e)
        {
            Debug.Log("b is max");
        }
        else if (c < d && c > e)
        {
            Debug.Log("c is max");
        }
        else if (d > e)
        {
            Debug.Log("d is max");
        }
        else
        {
            Debug.Log("e is max");
        }
        if(a>35 && b>35 && c>35 && d>35 && e>35)
        {
            per = total / 5;
            Debug.Log("Persentage : " + per + "%");
        }
        else
        {
            Debug.Log("Per = **");
        }        
        if (per > 90)
        {
            Debug.Log("Grade = A+");
        }
        else if (per > 80)
        {
            Debug.Log("Grade = A");
        }
        else if (per > 70)
        {
            Debug.Log("Grade = B+");
        }
        else if (per > 60)
        {
            Debug.Log("Grade = B");
        }
        else if (per > 35)
        {
            Debug.Log("Grade = D");
        }
        else
        {
            Debug.Log("Grade = **");
        }

        if (a > 35)
            temp = temp + 1;
        if (b > 35)
            temp = temp + 1;
        if (c > 35)
            temp = temp + 1;
        if (d > 35)
            temp = temp + 1;
        if (e > 35)
            temp = temp + 1;

        if (temp == 5)
        {
            Debug.Log("Result : Pass");
        }
        else if (temp == 4 || temp == 3)
        {
            Debug.Log("Result : ATKT");
        }
        else
        {
            Debug.Log("Result : Fail");
        }
    }
    
}
