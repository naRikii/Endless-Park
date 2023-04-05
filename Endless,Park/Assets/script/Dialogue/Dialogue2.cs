using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Dialogue2 : MonoBehaviour
{
    public TMP_Text text;
    


    string line1 = "what did you do";
    string line2 = "whatever i wont understand anyways";
    string line3 = "i dont feel well here so..";
    string line4 = "lets try and get out of here as fast as possible";
    string line5 = "if we can even leave in the first place";
    string line6 = "smashing keys again might do something but,";
    string line7 = "i dont think that will work, man";
    string line8 = "yeah something really feels off here";
    string line9 = "i dont know what it is about this place but, it makes me sick";
    string line10 = "ugh,";
    string line11 = "maybe the background can help? i dont know.";
    string line12 = "i honestly just want to leave this place";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Dialogue());
        
    }
    IEnumerator Dialogue()
    {
        yield return new WaitForSeconds(2);
        FindObjectOfType<icantnameit>().look();
        text.text = line1;
        yield return new WaitForSeconds(3);
        text.text = line2;
        yield return new WaitForSeconds(3);
        text.text = line3;
        yield return new WaitForSeconds(3);
        text.text = line4;
        yield return new WaitForSeconds(3);
        text.text = line5;
        yield return new WaitForSeconds(3);
        text.text = null;
        yield return new WaitForSeconds(2);
        text.text = line6;
        yield return new WaitForSeconds(3);
        text.text = line7;
        yield return new WaitForSeconds(3);
        FindObjectOfType<icantnameit>().ugh();
        text.text = null;
        yield return new WaitForSeconds(4);
        FindObjectOfType<icantnameit>().look();
        text.text = line8;
        yield return new WaitForSeconds(3);
        text.text = line9;
        yield return new WaitForSeconds(4);
        text.text = line10;
        yield return new WaitForSeconds(2);
        FindObjectOfType<icantnameit>().ugh();
        text.text = null;
        yield return new WaitForSeconds(4);
        FindObjectOfType<icantnameit>().look();
        text.text = line11;
        yield return new WaitForSeconds(3);
        FindObjectOfType<icantnameit>().ugh();
        text.text = line12;
        yield return new WaitForSeconds(3);
        text.text = null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
