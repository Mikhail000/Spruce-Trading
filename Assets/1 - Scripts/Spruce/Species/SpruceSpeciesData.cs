using UnityEngine;

[CreateAssetMenu(fileName = "SpruceSpeciesData", menuName = "SpruceSpeciesData")]
public class SpruceSpeciesData : ScriptableObject
{
     [Header("Common Parameters")]
     public string species;
     public float maxGrowthPoints;
     public float revenue;
     
     [Header("Spruce Small Attributes")]
     public GameObject smallSizeForm;
     public float smallSizePointsMark;
     
     [Header("Spruce Medium Attributes")]
     public GameObject mediumSizeForm;
     public float mediumSizePointsMark;
     
     [Header("Spruce Big Attributes")]
     public GameObject bigSizeForm;
     public float bigSizePointsMark;

     [Header("Spruce FXs")] public ParticleSystem growthEffect;
}