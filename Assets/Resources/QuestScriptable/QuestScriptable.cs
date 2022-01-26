using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/QuestScriptable", order = 2)]
public class QuestScriptable : ScriptableObject
{
    [SerializeField] protected string _summup;
    [SerializeField] protected int _indexObjective;
    [SerializeField] protected int _advised_level;
    [SerializeField] protected string _nameQuest;
    [SerializeField] protected int _goldRwd;
    [SerializeField] protected int _xpRwd;
    

    public string GetSummup()
    {
        return _summup;
    }
    
    public int GetIndexObjective()
    {
        return _indexObjective;
    }
    
    public int GetAdvisedLevel()
    {
        return _advised_level;
    }
    
    public string GetNameQuest()
    {
        return _nameQuest;
    }
    
    public int GetGoldReward()
    {
        return _goldRwd;
    }
    
    public int GetXPReward()
    {
        return _xpRwd;
    }
}
