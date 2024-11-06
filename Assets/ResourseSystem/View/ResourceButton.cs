using Core;
using ResourceSystem;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace ResourseSystemView
{
    public class ResourceButton : MonoBehaviour
    {
        [SerializeField] private ResourceTypes resourseType;
        [SerializeField] private Image resourseIcon;
        [SerializeField] private Button _clickButton;
        private float _firstTimer;
        private float _secondTimer;
        private Coroutine enumerator;
        public static event Action OnClick;
/*        private float _firstRealtime;
        private float _secondRealtime;*/
        private void Awake()
        {
            ResourseViewServise.Instance.SetEnabledIcon(resourseIcon, resourseType);
            ReadDataservice.Instance.SetEnableTime(ref _firstTimer, resourseType);
            ReadDataservice.Instance.SetDisableTime(ref _secondTimer, resourseType);
            _clickButton.onClick.AddListener(StartTimer);
            StartTimer();
        }
        private IEnumerator Processresource()
        {
            ResourseViewServise.Instance.SetEnabledIcon(resourseIcon, resourseType);

            yield return new WaitForSeconds(_firstTimer);
            ResourseViewServise.Instance.SetDisabledIcon(resourseIcon, resourseType);

            yield return new WaitForSeconds(_secondTimer);
            OnClick?.Invoke();
        }
        private void StartTimer()
        {
            if (enumerator != null)
            {
                StopCoroutine(enumerator);
            }
           enumerator = StartCoroutine(Processresource());
        }

        /*        private void Update()
                {
                    if (_firstRealtime >= 0)
                    {
                        _firstRealtime -= Time.deltaTime;
                    }
                    else if (_secondTimer >= 0)
                    {
                        _secondRealtime -= Time.deltaTime;
                    }
                }
                private void ProcesResource()
                {
                    ResourseViewServise.Instance.SetEnabledIcon(resourseIcon, resourseType);
                    _firstRealtime = _firstTimer;
                    _secondRealtime = _secondTimer;
                }*/


    }
}
