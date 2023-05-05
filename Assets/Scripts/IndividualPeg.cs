using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualPeg : MonoBehaviour
{
    SpriteRenderer rend;
    public float fadeAmount = 0f;
    public float fadeSpeed = 0.05f;
    public float fadeDuration = 0.5f;

    Coroutine colourFade;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ColourFade()
    {
        

        Color initialColour = rend.material.color;
        Color targetColour = new Color(initialColour.r, initialColour.g, initialColour.b, 0.5f);

        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            rend.material.color = Color.Lerp(initialColour, targetColour, elapsedTime / fadeDuration);
            yield return null;
        }
        rend.material.color = Color.white;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // GetComponent<Renderer>().material.color = Color.red;
        rend.material.color = Color.red;
        colourFade = StartCoroutine(ColourFade());
        
    }

    
}
