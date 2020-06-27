using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public SpeechBubble[] banter;
    public PlayerPrompt playerResponse;
}

[System.Serializable]
public class SpeechBubble
{
    public bool playerSpeaking;
    public string sentence;
    public float timeToRead;
}

[System.Serializable]
public class PlayerPrompt
{
    public float timeToReply;
    public string[] replies;
    public bool[] validChoices;
    public float timeToRead;
}