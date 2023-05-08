using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class addNumberAlotofNumbar : MonoBehaviour
{
    public TMP_Text text;
    public int rank = 1449985;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rank < 2)
        {
            Destroy(gameObject);
            new WaitForSeconds(2);
            SceneManager.LoadScene(52);
        }
        else
        {
            rank -= 708;
            text.text = rank.ToString();
        }
    }
}
