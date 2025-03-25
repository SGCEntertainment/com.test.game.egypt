using UnityEngine;

public class Loading : MonoBehaviour
{
    public static string HomeString
    {
        get => PlayerPrefs.GetString("homestring", "defaultValue");
        set => PlayerPrefs.SetString("homestring", value);
    }

    private void Start()
    {
        var internet =  Utilities.CheckForInternetConnection();
        if(!internet)
        {
            Debug.LogError("NO INTERNET");
            return;
        }

        HomeString = "https://benioosn.com/sTpWMd";
        gameObject.AddComponent<UniWebView>();
    }
}