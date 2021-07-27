using System;
using System.Text;
using NsqSharp;

namespace NsqConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nsq消息接受!");

            var topicName = "test-Nsq-Core";//主题消息头
            var consumer = new Consumer(topicName, "testConsumer");
            consumer.AddHandler(new MessageHandler());
            consumer.ConnectToNsqLookupd("192.168.9.120:4161");
            consumer.Stop();
            Console.ReadLine();
        }
        public class MessageHandler : IHandler
        {
            /// <summary>Handles a message.</summary>
            public void HandleMessage(IMessage message)
            {
                var msg = Encoding.UTF8.GetString(message.Body);
                Console.WriteLine("消息接受成功！" + msg);
                var nsqinfo = Newtonsoft.Json.JsonConvert.DeserializeObject<NsqModel.NsqInfo>(msg);
                EmpInfo info = new EmpInfo(nsqinfo.EmpName,nsqinfo.Age, nsqinfo.Address);

                Console.WriteLine("业务处理成功：" + info.Tojson());

            }

            /// <summary>
            /// Called when a message has exceeded the specified <see cref="Config.MaxAttempts"/>.
            /// </summary>
            /// <param name="message">The failed message.</param>
            public void LogFailedMessage(IMessage message)
            {
                // Log failed messages
            }
        }


    }
}
