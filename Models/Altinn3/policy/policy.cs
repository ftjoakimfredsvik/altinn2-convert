﻿//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.5.2.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

#nullable enable

namespace Altinn2Convert.Models.Altinn3.policy
{
    #pragma warning disable // Disable all warnings

    /// <summary>Policy for defining rules for who (subjects) can do actions on resources in an app.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Policy 
    {
        /// <summary>Required array containing one or more rules.</summary>
        [Newtonsoft.Json.JsonProperty("Rules", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.Generic.ICollection<Rule> Rules { get; set; } = new System.Collections.ObjectModel.Collection<Rule>();
    
    
    }
    
    /// <summary>Rule describing who (subjects) can do actions on resources in the app.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Rule 
    {
        /// <summary>The intended consequence of a satisfied rule (either "Permit" or "Deny").</summary>
        [Newtonsoft.Json.JsonProperty("Effect", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RuleEffect Effect { get; set; }= default!;
    
        /// <summary>Optional description of the rule.</summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Description { get; set; }= default!;
    
        /// <summary>Array containing one or more subjects.</summary>
        [Newtonsoft.Json.JsonProperty("Subjects", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<string> Subjects { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        /// <summary>Array containing one or more resources.</summary>
        [Newtonsoft.Json.JsonProperty("Resources", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<string> Resources { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        /// <summary>Array containing one or more actions that can be performed on the resources.</summary>
        [Newtonsoft.Json.JsonProperty("Actions", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Actions> Actions { get; set; } = new System.Collections.ObjectModel.Collection<Actions>();
    
    
    }
    
    /// <summary>JSON Schema describing a simplified access control policy format for Altinn applications.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Test 
    {
        [Newtonsoft.Json.JsonProperty("Policy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Policy? Policy { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum RuleEffect
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Permit")]
        Permit = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Deny")]
        Deny = 1,
    
    }
    
    /// <summary>An action that can be performed on the resources.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum Actions
    {
        [System.Runtime.Serialization.EnumMember(Value = @"instantiate")]
        Instantiate = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"read")]
        Read = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"write")]
        Write = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"confirm")]
        Confirm = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"complete")]
        Complete = 4,
    
    }
}