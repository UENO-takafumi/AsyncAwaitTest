using UnityEngine;
using UnityEngine.UI;

public class AsyncTestMonoBehavior : MonoBehaviour
{
    [SerializeField]
    private Text label = null;
    [SerializeField]
    private Text stateLabel = null;

    private void OnEnable()
    {
        var test = new AsyncHttpTest();
        test.Request("https://api.etherscan.io/api?module=proxy", label, stateLabel);
    }
}
