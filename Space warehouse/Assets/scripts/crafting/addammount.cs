using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addammount : MonoBehaviour {

    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public int numb;
    public int numb1;
    public int numb2;
    public int numb3;
    public int numb4;
    public int numb5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Add10()
    {
        numb = numb + 10;
        text1.text = numb.ToString();
    }
    public void Add100()
    {
        numb = numb + 100;
        text1.text = numb.ToString();
    }
    public void take10()
    {
        numb = numb - 10;
        text1.text = numb.ToString();
    }
    public void Take100()
    {
        numb = numb - 100;
        text1.text = numb.ToString();
    }

    public void Add10a()
    {
        numb1 = numb1 + 10;
        text2.text = numb1.ToString();
    }
    public void Add100a()
    {
        numb1 = numb1 + 100;
        text2.text = numb1.ToString();
    }
    public void take10a()
    {
        numb1 = numb1 - 10;
        text2.text = numb1.ToString();
    }
    public void Take100a()
    {
        numb1 = numb1 - 100;
        text2.text = numb1.ToString();
    }
    public void Add10b()
    {
        numb2 = numb2 + 10;
        text3.text = numb2.ToString();
    }
    public void Add100b()
    {
        numb2 = numb2 + 100;
        text3.text = numb2.ToString();
    }
    public void take10b()
    {
        numb2 = numb2 - 10;
        text3.text = numb2.ToString();
    }
    public void Take100b()
    {
        numb2 = numb2 - 100;
        text3.text = numb2.ToString();
    }
    public void Add10c()
    {
        numb3 = numb3 + 10;
        text4.text = numb3.ToString();
    }
    public void Add100c()
    {
        numb3 = numb3 + 100;
        text4.text = numb3.ToString();
    }
    public void take10c()
    {
        numb3 = numb3 - 10;
        text4.text = numb3.ToString();
    }
    public void Take100c()
    {
        numb3 = numb3 - 100;
        text4.text = numb3.ToString();
    }

    public void Add10d()
    {
        numb4 = numb4 + 10;
        text5.text = numb4.ToString();
    }
    public void Add100d()
    {
        numb4 = numb4 + 100;
        text5.text = numb4.ToString();
    }
    public void take10d()
    {
        numb4 = numb4 - 10;
        text5.text = numb4.ToString();
    }
    public void Take100d()
    {
        numb4 = numb4 - 100;
        text5.text = numb4.ToString();
    }
    public void Add10e()
    {
        numb5 = numb5 + 10;
        text6.text = numb5.ToString();
    }
    public void Add100e()
    {
        numb5 = numb5 + 100;
        text6.text = numb5.ToString();
    }
    public void take10e()
    {
        numb5 = numb5 - 10;
        text6.text = numb5.ToString();
    }
    public void Take100e()
    {
        numb5 = numb5 - 100;
        text6.text = numb5.ToString();
    }
}
