using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDPForm
{
    class UDPServer
    {
        IPAddress DestIPAdress = IPAddress.None;
        int DestPort = 0;
        int SrcPort = 0;
        volatile string UDPQueryString = "";
        volatile string UDPAnswerString = "";
        byte[] UDPAnswerArray = null;

#region // Делегаты и События
        public delegate void MethodSent();
        /// <summary>
        /// Событие: Данные отправлены
        /// </summary>
        public event MethodSent OnSent;

        public delegate void MethodReceive();
        /// <summary>
        /// Событие: Данные приняты
        /// </summary>
        public event MethodReceive OnReceive;

        public delegate void MethodDestinationIPAdressChanged();
        /// <summary>
        /// Событие: Изменено свойство DestinationIPAdress
        /// </summary>
        public event MethodDestinationIPAdressChanged DestinationIPAdressChanged;

        public delegate void MethodDestinationPortChanged();
        /// <summary>
        /// Событие: Изменено свойство DestinationPort
        /// </summary>
        public event MethodDestinationPortChanged DestinationPortChanged;

        public delegate void MethodSourcesPortChanged();
        /// <summary>
        /// Событие: Изменено свойство SourcesPort
        /// </summary>
        public event MethodSourcesPortChanged SourcesPortChanged;

#endregion

#region // Свойства
        /// <summary>
        /// IP-адресс сервера назначения
        /// </summary>
        public IPAddress DestinationIPAdress
        {
            get
            {
                return DestIPAdress;
            }
            set
            {
                if (value != DestIPAdress)
                {
                    DestIPAdress = value;
                    DestinationIPAdressChanged = () => { };
                }
            }
        }

        /// <summary>
        /// Порт сервера назначения
        /// </summary>
        public int DestinationPort
        {
            get
            {
                return DestPort;
            }
            set
            {
                if (value != DestPort)
                {
                    DestPort = value;
                    DestinationPortChanged = () => { };
                }
            }
        }

        /// <summary>
        /// Порт сервера приёма (локального)
        /// </summary>
        public int SourcesPort
        {
            get
            {
                return SrcPort;
            }
            set
            {
                if (value != SrcPort)
                {
                    SrcPort = value;
                    SourcesPortChanged = () => { };
                }
            }
        }

        /// <summary>
        /// Запрос, отправленный серверу
        /// </summary>
        public string QueryString
        {
            get
            {
                return UDPQueryString;
            }
        }

        /// <summary>
        /// Ответ сервера
        /// </summary>
        public string AnswerString
        {
            get
            {
                return UDPAnswerString;
            }
        }

        /// <summary>
        /// Ответ сервера
        /// </summary>
        public byte[] AnswerArray
        {
            get
            {
                return UDPAnswerArray;
            }
        }
#endregion

#region // Методы

        bool stopReceive = false;
        Thread workReceive = null;
        UdpClient udp = null;

        public void StartReceive(int port)
        {
            if (port != SrcPort)
            {
                SrcPort = port;
                SourcesPortChanged = () => { };
            }
            StartReceive();
        }

        public void StartReceive()
        {
            stopReceive = false;
            workReceive = null;
            // Чтобы основной поток приложения не заблокировался,
            // для извлечения сообщений запускаем дополнительный поток.
            ThreadStart tstart = new ThreadStart(Receive);
            workReceive = new Thread(tstart);
            workReceive.Start();
        }

        // Безопасный останов дополнительного потока
        public void StopReceive()
        {
            // Останавливаем цикл приема сообщений
            stopReceive = true;
            if (udp != null) udp.Close();

            // Для правильного, последовательного завершения 
            // дополнительного потока подключаем его к основному потоку.
            if (workReceive != null) workReceive.Join();
        }

        public void SendHexString(string Data)
        {
            UdpClient udpSend = new UdpClient();
            try
            {
                UDPQueryString = Data;

                IPEndPoint ep = new IPEndPoint(DestIPAdress, DestPort);

                byte[] message = new byte[Data.Length / 2];//проверим что их чётное количество? :)

                for (int i = 0; i < Data.Length; i += 2)
                {
                    message[i / 2] = byte.Parse(Data.Substring(i, 2),
                        System.Globalization.NumberStyles.AllowHexSpecifier);
                    //или byte.TryParse для избежания эксепшинов
                }
                udpSend.Send(message, message.Length, ep);
                OnSent();
            }
            catch (Exception)
            {}
            finally
            {
                if (udpSend != null) udpSend.Close();
            }
        }

        // Функция запускаемая из дополнительного потока
        // для цикличного процесса извлечения сообщений
        private void Receive()
        {
            try
            {
                udp = new UdpClient(SrcPort);
                while (true)
                {

                    IPEndPoint remote = new IPEndPoint(IPAddress.Any, SrcPort);
                    byte[] message = udp.Receive(ref remote);
                    //-----------------------------------
                    string str1 = "";
                    for (int i = 0; i < message.Length; i++)
                    {
                        str1 += String.Format("{0:X}", message[i]);
                    }

                    UDPAnswerArray = message;
                    UDPAnswerString = str1;
                    OnReceive();
                    //-----------------------------------
                    if (stopReceive == true) break;
                }
            }
            catch (Exception)
            {}
            finally
            {
                if (udp != null) udp.Close();
            }
        }

#endregion

    }
}
