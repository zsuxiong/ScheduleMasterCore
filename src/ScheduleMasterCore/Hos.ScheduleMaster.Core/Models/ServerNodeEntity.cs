﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hos.ScheduleMaster.Core.Models
{
    public class ServerNodeEntity : IEntity
    {
        /// <summary>
        /// 节点标识
        /// </summary>
        [Key]
        public string NodeName { get; set; }

        /// <summary>
        /// 访问协议，http/https
        /// </summary>
        public string AccessProtocol { get; set; }

        /// <summary>
        /// 节点主机(IP+端口)
        /// </summary>
        [Required]
        public string Host { get; set; }

        /// <summary>
        /// 访问秘钥，每次节点激活时会更新，用来验证访问权限
        /// </summary>
        public string AccessSecret { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 节点状态，1-运行，0-停机
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 权重
        /// </summary>
        public int Priority { get; set; }
    }
}
