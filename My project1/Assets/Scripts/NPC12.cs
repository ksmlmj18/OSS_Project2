using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NPC12 : MonoBehaviour

{
    public UnityEvent onPlayerEntered;
    public string[] sentences;


    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            onPlayerEntered.Invoke();

            if (DialogueManager.instance.dialoguegroup.alpha == 0)
            {
                DialogueManager.instance.Ondialogue(sentences);
                colision.gameObject.SetActive(true);

            }   
           
            
        }
    }

}