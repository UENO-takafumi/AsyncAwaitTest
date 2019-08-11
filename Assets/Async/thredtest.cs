using System.Threading.Tasks;
using UnityEngine.UI;
using System.Collections.Generic;

public class thredtest
{

    public void thredRun(Text label)
    {
        //var th = new Thread(Shori);
        //th.Start();

        var currentContext = TaskScheduler.FromCurrentSynchronizationContext();
        label.text = "Start";
        Task.Run(() => Shori())
            .ContinueWith(task=>{ label.text = "End"; }, currentContext);
//        Shori();
    }


    private void Shori()
    {
        var allList = new List<string>();

        for (int i = 0; i < 400; i++)
        {
            if(i % 2 == 0)
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

        foreach(var data in allList)
        {
            dataresult = dataresult + "::" + data;
        }
    }

}
