using ResourseSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ResourseSystemView
{
    public class ResourseButton : MonoBehaviour
    {
        [SerializeField] private ResourseTypes resourseType;
        [SerializeField] private Image resourseIcon;
        private void Awake()
        {
            ResourseViewServise.Instance.SetEnabledIcon(resourseIcon, resourseType);
        }
        private void Update()
        {
            ProcesResourse();
        }
        private void ProcesResourse()
            {
                //TODO process resourse with tima data
            }
}
}
