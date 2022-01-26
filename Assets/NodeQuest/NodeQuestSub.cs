using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeQuestSub : NodeQuest
{
    private int alignementGoodRequired;
    private int alignementEvilRequired;

    public NodeQuestSub(string summup, int indexObjective, int advisedLevel, string nameQuest, int goldRwd, int xpRwd, int alignementEvilRequired, int alignementGoodRequired) : base(summup, indexObjective, advisedLevel, nameQuest, goldRwd, xpRwd)
    {
        
    }

    public static NodeGame DrawNodeFrom(QuestScriptableSub sub)
    {
        return new NodeQuestSub(sub.GetSummup(),sub.GetIndexObjective(),sub.GetAdvisedLevel(),
            sub.GetNameQuest(),sub.GetGoldReward(),sub.GetXPReward(),sub.GetAligmenentEvil(),sub.GetAlignementGood());
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
