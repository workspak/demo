using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace SocketService
{
    /// <summary>
    /// 基础Socket核心类
    /// </summary>
    public class SocketHelper
    {
        /// <summary>
        /// 端口号
        /// </summary>
        public int Port { get; set; } = 6000;
        /// <summary>
        /// 服务端地址
        /// </summary>
        public string Host { get; set; } = "127.0.0.1";

        /// <summary>
        /// 基础函数
        /// </summary>
        public SocketHelper() { }
        public SocketHelper(int port,string host)
        {
            this.Port = port;
            this.Host = host;
        }

        /// <summary>
        /// 启动基础Socket服务
        /// </summary>
        public void Start()
        {

        }
        void OnConnect()
        {

        }

        /// <summary>
        /// 停止服务
        /// </summary>
        public void Close()
        {

        }
    }
}
