using ResourseSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ResourceSystem
{
    public class ReadDataservice
    {
        private static ReadDataservice insctance;
        public static ReadDataservice instance
        {
            get
            {
                if (insctance == null)
                {
                    insctance = new ReadDataservice();
                }
                return insctance;
            }
        }

        private ResourseTimeDataSO data;
        private ResourseTimeDataSO Data
        {
            get
            {
                if (data == null)
                {
                    data = new Resources.Load("ResourceSO") as ResourceDataSO;
                }
                return data;
            }
        }
        public void SetEnableTime(ref float timer, ResoutceType resourcetype)
        {
            Debug.Log(Data);
            if (Data.EnableTime())
            {

            }
        }
    }
}

