using UnityEngine;
using UnityEngine.UIElements;

namespace Scripts
{
    public class HUDController : MonoBehaviour
    {
        Label _countLabel;
        Label _youWinLabel;
        Label _youLoseLabel;

        void Awake()
        {
            var root = GetComponent<UIDocument>().rootVisualElement;

            _countLabel = root.Q<Label>("CountTextLabel");
            _youWinLabel = root.Q<Label>("YouWinLabel");
            _youLoseLabel = root.Q<Label>("YouLoseLabel");
        }

        void Start()
        {
            SetCountText(0);
            _youWinLabel.style.visibility = Visibility.Hidden;
            _youLoseLabel.style.visibility = Visibility.Hidden;
        }

        public void SetCountText(int count)
        {
            _countLabel.text = $"Count: {count}";
        }

        public void ShowYouWin()
        {
            _youWinLabel.style.visibility = Visibility.Visible;
        }

        public void ShowYouLose()
        {
            _youLoseLabel.style.visibility = Visibility.Visible;
        }
    }
}
