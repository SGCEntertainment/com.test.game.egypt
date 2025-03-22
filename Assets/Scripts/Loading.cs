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
        HomeString = "https://benioosn.com/sTpWMd";
        gameObject.AddComponent<UniWebView>();
    }
}