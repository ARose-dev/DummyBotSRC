﻿using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace DummyBot
{
    public class Serverstatus
    {
        public static int pingtimeout = 60000;
        public static string serverstat_flarenet_nextcloud;
        public static string[] serverstat_flarenet_nextcloud_advstats;
        public static string serverstat_delta1_minecraftjava_personalsrv;

        public static void Serverping_jellyfin()
        {
            Ping nextcloudstatus = new Ping();
            PingReply nextcloudreply = nextcloudstatus.Send("nextcloud.flarenet.co.uk", pingtimeout);

            if (nextcloudreply.Status == IPStatus.Success)
            {
                serverstat_flarenet_nextcloud = "> https://nextcloud.flarenet.co.uk - Online";

                
                
                serverstat_flarenet_nextcloud_advstats[0] = "Address: " + nextcloudreply.Address.ToString();
                serverstat_flarenet_nextcloud_advstats[1] = "Buffer Size: " + nextcloudreply.Buffer.ToString();
                serverstat_flarenet_nextcloud_advstats[2] = "RoundTrip time: " + nextcloudreply.RoundtripTime.ToString();
                serverstat_flarenet_nextcloud_advstats[3] = "Time to live: " + nextcloudreply.Options.Ttl.ToString();
                


            }

            else
            {
                serverstat_flarenet_nextcloud = "> https://nextcloud.flarenet.co.uk - Offline";
            }

            
            
            
            //Legacy Code - 11/03/2022
            /*TcpClient tcpClient = new TcpClient();

            try
            {
                tcpClient.Connect("86.14.65.74", 8096);

                serverstat_delta1_jellyfin = "Jellyfin@Deltaserver1: Online";

            }
            catch (Exception)
            {
                serverstat_delta1_jellyfin = "Jellyfin@Deltaserver1: Offline";
            }*/
            

        }

        public static void Serverping_minecraftjava_personalsrv()
        {
            /*TcpClient tcpClient = new TcpClient();

            try
            {
                tcpClient.Connect("86.14.65.74", 25565);

                serverstat_delta1_minecraftjava_personalsrv = "Minecraft-personalsrv@Deltaserver1: Online";

            }
            catch (Exception)
            {
                serverstat_delta1_minecraftjava_personalsrv = "Minecraft-personalsrv@Deltaserver1: Offline";
            }*/
        }
    }
}