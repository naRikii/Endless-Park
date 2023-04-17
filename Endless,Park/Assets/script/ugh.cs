using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ugh : MonoBehaviour
{
    public TMP_Text newtext;
    // Start is called before the first frame update
    string thanks = "thanks for reviewing Asset Library!";

    public void thanks2()
    {
        StartCoroutine(awesome());
    }

    IEnumerator awesome()
    {
        newtext.text = thanks;
        yield return new WaitForSeconds(3);
        FindObjectOfType<SceneLoader>().goback();
    }
}
