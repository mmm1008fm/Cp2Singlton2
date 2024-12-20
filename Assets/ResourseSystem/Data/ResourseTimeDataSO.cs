using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ResourceSystem
{
    [CreateAssetMenu(fileName = "ResourseTimeData",

    menuName = "SO/New Resourse Time Data")]

    public class ResourseTimeDataSO : ScriptableObject
    {

        [field: SerializeField] public List<ResourseTimeData> ResourceTimeData { get; private set; }
        public bool TryGetEnabledIcon(ResourceTypes resourseType, out float value)
        {
            value = 0;
            foreach (var viewData in ResourceTimeData)
            {
                if (viewData.ResourseType == resourseType)
                {
                    value = viewData.EnrichmentTime;
                    return true;
                }
            }
            return false;
        }
        public bool TryGetDisabledIcon(ResourceTypes resourseType, out float value)
        {
            value = 0;
            foreach (var viewData in ResourceTimeData)
            {
                if (viewData.ResourseType == resourseType)
                {
                    value = viewData.DecayTime;
                    return true;
                }
            }
            return false;
        }
    }
}