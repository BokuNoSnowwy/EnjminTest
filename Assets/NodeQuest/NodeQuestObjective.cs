using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeQuestObjective : NodeQuest
{
    public NodeQuestObjective(string summup, int indexObjective, int advisedLevel, string nameQuest, int goldRwd, int xpRwd) : base(summup, indexObjective, advisedLevel, nameQuest, goldRwd, xpRwd)
    {
        
    }
    
    public static NodeGame DrawNodeFrom(QuestScriptableObjective objective)
    {
        return new NodeQuestObjective(objective.GetSummup(),objective.GetIndexObjective(),objective.GetAdvisedLevel(),objective.GetNameQuest(),
            objective.GetGoldReward(),objective.GetXPReward());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
