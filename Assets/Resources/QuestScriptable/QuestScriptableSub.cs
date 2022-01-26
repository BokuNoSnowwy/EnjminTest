using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/QuestScriptable/SubQuest")]
public class QuestScriptableSub : QuestScriptable
{
    private int alignementGoodRequired;
    private int alignementEvilRequired;


    public int GetAlignementGood()
    {
        return alignementGoodRequired;
    }

    public int GetAligmenentEvil()
    {
        return alignementEvilRequired;
    }
}
