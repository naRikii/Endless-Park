using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollwit : MonoBehaviour
{
    public Color newColor;
    private SpriteRenderer rend;
    public Color revert;
    [SerializeField] float hurt = 0.1f;

    public IEnumerator FLASH()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.color = newColor;
        yield return new WaitForSeconds(hurt);
        back();

    }
    private void Update()
    {
        StartCoroutine(FLASH());
    }
    public void back()
    {
        rend.color = revert;
    }
}
