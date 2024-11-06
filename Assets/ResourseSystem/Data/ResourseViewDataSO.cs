using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEngine;


namespace ResourceSystem
{
    [CreateAssetMenu(fileName = "ResourseViewData",

    menuName = "SO/New Resourse View Data")]
    public class ResourseViewDataSO : ScriptableObject
    {
        
        [field:SerializeField] public List<ResourseViewData> ResourceViewData { get; private set; }
        public bool TryGetEnabledIcon(ResourceTypes resourseType, out Sprite icon)
        {
            icon = null;
            foreach (var viewData in ResourceViewData)
            {
                if (viewData.ResourseType == resourseType)
                {
                    icon = viewData.ActiveStateIcon;
                    return true;
                }
            }
            return false;
        }
        public bool TryGetDisabledIcon(ResourceTypes resourseType, out Sprite icon)
        {
            icon = null;
            foreach (var viewData in ResourceViewData)
            {
                if (viewData.ResourseType == resourseType)
                {
                    icon = viewData.DisabledStateIcon;
                    return true;
                }
            }
            return false;
        }
    }
}