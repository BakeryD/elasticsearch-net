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
namespace Elastic.Clients.Elasticsearch.TransformManagement
{
	public partial class TransformStats
	{
		[JsonInclude]
		[JsonPropertyName("checkpointing")]
		public Elastic.Clients.Elasticsearch.TransformManagement.Checkpointing Checkpointing { get; init; }

		[JsonInclude]
		[JsonPropertyName("id")]
		public string Id { get; init; }

		[JsonInclude]
		[JsonPropertyName("node")]
		public Elastic.Clients.Elasticsearch.NodeAttributes? Node { get; init; }

		[JsonInclude]
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }

		[JsonInclude]
		[JsonPropertyName("state")]
		public string State { get; init; }

		[JsonInclude]
		[JsonPropertyName("stats")]
		public Elastic.Clients.Elasticsearch.TransformManagement.TransformIndexerStats Stats { get; init; }
	}
}