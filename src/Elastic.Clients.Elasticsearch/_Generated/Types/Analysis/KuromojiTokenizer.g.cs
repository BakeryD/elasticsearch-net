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
	public partial class KuromojiTokenizer : TokenizerBase, ITokenizerDefinition
	{
		[JsonInclude]
		[JsonPropertyName("discard_compound_token")]
		public bool? DiscardCompoundToken { get; set; }

		[JsonInclude]
		[JsonPropertyName("discard_punctuation")]
		public bool? DiscardPunctuation { get; set; }

		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.Analysis.KuromojiTokenizationMode Mode { get; set; }

		[JsonInclude]
		[JsonPropertyName("nbest_cost")]
		public int? NbestCost { get; set; }

		[JsonInclude]
		[JsonPropertyName("nbest_examples")]
		public string? NbestExamples { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "kuromoji_tokenizer";
		[JsonInclude]
		[JsonPropertyName("user_dictionary")]
		public string? UserDictionary { get; set; }

		[JsonInclude]
		[JsonPropertyName("user_dictionary_rules")]
		public IEnumerable<string>? UserDictionaryRules { get; set; }
	}

	public sealed partial class KuromojiTokenizerDescriptor : SerializableDescriptorBase<KuromojiTokenizerDescriptor>, IBuildableDescriptor<KuromojiTokenizer>
	{
		internal KuromojiTokenizerDescriptor(Action<KuromojiTokenizerDescriptor> configure) => configure.Invoke(this);
		public KuromojiTokenizerDescriptor() : base()
		{
		}

		private bool? DiscardCompoundTokenValue { get; set; }

		private bool? DiscardPunctuationValue { get; set; }

		private Elastic.Clients.Elasticsearch.Analysis.KuromojiTokenizationMode ModeValue { get; set; }

		private int? NbestCostValue { get; set; }

		private string? NbestExamplesValue { get; set; }

		private string? UserDictionaryValue { get; set; }

		private IEnumerable<string>? UserDictionaryRulesValue { get; set; }

		private string? VersionValue { get; set; }

		public KuromojiTokenizerDescriptor DiscardCompoundToken(bool? discardCompoundToken = true)
		{
			DiscardCompoundTokenValue = discardCompoundToken;
			return Self;
		}

		public KuromojiTokenizerDescriptor DiscardPunctuation(bool? discardPunctuation = true)
		{
			DiscardPunctuationValue = discardPunctuation;
			return Self;
		}

		public KuromojiTokenizerDescriptor Mode(Elastic.Clients.Elasticsearch.Analysis.KuromojiTokenizationMode mode)
		{
			ModeValue = mode;
			return Self;
		}

		public KuromojiTokenizerDescriptor NbestCost(int? nbestCost)
		{
			NbestCostValue = nbestCost;
			return Self;
		}

		public KuromojiTokenizerDescriptor NbestExamples(string? nbestExamples)
		{
			NbestExamplesValue = nbestExamples;
			return Self;
		}

		public KuromojiTokenizerDescriptor UserDictionary(string? userDictionary)
		{
			UserDictionaryValue = userDictionary;
			return Self;
		}

		public KuromojiTokenizerDescriptor UserDictionaryRules(IEnumerable<string>? userDictionaryRules)
		{
			UserDictionaryRulesValue = userDictionaryRules;
			return Self;
		}

		public KuromojiTokenizerDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DiscardCompoundTokenValue.HasValue)
			{
				writer.WritePropertyName("discard_compound_token");
				writer.WriteBooleanValue(DiscardCompoundTokenValue.Value);
			}

			if (DiscardPunctuationValue.HasValue)
			{
				writer.WritePropertyName("discard_punctuation");
				writer.WriteBooleanValue(DiscardPunctuationValue.Value);
			}

			writer.WritePropertyName("mode");
			JsonSerializer.Serialize(writer, ModeValue, options);
			if (NbestCostValue.HasValue)
			{
				writer.WritePropertyName("nbest_cost");
				writer.WriteNumberValue(NbestCostValue.Value);
			}

			if (!string.IsNullOrEmpty(NbestExamplesValue))
			{
				writer.WritePropertyName("nbest_examples");
				writer.WriteStringValue(NbestExamplesValue);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("kuromoji_tokenizer");
			if (!string.IsNullOrEmpty(UserDictionaryValue))
			{
				writer.WritePropertyName("user_dictionary");
				writer.WriteStringValue(UserDictionaryValue);
			}

			if (UserDictionaryRulesValue is not null)
			{
				writer.WritePropertyName("user_dictionary_rules");
				JsonSerializer.Serialize(writer, UserDictionaryRulesValue, options);
			}

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		KuromojiTokenizer IBuildableDescriptor<KuromojiTokenizer>.Build() => new()
		{ DiscardCompoundToken = DiscardCompoundTokenValue, DiscardPunctuation = DiscardPunctuationValue, Mode = ModeValue, NbestCost = NbestCostValue, NbestExamples = NbestExamplesValue, UserDictionary = UserDictionaryValue, UserDictionaryRules = UserDictionaryRulesValue, Version = VersionValue };
	}
}