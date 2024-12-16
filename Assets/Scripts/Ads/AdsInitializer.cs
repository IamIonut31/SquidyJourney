using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] string _androidGameId;
    [SerializeField] string _iOSGameId;
    string _gameId;
    string _interstitialPlatform;
    string _rewardedPlatform;
    [SerializeField] bool _testMode = true;
    public RespawnPlayer respawnPlayer;

    private void Start()
    {
        InitializeAds();
        if (Score.TriesNumber == 4)
        {
            Score.TriesNumber = 0;
            if (Advertisement.isInitialized)
            {
                LoadInerstitialAd(); 
            }
        }
    }
    public void InitializeAds()
    {
        _gameId = (Application.platform == RuntimePlatform.IPhonePlayer) ? _iOSGameId : _androidGameId;
        Advertisement.Initialize(_gameId, _testMode, this);

    }

    public void OnInitializationComplete()
    {
        //Debug.Log("Initializare Completa");
        //LoadInerstitialAd();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        //Debug.Log($"Initializare Incompleta: {error.ToString()} - {message}");
    }

    public void LoadInerstitialAd()
    {
        _interstitialPlatform = (Application.platform == RuntimePlatform.IPhonePlayer) ? "Interstitial_iOS" : "Interstitial_Android";
        Advertisement.Load(_interstitialPlatform, this);
    }

    public void LoadRewardedAd()
    {
        _rewardedPlatform = (Application.platform == RuntimePlatform.IPhonePlayer) ? "Rewarded_iOS" : "Rewarded_Android";
        Advertisement.Load(_rewardedPlatform, this);
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        Advertisement.Show(placementId, this);
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {

    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {

    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Time.timeScale = 0;
    }

    public void OnUnityAdsShowClick(string placementId)
    {

    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Time.timeScale = 1;
        if (placementId.Equals(_rewardedPlatform) && UnityAdsShowCompletionState.COMPLETED.Equals(showCompletionState))
        {
            respawnPlayer.Respawn();
        }
        Time.timeScale = 1;
    }
}
