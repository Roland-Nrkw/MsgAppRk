using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;//Form
using Microsoft.Azure.ServiceBus;//IQueueClient, Message

/* Edit of MsgApp by Roland Kwee (Eurofins Omegam, Amsterdam, The Netherlands, rolandkwee@eurofins.com) 28 oct 2020:
 * This is a modification of MsgApp by Maruti Makwana.
 * I was not happy with the console app.
 * I believe that console app are something of the past.
 * A Forms app does not add much lines of code to a console app.
 * It is only slightly more complex, but offers many advantages, such as a nice GUI.
 * If you don't like complexity, don't look at Azure, where you have to manage disk, cpu, nic, networking, firewall, monitoring, virtual network, 
 * queues, service level, plan, zone, region, and a whole lot more even for the smallest cloud app.
 * 
 * The only problem is that this forms app does not work.
 * Probably due to a coding error involving task/async.
 * Most likely anyone other than the author will spot the error in two seconds.
 * Thanks for fixing this!
 * 
 * 
 */

namespace Msg_Forms
{
    public partial class Form1 : Form
    {
        private IQueueClient _queueClient;

        public Form1()
        {
            InitializeComponent();
            textBox_ConnectionString.Text = "Endpoint=sb://[your_connection_string_here];";
            textBox_Queue.Text = "queue1";
            numericUpDown_Nr_Msgs.Value = 5;
        }

        /// <summary>
        /// Return True on successfully opening the service bus queue
        /// </summary>
        /// <returns></returns>
        private bool Open_ServicebusQueue()
        {
            bool OpenOk = false;
            try
            {
                _queueClient = new QueueClient(textBox_ConnectionString.Text, textBox_Queue.Text);
                OpenOk = true;
            }
            catch(Exception e)
            {
                Msg($"Exception: {e.Message}");
                OpenOk = false;
            }
            if (_queueClient == null)
            {
                Msg("Error: Servicebus Queue could not be opened.");
                Msg("did you enter a valid sb and queue?");
                OpenOk = false;
            }
            return OpenOk;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_Msgs.Text = "";
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (Open_ServicebusQueue())
                SendAsync().GetAwaiter().GetResult();
        }

        private void button_Receive_Click(object sender, EventArgs e)
        {
            if (Open_ServicebusQueue())
                ReceiveAsync().GetAwaiter().GetResult();
        }

        async Task SendAsync()
        {
            await SendMessagesAsync((int)numericUpDown_Nr_Msgs.Value);
            await _queueClient.CloseAsync();
        }

        async Task ReceiveAsync()
        {
            // Register QueueClient's MessageHandler and receive messages in a loop
            RegisterOnMessageHandlerAndReceiveMessages();
            await _queueClient.CloseAsync();
        }

        async Task SendMessagesAsync(int numberOfMessagesToSend)
        {
            try
            {
                for (int i = 0; i < numberOfMessagesToSend; i++)
                {
                    // Create a new message to send to the queue.
                    string messageBody = $"Message {i}";
                    Microsoft.Azure.ServiceBus.Message message = new Microsoft.Azure.ServiceBus.Message(Encoding.UTF8.GetBytes(messageBody));
                    // Write the body of the message to the GUI.
                    Msg($"Sending message: {messageBody}");
                    // Send the message to the queue.
                    await _queueClient.SendAsync(message);
                }
                Msg("Sending done.");
            }
            catch (Exception exception)
            {
                richTextBox_Msgs.Text += $"{DateTime.Now} :: Exception: {exception.Message}\n";
            }
        }

        void RegisterOnMessageHandlerAndReceiveMessages()
        {
            // Configure the MessageHandler Options in terms of exception handling, number of concurrent messages to deliver etc.
            MessageHandlerOptions messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                // Maximum number of Concurrent calls to the callback `ProcessMessagesAsync`, set to 1 for simplicity.
                // Set it according to how many messages the application wants to process in parallel.
                MaxConcurrentCalls = 1,

                // Indicates whether MessagePump should automatically complete the messages after returning from User Callback.
                // False below indicates the Complete will be handled by the User Callback as in `ProcessMessagesAsync` below.
                AutoComplete = false
            };
            // Register the function that will process messages
            _queueClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);
        }

        async Task ProcessMessagesAsync(Microsoft.Azure.ServiceBus.Message message, CancellationToken token)
        {
            // Process the message
            Msg($"Received message: SequenceNumber:{message.SystemProperties.SequenceNumber} Body:{Encoding.UTF8.GetString(message.Body)}");

            // Complete the message so that it is not received again.
            // This can be done only if the queueClient is created in ReceiveMode.PeekLock mode (which is default).
            await _queueClient.CompleteAsync(message.SystemProperties.LockToken);

            // Note: Use the cancellationToken passed as necessary to determine if the queueClient has already been closed.
            // If queueClient has already been Closed, you may chose to not call CompleteAsync() or AbandonAsync() etc. calls 
            // to avoid unnecessary exceptions.
        }

        Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            Msg($"Message handler encountered an exception {exceptionReceivedEventArgs.Exception}.");
            ExceptionReceivedContext context = exceptionReceivedEventArgs.ExceptionReceivedContext;
            Msg("Exception context for troubleshooting:");
            Msg($"- Endpoint: {context.Endpoint}");
            Msg($"- Entity Path: {context.EntityPath}");
            Msg($"- Executing Action: {context.Action}");
            return Task.CompletedTask;
        }

        /// <summary>
        /// Replacement of Console.WriteLine()
        /// </summary>
        /// <param name="S"></param>
        private void Msg(string S)
        {
            richTextBox_Msgs.Text += S + "\n";
            Update();
        }
    }//end class
}//end ns
