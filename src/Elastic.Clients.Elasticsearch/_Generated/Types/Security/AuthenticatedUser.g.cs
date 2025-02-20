// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Security
{
	public partial class AuthenticatedUser : User
	{
		[JsonInclude]
		[JsonPropertyName("authentication_provider")]
		public Elastic.Clients.Elasticsearch.Security.AuthenticationProvider? AuthenticationProvider { get; init; }

		[JsonInclude]
		[JsonPropertyName("authentication_realm")]
		public Elastic.Clients.Elasticsearch.Security.UserRealm AuthenticationRealm { get; init; }

		[JsonInclude]
		[JsonPropertyName("authentication_type")]
		public string AuthenticationType { get; init; }

		[JsonInclude]
		[JsonPropertyName("lookup_realm")]
		public Elastic.Clients.Elasticsearch.Security.UserRealm LookupRealm { get; init; }
	}
}