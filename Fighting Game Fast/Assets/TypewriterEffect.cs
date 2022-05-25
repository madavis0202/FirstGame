using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterEffect : MonoBehaviour {
    public float speed = 0.1f;
    public string fullText;
    public string currentText = "";
    public GameObject inputField;
    
    public void StartText()
    {
        StartCoroutine(ShowText());
        Debug.Log("Oingo Boingo");
    }
    public IEnumerator ShowText() {

        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(speed);
        }
        while (true) {
            if (Input.GetMouseButtonDown(0))
            {
                currentText = "";
                this.GetComponent<Text>().text = currentText;
                inputField.SetActive(true);
                yield break;
            }
            else{
                yield return null;
            }
        }
    }
}