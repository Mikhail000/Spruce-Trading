using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "SpruceSpeciesData", menuName = "SpruceSpeciesData")]
public class SpruceSpeciesData : ScriptableObject
{
     
     public string species;
     public float maxGrowthPoints;
     public float revenue;
     
     public GameObject smallSize;
     public GameObject mediumSize;
     public GameObject largeSize;
}