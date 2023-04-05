using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class explain : MonoBehaviour
{
    public TMP_Text Dialogue;
    public TMP_Text toptext;
    string next = "explain";
    string next1 = "seriously why";
    string next2 = "???";
    string A = "just go to title already";
    string next3 = ".";
    string next4 = "fine";
    string nextfinale = "go to title";
    string top = "congrats youre both dead";
    string next5 = "still dont understand";
    string top1 = "JUST GO BACK ALREADY";
    // Start is called before the first frame update

    IEnumerator questionmark()
    {
        yield return new WaitForSeconds(3);
        Dialogue.text = next;
        yield return new WaitForSeconds(3);
        Dialogue.text = next1;
        yield return new WaitForSeconds(3);
        Dialogue.text = next2;
        yield return new WaitForSeconds(1);
        toptext.text = A;
        Dialogue.text = next3;
        yield return new WaitForSeconds(3);
        Dialogue.text = next4;
        yield return new WaitForSeconds(3);
        Dialogue.text = nextfinale;
        toptext.text = top;
        yield return new WaitForSeconds(5);
        Dialogue.text = next5;
        yield return new WaitForSeconds(1);
        toptext.text = top1;
        Dialogue.text = next3;
        yield return new WaitForSeconds(0.5f);
        FindObjectOfType<SceneLoader>().goback();
    }
    void Start()
    {
        StartCoroutine(questionmark());
    }
}