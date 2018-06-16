using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDriver : MonoBehaviour {

    static MainDriver _instance;
    string charLetter = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    List<Color> colorList = new List<Color>()
    {
        Color.red,
        Color.yellow,
        Color.green,
        Color.blue,
        Color.cyan,
        Color.white
    };


    public static MainDriver Instance()
    {
        if(_instance == null )
        {
            _instance = GameObject.Find("GameManager").GetComponent<MainDriver>();
        }
        return _instance;
    }

    public char GetRandomLetter()
    {
        int num = Random.Range(0, charLetter.Length - 1);
        return charLetter[num];
    }

    public Color GetRandomColor ()
    {
        Color rColor = new Color();
        int index = Random.Range(0,colorList.Count - 1);
        rColor = colorList[index];
        return rColor;

    }
}
