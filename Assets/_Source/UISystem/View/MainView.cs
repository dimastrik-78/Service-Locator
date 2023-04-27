using UnityEngine;
using UnityEngine.UI;
using Utils;
using Utils.Signal;

namespace UISystem.View
{
    public class MainView : MonoBehaviour
    {
        [SerializeField] private Button crossButton;

        private void OnEnable()
        {
            crossButton.onClick.AddListener(OnCrossPressed);
        }

        private void OnDisable()
        {
            crossButton.onClick.RemoveListener(OnCrossPressed);
        }

        private void OnCrossPressed()
        {
            Signals.Get<SwitchMainState>().Dispatch();
        }
    }
}
