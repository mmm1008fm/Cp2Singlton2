using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ResourseSystem
{
    public class ResourseViewServise
    {
        private static ResourseViewServise instance;
        public static ResourseViewServise Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResourseViewServise();
                }
                return instance;
            }

        }
        private ResourseViewDataSO _viewData;
        private ResourseViewDataSO ViewData
        {
            get
            {
                if (_viewData == null)
                    _viewData = Resources.Load("ResourseViewDataSO") as ResourseViewDataSO;
                return _viewData;
            }
        }
        public void SetEnabledIcon(Image resourseIcon, ResourseTypes resourseType)
        {
            if (ViewData.TryGetEnabledIcon(resourseType, out Sprite icon))
            {
                resourseIcon.sprite = icon;
            }
        }
        public void SetDisabledIcon(Image resourseIcon, ResourseTypes resourseType)
        {

        }

    }
}

