using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class UIManager : MonoBehaviour
    {
        [Header("GameObjects")]
        [SerializeField] private GameObject gamePanel;
        [SerializeField] private GameObject finishPanel;

        [Header("TextFields")]
        [SerializeField] private TextMeshProUGUI finalTime;
        [SerializeField] private TextMeshProUGUI time;
        [SerializeField] private TextMeshProUGUI starsCount;

        [Header("Other")]
        [SerializeField] private Slider starsSlider;

        public void ShowFinishPanel()
        {
            gamePanel.SetActive(false);
            finishPanel.SetActive(true);
            finalTime.text = time.text;
        }
        
        public void UpdateStarsCount(string text)
        {
            starsCount.text = text;
        }

        public void UpdateSlider(float val)
        {
            starsSlider.value = val;
        }

        public void UpdateTime(int v)
        {
            time.text = v.ToString();
        }
    }
}