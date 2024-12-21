﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67.NewFolder1
{
    using System;

    namespace EventExamples
    {
        public class SubscriberWithEventHandler
        {
            public void Subscribe(PublisherWithEventHandler publisher)
            {
                publisher.Notify += OnNotifyReceived;
            }

            private void OnNotifyReceived(object sender, EventArgs e)
            {
                Console.WriteLine("Событие вызвано с использованием EventHandler.");
            }
        }
    }
}
