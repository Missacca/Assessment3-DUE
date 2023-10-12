using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TypeWriterEffect : MonoBehaviour
{
   


    public Text dialogText;
    public string fullText;
    public float typingSpeed = 0.05f;

    private bool isTyping = false;

    private void Start()
    {
        dialogText.text = "";
        StartCoroutine(TypeText());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Skip the typewriter effect by instantly displaying the full text
            CompleteText();
        }
    }

    private IEnumerator TypeText()
    {
        isTyping = true;
        foreach (char letter in fullText)
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;
    }

    private void CompleteText()
    {
        if (isTyping)
        {
            // If the text is still typing, stop the coroutine and display the full text.
            StopCoroutine(TypeText());
            dialogText.text = fullText;
        }
    }


}
