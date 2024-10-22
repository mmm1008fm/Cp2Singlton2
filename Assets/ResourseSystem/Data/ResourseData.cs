using ResourseSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResourseSystem
{
    [Serializable]
    public class ResourseData
    {
        [field: SerializeField] public ResourseTypes ResourseType { get; private set; }
        [field: SerializeField] float EnabledTime { get; private set; }
        [field: SerializeField] float DisabledTime { get; private set; }
    }
}