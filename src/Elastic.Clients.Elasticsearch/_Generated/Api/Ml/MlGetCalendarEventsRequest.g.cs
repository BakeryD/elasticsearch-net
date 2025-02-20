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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed class MlGetCalendarEventsRequestParameters : RequestParameters<MlGetCalendarEventsRequestParameters>
	{
		[JsonIgnore]
		public string? End { get => Q<string?>("end"); set => Q("end", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Id? JobId { get => Q<Elastic.Clients.Elasticsearch.Id?>("job_id"); set => Q("job_id", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public string? Start { get => Q<string?>("start"); set => Q("start", value); }
	}

	public partial class MlGetCalendarEventsRequest : PlainRequestBase<MlGetCalendarEventsRequestParameters>
	{
		public MlGetCalendarEventsRequest(Elastic.Clients.Elasticsearch.Id calendar_id) : base(r => r.Required("calendar_id", calendar_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningGetCalendarEvents;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public string? End { get => Q<string?>("end"); set => Q("end", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Id? JobId { get => Q<Elastic.Clients.Elasticsearch.Id?>("job_id"); set => Q("job_id", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public string? Start { get => Q<string?>("start"); set => Q("start", value); }
	}

	public sealed partial class MlGetCalendarEventsRequestDescriptor : RequestDescriptorBase<MlGetCalendarEventsRequestDescriptor, MlGetCalendarEventsRequestParameters>
	{
		internal MlGetCalendarEventsRequestDescriptor(Action<MlGetCalendarEventsRequestDescriptor> configure) => configure.Invoke(this);
		public MlGetCalendarEventsRequestDescriptor(Elastic.Clients.Elasticsearch.Id calendar_id) : base(r => r.Required("calendar_id", calendar_id))
		{
		}

		internal MlGetCalendarEventsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningGetCalendarEvents;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public MlGetCalendarEventsRequestDescriptor End(string? end) => Qs("end", end);
		public MlGetCalendarEventsRequestDescriptor From(int? from) => Qs("from", from);
		public MlGetCalendarEventsRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id? jobId) => Qs("job_id", jobId);
		public MlGetCalendarEventsRequestDescriptor Size(int? size) => Qs("size", size);
		public MlGetCalendarEventsRequestDescriptor Start(string? start) => Qs("start", start);
		public MlGetCalendarEventsRequestDescriptor CalendarId(Elastic.Clients.Elasticsearch.Id calendar_id)
		{
			RouteValues.Required("calendar_id", calendar_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}