using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatManager : MonoBehaviour
{
    public static ChatManager current;

    private Conversation[] conversations;
    private Conversation currConvo;

    // Start is called before the first frame update
    void Start()
    {
        current = this;

        conversations = Resources.LoadAll<Conversation>("Conversations");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateNewConversation ()
    {
        int r = Random.Range(0, conversations.Length - 1);
        currConvo = conversations[r];

        StartCoroutine(ExecuteIntroConversation());
    }

    private IEnumerator ExecuteIntroConversation ()
    {
        int convoSection = 0;

        foreach (Dialogue dialogue in currConvo.introConvo)
        {
            // anthony stopped here
        }

        yield return null;
    }
}
