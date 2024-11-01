using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DecisionType
{
    Base,
    NewDecision,
    OnlyAddDecision
}

[CreateAssetMenu(menuName = "New Decision")]

public class Decision : ScriptableObject
{
    [TextArea(4, 10)]
    public string text;
    [Header("")][TextArea(2, 10)]
    public string acept;
    [Header("")][TextArea(2, 10)]
    public string decline;
    [Header("")]
    public DecisionType decisionType;

    [Header("")]
    public StatsModifire[] statsModifire;
    [Header("")]
    public List<Decision> decisions;
}


[Serializable]
public class StatsModifire
{
    public Stats stats;
    public int mod;
}
