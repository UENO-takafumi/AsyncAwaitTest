using System.Threading.Tasks;
using System.Threading;
using UnityEngine.UI;
using System.Collections.Generic;

public class asyncTest
{
    public async void taskRun(Text label, Text StateLabel)
    {
        StateLabel.text = "AsyncStartTask";
        long result = await toMuchShori();
        label.text = result.ToString();
        StateLabel.text = "End";
    }

    private async Task<long> toMuchShori()
    {
        var allList = new List<string>();
        await Task.Run(() => {

            for (int i = 0; i < 400; i++)
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

            string dataresult = "";

            foreach (var data in allList)
            {
                dataresult = dataresult + "::" + data;
            }
        });

        return allList.Count;
    }

}
