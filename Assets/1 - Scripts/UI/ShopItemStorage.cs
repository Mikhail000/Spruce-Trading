using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ShopItemStorage", menuName = "ShopItemStorage")]
public class ShopItemStorage : ScriptableObject
{
    public List<ShopItemStorageNode> Nodes;
}

[Serializable]
public struct ShopItemStorageNode
{
    public GameObject Prefab;

    public Image InaccessibleImage;

    public Image AccessibleImage;
}


