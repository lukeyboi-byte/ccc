using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [TextArea(1,3)]
    public string[] headlines;
    [TextArea(3,15)]
    public string[] excerpts;
}
