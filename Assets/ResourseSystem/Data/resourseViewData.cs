using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEngine;


namespace ResourseSystem
{
    [CreateAssetMenu(fileName = "ResourseViewData",

    menuName = "SO/New Resourse View Data")]
    public class ResourseViewData : ScriptableObject
    {
        
        [field:SerializeField] public List<ResourseNewData> ResourceViewData { get; private set; }
        public bool TryGetEnabledIcon(ResourseTypes resourseType, out Sprite icon)
        {
            icon = null;
            foreach (var viewData in ResourceViewData)
            {
                if (viewData.ResourseType == resourseType)
                {
                    return true;
                }
            }
            return false;
        }
        public bool TryGetDisabledIcon(ResourseTypes resourseType, out Sprite icon)
        {
            icon = null;
            foreach (var viewData in ResourceViewData)
            {
                if (viewData.ResourseType == resourseType)
                {
                    return true;
                }
            }
            return false;
        }
    }
}