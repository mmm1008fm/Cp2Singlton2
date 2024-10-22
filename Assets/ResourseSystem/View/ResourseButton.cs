using ResourseSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ResourseSystemView
{

    public class ResourseButton : MonoBehaviour
    {
        [SerializeField] private ResourseType resourseType;
        [SerializeField] private Image resourseIcon;
        private void Awake()
        {
            RespurseVewSerive.Instanse.SetEnabledIcon(resourseIcon, resourseType);
            Private void Update()
            {
                ProcessResourse
            }

        }
    }
}
