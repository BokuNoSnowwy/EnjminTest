using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ScenarioScriptable", order = 1)]
public class ScenarioScriptable : ScriptableObject
{
    [SerializeField] private string nameScenario;

    [SerializeField] private List<QuestScriptable> _questList = new List<QuestScriptable>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetNameScenario()
    {
        return nameScenario;
    }

    public List<QuestScriptable> GetQuestList()
    {
        return _questList;
    }
}
