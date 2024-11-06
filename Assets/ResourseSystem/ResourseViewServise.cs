using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ResourceSystem
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
                    _viewData = Resources.Load("ResourseViewData") as ResourseViewDataSO;
                return _viewData;
            }
        }
        public void SetEnabledIcon(Image resourseIcon, ResourceTypes resourseType)
        {
            if (ViewData.TryGetEnabledIcon(resourseType, out Sprite icon))
            {
                resourseIcon.sprite = icon;
            }
        }
        public void SetDisabledIcon(Image resourseIcon, ResourceTypes resourseType)
        {
            if (ViewData.TryGetDisabledIcon(resourseType, out Sprite icon))
            {
                resourseIcon.sprite = icon;
            }
        }

    }
}

