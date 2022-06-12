using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class DialogueManager : MonoBehaviour, IPointerDownHandler
{
    public UnityEvent onDialogFinished;
    public Text dialogueText;
    public GameObject nextText;
    private string currentSentence;
    public CanvasGroup dialoguegroup;

    public Queue<string> sentences;

    public static DialogueManager instance;

    private void Awake()
    {
        instance = this;
    }

    public float typingSpeed = 1.0f;
    private bool istyping;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

   

    public void Ondialogue(string[] lines)
    {
        sentences.Clear();
        foreach(string line in lines)
        {
            sentences.Enqueue(line);
        }
        dialoguegroup.alpha = 1;
        dialoguegroup.blocksRaycasts = true;

        NextSentence();
    }

    public void NextSentence()
    {
        if(sentences.Count != 0)
        {
            currentSentence = sentences.Dequeue();
            istyping = true;
            nextText.SetActive(false);
            StartCoroutine(Typing(currentSentence));
           
        }
        else
        {
            dialoguegroup.alpha = 0;
            dialoguegroup.blocksRaycasts = false;
        }
    }

    public void FinishDialog()
    {
        StopAllCoroutines();
        onDialogFinished.Invoke();
    }

    IEnumerator Typing(string line)
    {
        dialogueText.text = "";
        foreach(char letter in line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
        FinishDialog();

    }
    // Update is called once per frame
    void Update()
    {

        if(dialogueText.text.Equals(currentSentence))
        {
            nextText.SetActive(true);
            istyping = false;
        
        }


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(!istyping)
        NextSentence();
    }
}
