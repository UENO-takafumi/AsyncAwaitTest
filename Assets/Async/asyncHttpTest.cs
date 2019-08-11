using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UniRx.Async;

public class asyncHttpTest
{
    public void taskRun(Text label, Text stateLabel)
    {
        AsyncHttpRequest("https://api.etherscan.io/api?module=proxy", label, stateLabel);
    }

    private async Task AsyncHttpRequest(string urlstr, Text label, Text stateLabel)
    {
        stateLabel.text = "AsyncStartTask";

        UnityWebRequest request = UnityWebRequest.Get(urlstr);
        await request.SendWebRequest();

        var text = request.downloadHandler.text;

        Debug.Log("AsyncStartTask" + Thread.CurrentThread.ManagedThreadId);

        await Task.Run(() => {
            // ただ重い処理したいだけ
            var allList = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    for (int k = 0; k < 20; k++)
                    {
                        var kList = new List<string>();
                        kList.Add("k=" + k);
                        kList.Add("k=" + k);
                        kList.Add("k=" + k);
                        kList.Add("k=" + k);
                        allList.AddRange(kList);
                    }
                }
            }

            foreach (var data in allList)
            {
                text = text + "::" + data;
            }

            Debug.Log("Run" + Thread.CurrentThread.ManagedThreadId);
            Debug.Log(text);
        });

        label.text = text;

        stateLabel.text = "End";
        Debug.Log("End" + Thread.CurrentThread.ManagedThreadId);

    }

}
