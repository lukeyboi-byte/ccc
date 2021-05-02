using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Newspaper", menuName = "Newspaper")]
public class Newspaper : ScriptableObject
{ 
     [TextArea(1,3)]
     public string newspaperHeadlineText;
     [TextArea(15,20)]
     public string newspaperDialogueText;
     [TextArea(1,3)]
     public string newspaperCompany;

     public int scenarioBranch;
}
