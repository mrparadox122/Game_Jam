using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialuge : MonoBehaviour
{ 
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

   void Start() {
       StartCoroutine(Type());      
  }
  IEnumerator Type(){
      Debug.Log("called1");
      foreach(char letter in sentences[index].ToCharArray()){
          textDisplay.text += letter;
          yield return new WaitForSeconds(typingSpeed);
      }
      
      
  }
  public void NextSentence(){
      Debug.Log("called");
      textDisplay.text = "";
      if (index < sentences.Length - 1)
      {
          index++;
          textDisplay.text = "";
          StartCoroutine(Type());
      }else{
          textDisplay.text = "";
      }
  }
}
