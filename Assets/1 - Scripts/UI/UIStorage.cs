using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UIStorage", menuName = "UIStorage")]
public class UIStorage : ScriptableObject
{
    public List<UIStorageNode> Nodes;
}

[Serializable]
public struct UIStorageNode
{
    public UIIDs Id;

    public GameObject Prefab;
    
    public int RegisterCount;
}
