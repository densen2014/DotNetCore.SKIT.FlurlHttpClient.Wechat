﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinUserExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/create 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90195 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserCreateResponse> ExecuteCgibinUserCreateAsync(this WechatWorkClient client, Models.CgibinUserCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "user", "create")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90196 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserGetResponse> ExecuteCgibinUserGetAsync(this WechatWorkClient client, Models.CgibinUserGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "user", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.UserId);

            return await client.SendRequestAsync<Models.CgibinUserGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/update 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90197 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserUpdateResponse> ExecuteCgibinUserUpdateAsync(this WechatWorkClient client, Models.CgibinUserUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "user", "update")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/delete 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90198 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserDeleteResponse> ExecuteCgibinUserDeleteAsync(this WechatWorkClient client, Models.CgibinUserDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "user", "delete")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.UserId);

            return await client.SendRequestAsync<Models.CgibinUserDeleteResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/batchdelete 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90199 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserBatchDeleteResponse> ExecuteCgibinUserBatchDeleteAsync(this WechatWorkClient client, Models.CgibinUserBatchDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "user", "batchdelete")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserBatchDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/simplelist 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90200 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserSimpleListResponse> ExecuteCgibinUserSimpleListAsync(this WechatWorkClient client, Models.CgibinUserSimpleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "user", "simplelist")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("department_id", request.DepartmentId);

            if (request.RequireFetchChild.HasValue)
                flurlReq.SetQueryParam("fetch_child", request.RequireFetchChild.Value ? 1 : 0);

            return await client.SendRequestAsync<Models.CgibinUserSimpleListResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90201 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserListResponse> ExecuteCgibinUserListAsync(this WechatWorkClient client, Models.CgibinUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "user", "list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("department_id", request.DepartmentId);

            if (request.RequireFetchChild.HasValue)
                flurlReq.SetQueryParam("fetch_child", request.RequireFetchChild.Value ? 1 : 0);

            return await client.SendRequestAsync<Models.CgibinUserListResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/convert_to_openid 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90202 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserConvertToOpenIdResponse> ExecuteCgibinUserConvertToOpenIdAsync(this WechatWorkClient client, Models.CgibinUserConvertToOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "user", "convert_to_openid")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserConvertToOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/convert_to_userid 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90202 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserConvertToUserIdResponse> ExecuteCgibinUserConvertToUserIdAsync(this WechatWorkClient client, Models.CgibinUserConvertToUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "user", "convert_to_userid")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserConvertToUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/authsucc 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90203 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserAuthSuccessResponse> ExecuteCgibinUserAuthSuccessAsync(this WechatWorkClient client, Models.CgibinUserAuthSuccessRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "user", "authsucc")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.UserId);

            return await client.SendRequestAsync<Models.CgibinUserAuthSuccessResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/getuserinfo 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91023 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91437 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserGetUserInfoResponse> ExecuteCgibinUserGetUserInfoAsync(this WechatWorkClient client, Models.CgibinUserGetUserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "user", "getuserinfo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestAsync<Models.CgibinUserGetUserInfoResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/get_active_stat 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92714 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserGetActiveStatResponse> ExecuteCgibinUserGetActiveStatAsync(this WechatWorkClient client, Models.CgibinUserGetActiveStatRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "user", "get_active_stat")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserGetActiveStatResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
