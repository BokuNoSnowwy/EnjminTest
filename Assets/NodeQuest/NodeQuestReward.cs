using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeQuestReward : NodeQuest
{
    public NodeQuestReward(string summup, int indexObjective, int advisedLevel, string nameQuest, int goldRwd, int xpRwd) : base(summup, indexObjective, advisedLevel, nameQuest, goldRwd, xpRwd)
    {
        
    }

    public static NodeGame DrawNodeFrom(QuestScriptableReward rewardSO)
    {
        return new NodeQuestReward(rewardSO.GetSummup(),rewardSO.GetIndexObjective(),rewardSO.GetAdvisedLevel(),
            rewardSO.GetNameQuest(),rewardSO.GetGoldReward(),rewardSO.GetXPReward());
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
