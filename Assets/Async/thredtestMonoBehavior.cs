using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class thredtestMonoBehavior : MonoBehaviour
{
    [SerializeField]
    private Text label = null;
    [SerializeField]
    private Text stateLabel = null;

    // Start is called before the first frame update
    void Start()
    {
        //var test = new thredtest();
        //test.thredRun(label);
    }

    private void OnEnable()
    {
        //        var test = new thredtest();
        var test = new asyncHttpTest();
        test.taskRun(label, stateLabel);
    }

    //void thredRun()
    //{
    //    stateLabel.text = "Start";
    //    var th = new Thread(shori);
    //    th.Start();
    //}

    //void shori()
    //{
    //    for (int i = 0; i < 2000000; i++)
    //    {
    //        label.text = i.ToString();
    //    }

    //    stateLabel.text = "End";
    //}

}
