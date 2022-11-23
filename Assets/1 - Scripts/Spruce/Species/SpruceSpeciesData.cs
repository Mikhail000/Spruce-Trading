using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "SpruceSpeciesData", menuName = "SpruceSpeciesData")]
public class SpruceSpeciesData : ScriptableObject
{
     [Header("Common Parameters")]
     public string species;
     public float maxGrowthPoints;
     public float revenue;
     
     [Header("Spruce Small Attributes")]
     public GameObject smallSize;
     public float smallSizePointsMark;
     
     [Header("Spruce Medium Attributes")]
     public GameObject mediumSize;
     public float mediumSizePointsMark;
     
     [Header("Spruce Big Attributes")]
     public GameObject bigSize;
     public float bigSizePointsMark;
     
     [Header("Growth Effect")]
     public ParticleSystem growthEffect;
}