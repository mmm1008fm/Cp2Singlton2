using System;
using UnityEngine;
namespace ResourseSystem
{
    [Serializable]
    public class ResourseViewData
    {
        [field:SerializeField] public ResourseTypes ResourseType { get; private set; }
        [field:SerializeField] public Sprite ActiveStateIcon { get; private set; }
        [field:SerializeField] public Sprite DisabledStateIcon { get; private set; }
    }

}