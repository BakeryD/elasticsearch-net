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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class MemStats
	{
		[JsonInclude]
		[JsonPropertyName("adjusted_total")]
		public Elastic.Clients.Elasticsearch.ByteSize? AdjustedTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("adjusted_total_in_bytes")]
		public int AdjustedTotalInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("ml")]
		public Elastic.Clients.Elasticsearch.Ml.MemMlStats Ml { get; init; }

		[JsonInclude]
		[JsonPropertyName("total")]
		public Elastic.Clients.Elasticsearch.ByteSize? Total { get; init; }

		[JsonInclude]
		[JsonPropertyName("total_in_bytes")]
		public int TotalInBytes { get; init; }
	}
}