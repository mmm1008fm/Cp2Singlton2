using ResourceSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ResourceSystem
{
    public class ReadDataservice
    {
        private static ReadDataservice instance;
        public static ReadDataservice Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReadDataservice();
                }
                return instance;
            }
        }

        private ResourseTimeDataSO data;
        private ResourseTimeDataSO Data
        {
            get
            {
                if (data == null)
                {
                    data = Resources.Load("ResourseTimeData") as ResourseTimeDataSO;
                }
                return data;
            }
        }
        public void SetEnableTime(ref float timer, ResourceTypes resourcetype)
        {
            Debug.Log(Data);
            if (Data.TryGetEnabledIcon(resourcetype, out float value))
            {
                timer = value;
            }
        }        
        public void SetDisableTime(ref float timer, ResourceTypes resourcetype)
        {
            Debug.Log(Data);
            if (Data.TryGetDisabledIcon(resourcetype, out float value))
            {
                timer = value;
            }
        }
    }
}

