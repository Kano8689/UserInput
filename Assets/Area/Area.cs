using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Area : MonoBehaviour
{
    public InputField inp1, inp2,inp3,inp4;
    public Text output;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
    public void Square()
    {
        int s = int.Parse(inp1.text);
        output.text = (s*s).ToString();
    }

    public void Rectangle()
    {
        int l = int.Parse(inp2.text);
        int b = int.Parse(inp3.text);
        output.text = (l * b).ToString();
    }

    public void Round()
    {
        float r = float.Parse(inp4.text);
        output.text = (3.14*r*r).ToString();
    }
}
