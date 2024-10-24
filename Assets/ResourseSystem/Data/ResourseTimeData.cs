using System;
using UnityEngine;
namespace ResourseSystem
{
    [Serializable]
    public class ResourseTimeData
    {
        [field: SerializeField] public ResourseTypes ResourseType { get; private set; }
        [field: SerializeField] public float EnrichmentTime { get; private set; }
        [field: SerializeField] public float DecayTime { get; private set; }
    }

}