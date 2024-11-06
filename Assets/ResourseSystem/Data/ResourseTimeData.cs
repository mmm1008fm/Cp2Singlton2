using System;
using UnityEngine;
namespace ResourceSystem
{
    [Serializable]
    public class ResourseTimeData
    {
        [field: SerializeField] public ResourceTypes ResourseType { get; private set; }
        [field: SerializeField] public float EnrichmentTime { get; private set; }
        [field: SerializeField] public float DecayTime { get; private set; }
    }

}