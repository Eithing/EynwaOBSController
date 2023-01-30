using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Enums;
using EynwaObsController.ApiService;
using Refit;
using EynwaObsController.Model.Hue;

namespace EynwaObsController.Functions
{
    public class TwitchChatBot
    {
        public TwitchClient client;
        private ObsController obsController;

        public int MuteDelay = 5;
        public int PopoDelay = 5;
        public int LaterDelay = 5;
        public int ChehDelay = 5;
        public int GgDelay = 5;
        public int RipDelay = 5;
        public bool IsMuteEnable;
        public bool IsPopoEnable;
        public bool IsLaterEnable;
        public bool IsChehEnable;
        public bool IsGgEnable;
        public bool IsRipEnable;
        public DateTime PreviousMute = DateTime.Now.AddMinutes(-5);
        public DateTime PreviousPopo = DateTime.Now.AddMinutes(-5);
        public DateTime PreviousLater = DateTime.Now.AddMinutes(-5);
        public DateTime PreviousCheh = DateTime.Now.AddMinutes(-5);
        public DateTime PreviousGg = DateTime.Now.AddMinutes(-5);
        public DateTime PreviousRip = DateTime.Now.AddMinutes(-5);
        IHueService hueService;

        public TwitchChatBot(ObsController _obsController)
        {
            obsController = _obsController;
            ConnectionCredentials credentials = new ConnectionCredentials("eithing", "ny9wpcq6xfpd68pyrsw1qg6tboa47e");
            var clientOptions = new ClientOptions
            {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };
            WebSocketClient customClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(customClient);
            client.Initialize(credentials, "eithing");

            client.OnLog += Client_OnLog;
            client.OnMessageReceived += Client_OnMessageReceived;
            this.hueService = RestService.For<IHueService>("http://192.168.1.21/api");

            //client.OnJoinedChannel += Client_OnJoinedChannel;
            //client.OnWhisperReceived += Client_OnWhisperReceived;
            //client.OnNewSubscriber += Client_OnNewSubscriber;
            //client.OnConnected += Client_OnConnected;

            client.Connect();
            
        }

        private void Client_OnLog(object sender, OnLogArgs e)
        {
            Console.WriteLine($"{e.DateTime.ToString()}: {e.BotUsername} - {e.Data}");
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            Console.WriteLine($"Connected to {e.AutoJoinChannel}");
        }

        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            Console.WriteLine("Hey guys! I am a bot connected via TwitchLib!");
            //client.SendMessage(e.Channel, "Hey guys! I am a bot connected via TwitchLib!");
        }

        private async void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.Contains("mute", StringComparison.OrdinalIgnoreCase) && IsMuteEnable && DateTime.Now > PreviousMute.AddMinutes(MuteDelay))
            {
                PreviousMute = DateTime.Now;
                await obsController.Mute();
            }
            if (e.ChatMessage.Message.Contains("popopo", StringComparison.OrdinalIgnoreCase) && IsPopoEnable && DateTime.Now > PreviousPopo.AddMinutes(PopoDelay))
            {
                PreviousPopo = DateTime.Now;
                await obsController.Popopo();
            }
            if (e.ChatMessage.Message.Contains("later", StringComparison.OrdinalIgnoreCase) && IsLaterEnable && DateTime.Now > PreviousLater.AddMinutes(LaterDelay))
            {
                PreviousLater = DateTime.Now;
                await obsController.Later();
            }
            if (e.ChatMessage.Message.Contains("cheh", StringComparison.OrdinalIgnoreCase) && IsChehEnable && DateTime.Now > PreviousCheh.AddMinutes(ChehDelay))
            {
                await Task.Delay(1000);

                LightUpdateParams param = new LightUpdateParams { Bri = 254, Hue = 50261, On = true, Sat = 189 };
                //"hue": 50261,     -41435      -23730  -31139  -11770  -63451  -9219   -26932
                //"sat": 189,       -77         -254    -220    -80     -248    -228    -213
                await this.hueService.ChangeLight(param, "3");
                await Task.Delay(400);
                param.Hue = 41435;
                param.Sat = 77;
                await this.hueService.ChangeLight(param, "3");
                await Task.Delay(400);
                param.Hue = 23730;
                param.Sat = 254;
                await this.hueService.ChangeLight(param, "3");
                await Task.Delay(400);
                param.Hue = 31139;
                param.Sat = 220;
                await this.hueService.ChangeLight(param, "3");
                await Task.Delay(400);
                param.Hue = 11770;
                param.Sat = 80;
                await this.hueService.ChangeLight(param, "3");
                await Task.Delay(400);
                param.Hue = 63451;
                param.Sat = 248;
                await this.hueService.ChangeLight(param, "3");
                await Task.Delay(400);
                param.Hue = 9219;
                param.Sat = 228;
                await this.hueService.ChangeLight(param, "3");
                await Task.Delay(400);
                param.Hue = 26932;
                param.Sat = 213;
                await this.hueService.ChangeLight(param, "3");
                await Task.Delay(400);
                param.Hue = 50261;
                param.Sat = 189;
                await this.hueService.ChangeLight(param, "3");

            }
            if (e.ChatMessage.Message.Contains("gg", StringComparison.OrdinalIgnoreCase) && IsGgEnable && DateTime.Now > PreviousGg.AddMinutes(GgDelay))
            {
                PreviousGg = DateTime.Now;
                await obsController.Gg();
            }
            if (e.ChatMessage.Message.Contains("rip", StringComparison.OrdinalIgnoreCase) && IsRipEnable && DateTime.Now > PreviousRip.AddMinutes(RipDelay))
            {
                PreviousRip = DateTime.Now;
                await obsController.Rip();
            }
        }

        private void Client_OnWhisperReceived(object sender, OnWhisperReceivedArgs e)
        {
            //if (e.WhisperMessage.Username == "my_friend")
            //    client.SendWhisper(e.WhisperMessage.Username, "Hey! Whispers are so cool!!");
        }

        private void Client_OnNewSubscriber(object sender, OnNewSubscriberArgs e)
        {
            //if (e.Subscriber.SubscriptionPlan == SubscriptionPlan.Prime)
            //    client.SendMessage(e.Channel, $"Welcome {e.Subscriber.DisplayName} to the substers! You just earned 500 points! So kind of you to use your Twitch Prime on this channel!");
            //else
            //    client.SendMessage(e.Channel, $"Welcome {e.Subscriber.DisplayName} to the substers! You just earned 500 points!");
        }
    }
}
