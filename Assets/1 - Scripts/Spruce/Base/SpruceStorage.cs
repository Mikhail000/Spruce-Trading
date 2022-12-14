using System;
using System.Collections.Generic;
using Spruce;
using UnityEngine;

[CreateAssetMenu(fileName = "SpruceStorage", menuName = "SpruceStorage")]
public class SpruceStorage : ScriptableObject
{
    public List<SpruceStorageNode> Nodes;
    
}

[Serializable]
public struct SpruceStorageNode
{
    public SpruceSpeciesIDs Id;

    public GameObject Prefab;

    public int RegisterCount;
}
