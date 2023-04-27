using System;
using UnityEngine;
using UnityEngine.UI;
using Utils;
using Utils.Signal;

namespace UISystem.View
{
    public class PanelView : MonoBehaviour
    {
        [SerializeField] private Image image;
        [SerializeField] private Button crossButton;

        private void Awake()
        {
            Signals.Get<ChangePanelUI>().AddListener(OnChangeImage);
        }

        private void OnEnable()
        {
            crossButton.onClick.AddListener(OnCrossPressed);
        }

        private void OnDisable()
        {
            crossButton.onClick.RemoveListener(OnCrossPressed);
        }

        private void OnDestroy()
        {
            Signals.Get<ChangePanelUI>().RemoveListener(OnChangeImage);
        }

        private void OnChangeImage()
        {
            if (!image.IsActive())
            {
                image.enabled = true;
                return;
            }

            if (image.color.a == 0)
                image.enabled = false;
        }

        private void OnCrossPressed()
        {
            Signals.Get<SwitchPanelState>().Dispatch();
        }
    }
}
