﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/mass/speed/set 接口的请求。</para>
    /// </summary>
    public class CgibinMessageMassSpeedSetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置群发速度级别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("speed")]
        [System.Text.Json.Serialization.JsonPropertyName("speed")]
        public int SpeedLevel { get; set; }
    }
}
