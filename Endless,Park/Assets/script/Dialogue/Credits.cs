using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public TMP_Text text;
    string C1 = "Thanks for Playing Endless,Park!";
    string C2 = "Programs used for the art in this game are: paint.net, KidPix, Piskel";
    string C3 = "Music Credits go to: Vicetone, Myself, saikoro, siinamota, ZUN, The Quick Brown Fox, EBIMAYO";
    string C4 = "Coding Credits: Myself, Mr. Chen, Ben Wempe";
    string C5 = "Music Programs used to make the music: BeepBox, FL Studio";
    string C6 = "Art Credits go to: Myself, saikoro, siinamota, peppy, rrtyui, EBIMAYO";
    string C7 = "51 Scenes, 25 scripts, 100 sprites.";
    string C8 = "...e";
    string C9 = "Congrats on solving all the puzzles I layed out";
    string C10 = "I hope they werent too nonsensical";
    string C11 = "Goodbye";




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DialogueCredits());
    }
    IEnumerator DialogueCredits()
    {
        text.text = C1;
        yield return new WaitForSeconds(5);
        text.text = C2;
        yield return new WaitForSeconds(5);
        text.text = C3;
        yield return new WaitForSeconds(5);
        text.text = C4;
        yield return new WaitForSeconds(5);
        text.text = C5;
        yield return new WaitForSeconds(5);
        text.text = C6;
        yield return new WaitForSeconds(5);
        text.text = C7;
        yield return new WaitForSeconds(5);
        text.text = C8;
        yield return new WaitForSeconds(5);
        text.text = C9;
        yield return new WaitForSeconds(5);
        text.text = C10;
        yield return new WaitForSeconds(5);
        text.text = C11;
        yield return new WaitForSeconds(2);
        
        SceneManager.LoadScene(0);
        Application.Quit();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
