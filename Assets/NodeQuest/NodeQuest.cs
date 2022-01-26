using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NodeQuest : NodeGame
{
    private string _summup;
    private int _indexObjective;
    private int _advised_level;
    private string _nameQuest;
    private int _goldRwd;
    private int _xpRwd;

    protected NodeQuest(string summup, int indexObjective, int advisedLevel, string nameQuest, int goldRwd, int xpRwd)
    {
        _summup = summup;
        _indexObjective = indexObjective;
        _advised_level = advisedLevel;
        _nameQuest = nameQuest;
        _goldRwd = goldRwd;
        _xpRwd = xpRwd;
    }

    //Draw the node and return it
    public static NodeGame DrawNodeFrom(QuestScriptable nodeQuest)
    {
        return null;
    }

    public string GetSummup()
    {
        return _summup;
    }
    
    public int GetIndexObjective()
    {
        return _indexObjective;
    }
    
    public int AdvisedLevel()
    {
        return _advised_level;
    }
    
    public string NameQuest()
    {
        return _nameQuest;
    }
    
    public int GoldReward()
    {
        return _goldRwd;
    }
    
    public int XPReward()
    {
        return _xpRwd;
    }
    
    
}
