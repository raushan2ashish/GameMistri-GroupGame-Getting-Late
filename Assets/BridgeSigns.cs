using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSigns : MonoBehaviour
{
    public Sprite GreenLight;
    public Sprite YellowLight;
    public Sprite RedLight;
    private SpriteRenderer SpriteRenderer;
    public string Color = "Green";
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Color == "Green") 
        {
            SpriteRenderer.sprite = GreenLight;
        }
        if (Color == "Yellow")
        {
            SpriteRenderer.sprite = YellowLight;
        }
        if (Color == "Red")
        {
            SpriteRenderer.sprite = RedLight;
        }
    }
}
