using System;
using UnityEngine;
namespace ResourceSystem
{
    [Serializable]
    public class ResourseViewData
    {
        [field:SerializeField] public ResourceTypes ResourseType { get; private set; }
        [field:SerializeField] public Sprite ActiveStateIcon { get; private set; }
        [field:SerializeField] public Sprite DisabledStateIcon { get; private set; }
    }

}