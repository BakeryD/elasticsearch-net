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
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class SnowballAnalyzer : IAnalyzer
	{
		[JsonInclude]
		[JsonPropertyName("language")]
		public Elastic.Clients.Elasticsearch.Analysis.SnowballLanguage Language { get; set; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? Stopwords { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "snowball";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; set; }
	}

	public sealed partial class SnowballAnalyzerDescriptor : SerializableDescriptorBase<SnowballAnalyzerDescriptor>, IBuildableDescriptor<SnowballAnalyzer>
	{
		internal SnowballAnalyzerDescriptor(Action<SnowballAnalyzerDescriptor> configure) => configure.Invoke(this);
		public SnowballAnalyzerDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Analysis.SnowballLanguage LanguageValue { get; set; }

		private Elastic.Clients.Elasticsearch.Analysis.StopWords? StopwordsValue { get; set; }

		private string? VersionValue { get; set; }

		public SnowballAnalyzerDescriptor Language(Elastic.Clients.Elasticsearch.Analysis.SnowballLanguage language)
		{
			LanguageValue = language;
			return Self;
		}

		public SnowballAnalyzerDescriptor Stopwords(Elastic.Clients.Elasticsearch.Analysis.StopWords? stopwords)
		{
			StopwordsValue = stopwords;
			return Self;
		}

		public SnowballAnalyzerDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("language");
			JsonSerializer.Serialize(writer, LanguageValue, options);
			if (StopwordsValue is not null)
			{
				writer.WritePropertyName("stopwords");
				JsonSerializer.Serialize(writer, StopwordsValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("snowball");
			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		SnowballAnalyzer IBuildableDescriptor<SnowballAnalyzer>.Build() => new()
		{ Language = LanguageValue, Stopwords = StopwordsValue, Version = VersionValue };
	}
}