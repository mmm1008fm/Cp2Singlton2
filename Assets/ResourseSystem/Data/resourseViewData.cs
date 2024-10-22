using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEngine;
namespace ResourseSystem
{
    [CreateAssetMenu(fileName = "ResourseViewData",

    menuName = "SO/New Resourse View Data")]
    public class resourseViewData : ScriptableObject
    {
        [SerializeField] public List<resourseViewData> ResourseViewData { get; private set; }
    }
    public enum ResourseTypes
    { 
        
    }
    public bool TryGetEnabledIcon(ResourseTypes resourseType, out Sprite icon)
    {
        icon = null;
        foreach (var viewData in ResourseViewData)
        {
            if (viewData.ResourseType == resourseType)
            {
                return true;
            }
            }
            return false;
    }    public bool TryGetDisabledIcon(ResourseTypes resourseType, out Sprite icon)
    {
        icon = null;
        foreach (var viewData in ResourseViewData)
        {
            if (viewData.ResourseType == resourseType)
            {
                return true;
            }
            }
            return false;
    }
    [Serializable]
    public class ResourseNewData
    {
        [field:SerializeField] public ResourseTypes ResourseType { get; private set; }
        [field:SerializeField] public Sprite ActiveStateIcon { get; private set; }
        [field:SerializeField] public Sprite DisabledStateIcon { get; private set; }
    }
}