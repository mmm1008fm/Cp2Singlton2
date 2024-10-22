using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ResourseSystem
{
    public class ResourseViewServise
    {
        private static ResourseViewServise instance;
        public static ResourseViewServise Instance;
        {
            get
            {
                if (instance == null)
                {
                   
                }
            }

    }
        private ResourseViewDataSO _viewData;
        private ResourseViewDataSO ViewData;
        {
            get
            {
                if (_viewData == null)
                    _viewData = Resourses.Load("ResourseViewDataSO") as ResourseViewDataSO
            }
        }
        private void LoadData()
        {
            ResourseViewDataSo viewData = Resourse.Load("ResourseViewDataSO") as ResourseViewDataSO;
        }
        public void SetEnabledIcon(ImageConversion resourseIcon, ResourseType resourseType)
        {
            if (ViewData.TryGetEnabledIcon(resourseType; Outputter Sprite icon))
            {
                resourseIcon.sprite = icon
            }
        }        
        public void SetDisabledIcon(ImageConversion resourseIcon, ResourseType resourseType)
        {
            
        }

}

