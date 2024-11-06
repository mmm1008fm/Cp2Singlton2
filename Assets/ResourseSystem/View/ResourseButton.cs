using Core;
using ResourceSystem;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace ResourseSystemView
{
    public class ResourseButton : MonoBehaviour
    {
        [SerializeField] private ResourceTypes resourseType;
        [SerializeField] private Image resourseIcon;
        private void Awake()
        {
            ResourseViewServise.Instance.SetEnabledIcon(resourseIcon, resourseType);
        }
        private void Update()
        {
            ProcesResource();
        }
        private void ProcesResource()
        {
/*          if (Decay time == 0) 
        {
                Game.FinishGame()
        }*/
        }


}
}
