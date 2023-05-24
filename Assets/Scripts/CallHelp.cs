using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CallHelp : MonoBehaviour
{
    string commandText = Directory.GetCurrentDirectory() + @"\Assets\Scripts\Этот файл нужно просто открыть.chm";


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
