/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class SetGtmAccessModeRequest : RpcAcsRequest<SetGtmAccessModeResponse>
    {
        public SetGtmAccessModeRequest()
            : base("Alidns", "2015-01-09", "SetGtmAccessMode", "alidns", "openAPI")
        {
        }

		private string userClientIp;

		private string strategyId;

		private string lang;

		private string accessMode;

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string StrategyId
		{
			get
			{
				return strategyId;
			}
			set	
			{
				strategyId = value;
				DictionaryUtil.Add(QueryParameters, "StrategyId", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string AccessMode
		{
			get
			{
				return accessMode;
			}
			set	
			{
				accessMode = value;
				DictionaryUtil.Add(QueryParameters, "AccessMode", value);
			}
		}

        public override SetGtmAccessModeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetGtmAccessModeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}