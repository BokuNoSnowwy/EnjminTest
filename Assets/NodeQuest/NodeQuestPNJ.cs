using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeQuestPNJ : NodeQuest
{
    public NodeQuestPNJ(string summup, int indexObjective, int advisedLevel, string nameQuest, int goldRwd, int xpRwd) : base(summup, indexObjective, advisedLevel, nameQuest, goldRwd, xpRwd)
    {
    }
    
    public NodeGame DrawNodeFrom(NodeGame nodeQuest)
    {
        return this;
    }
}
