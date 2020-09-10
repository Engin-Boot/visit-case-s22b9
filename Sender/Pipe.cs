using System;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace Sender
{
    public class Pipe
    {
        public void SendDataToReceiver()
        {
            Process parentPipeProcess = new Process();
            parentPipeProcess.StartInfo.FileName = "Receiver.exe";

            using (AnonymousPipeServerStream pipeServer = 
                new AnonymousPipeServerStream(PipeDirection.Out,
                    HandleInheritability.Inheritable))
            {
                Console.WriteLine("[SERVER] Current TransmissionMode: {0}.",
                    pipeServer.TransmissionMode);

                // Pass the client process a handle to the server.
                parentPipeProcess.StartInfo.Arguments = pipeServer.GetClientHandleAsString();
                parentPipeProcess.StartInfo.UseShellExecute = false;
                parentPipeProcess.Start();
                pipeServer.DisposeLocalCopyOfClientHandle();
                try
                {
                    // Read user input and send that to the client process.
                    using (StreamWriter sw = new StreamWriter(pipeServer))
                    {
                        sw.AutoFlush = true;
                        // Send a 'sync message' and wait for client to receive it.
                        sw.WriteLine("SYNC");
                        pipeServer.WaitForPipeDrain();
                        // Send the console input to the client process.
                        Console.Write("[SERVER] Enter text: ");
                        sw.WriteLine(Console.ReadLine());
                    }
                }
                // Catch the IOException that is raised if the pipe is broken
                // or disconnected.
                catch (IOException e)
                {
                    Console.WriteLine("[SERVER] Error: {0}", e.Message);
                }
            }

            parentPipeProcess.WaitForExit();
            parentPipeProcess.Close();
            Console.WriteLine("[SERVER] Client quit. Server terminating.");
        }

    }
}
