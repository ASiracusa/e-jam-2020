using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation")]
public class Conversation : ScriptableObject
{
    public Dialogue[] introConvo;
    public Dialogue[] leavingConvo;

    public SpeechBubble[] tooSlowResponse;
    public SpeechBubble[] wrongReplyResponse;
}
