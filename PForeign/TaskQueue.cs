using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Plang.CSharpRuntime;
using Plang.CSharpRuntime.Values;
using Plang.CSharpRuntime.Exceptions;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Collections;
using System.Security;
using System.Text.Json;
using System.Security.Cryptography;
using System.Text;

public class TaskQueue {
    private Queue<Action> queue = new Queue<Action>();
    private bool isProcessing = false;

    public void Enqueue(Action task)
    {
        queue.Enqueue(task);
        if (!isProcessing)
        {
            ProcessQueue();
        }
    }

    private void ProcessQueue()
    {
        isProcessing = true;
        while (queue.Count > 0)
        {
            Action task = queue.Dequeue();
            task(); // Run the task
        }
        isProcessing = false;
    }
}