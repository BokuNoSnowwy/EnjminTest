using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeQuestMain : NodeQuest
{
    public NodeQuestMain(string summup, int indexObjective, int advisedLevel, string nameQuest, int goldRwd, int xpRwd) : base(summup, indexObjective, advisedLevel, nameQuest, goldRwd, xpRwd)
    {
        
    }
    
    public static NodeGame DrawNodeFrom(QuestScriptableMain main)
    {
        return new NodeQuestMain(main.GetSummup(),main.GetIndexObjective(),main.GetAdvisedLevel(),main.GetNameQuest(),
            main.GetGoldReward(),main.GetXPReward());
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
