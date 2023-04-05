using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icantnameit : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite newSpriteAgain;
    public void look()
    {
        spriteRenderer.sprite = newSprite;
    }
    public void ugh()
    {
        spriteRenderer.sprite = newSpriteAgain;
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    }
    
