using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    string line1 = "you do realize there isnt a way to exit yet, right?";
    string line2 = "press every key you can think of, there isnt a way to go";
    string line3 = "i mean there may be some obscure key that could do something";
    string line4 = "like some random function key";
    string line5 = "it could be a waste of time but who knows";
    string line6 = "it could yield something";
    public TMP_Text dialogueText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(talk1());
    }

    IEnumerator talk1()
    {
        yield return new WaitForSeconds(3);
        dialogueText.text = line1;
        yield return new WaitForSeconds(4);
        dialogueText.text = line2;
        yield return new WaitForSeconds(4);
        dialogueText.text = line3;
        yield return new WaitForSeconds(4);
        dialogueText.text = line4;
        yield return new WaitForSeconds(3);
        dialogueText.text = line5;
        yield return new WaitForSeconds(4);
        dialogueText.text = line6;
        yield return new WaitForSeconds(3);
        dialogueText.text = null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
