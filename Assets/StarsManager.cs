using DefaultNamespace;
using UnityEngine;

public class StarsManager : MonoBehaviour
{
    [SerializeField] private UIManager ui;
    [SerializeField] private GameManager game;

    private int _currentStarCollected;
    private int _maxStarCount;
    
    void Start()
    {
        _currentStarCollected = 0;
        _maxStarCount = transform.childCount;
        
        UpdateView();
        UpdateProgress();
    }

    private void UpdateView()
    {
        ui.UpdateStarsCount(_currentStarCollected + "/" + _maxStarCount);
    }

    private void UpdateProgress()
    {
        ui.UpdateSlider((float)_currentStarCollected/_maxStarCount);
    }
    
    public void StarCollected()
    {
        _currentStarCollected++;
        UpdateView();
        UpdateProgress();
        
        if (_currentStarCollected == _maxStarCount) game.Finish();
    }

}
