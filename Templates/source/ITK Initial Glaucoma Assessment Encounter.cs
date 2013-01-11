namespace com.blackpear.openehr
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.oceanehr.com/templates", IsNullable=false)]
    public partial class ITK_Initial_Glaucoma_Assessment
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_AssessmentName name;
        
        /// <remarks/>
        public UID_BASED_ID uid;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("links")]
        public LINK[] links;
        
        /// <remarks/>
        public FEEDER_AUDIT feeder_audit;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_AssessmentLanguage language;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_AssessmentTerritory territory;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_AssessmentCategory category;
        
        /// <remarks/>
        public PARTY_PROXY composer;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_AssessmentContext context;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_1_prd__History _1_prd__History;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examination _2_prd__Glaucoma_examination;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string template_id;
        
        public ITK_Initial_Glaucoma_Assessment()
        {
            this.archetype_node_id = "openEHR-EHR-COMPOSITION.encounter.v1";
            this.type = "COMPOSITION";
            this.template_id = "ITK Initial Glaucoma Assessment Encounter";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_AssessmentName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_AssessmentName()
        {
            this.value = "ITK Initial Glaucoma Assessment";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class TERM_MAPPING
    {
        
        /// <remarks/>
        public string match;
        
        /// <remarks/>
        public DV_CODED_TEXT purpose;
        
        /// <remarks/>
        public CODE_PHRASE target;
        
        public TERM_MAPPING()
        {
            this.match = "?";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_CODED_TEXT : DV_TEXT
    {
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class CODE_PHRASE
    {
        
        /// <remarks/>
        public TERMINOLOGY_ID terminology_id;
        
        /// <remarks/>
        public string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class TERMINOLOGY_ID : OBJECT_ID
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UID_BASED_ID))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TERMINOLOGY_ID))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public abstract partial class OBJECT_ID
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class PARTICIPATION
    {
        
        /// <remarks/>
        public DV_TEXT function;
        
        /// <remarks/>
        public PARTY_PROXY performer;
        
        /// <remarks/>
        public DV_INTERVAL time;
        
        /// <remarks/>
        public DV_CODED_TEXT mode;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_CODED_TEXT))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_TEXT : DATA_VALUE
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        public DV_URI hyperlink;
        
        /// <remarks/>
        public string formatting;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE language;
        
        /// <remarks/>
        public CODE_PHRASE encoding;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_EHR_URI))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_URI : DATA_VALUE
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_BOOLEAN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_INTERVAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_ORDERED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_QUANTIFIED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_AMOUNT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DURATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_TEMPORAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DATE_TIME))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_ENCAPSULATED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_MULTIMEDIA))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_IDENTIFIER))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_URI))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_EHR_URI))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_TEXT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_CODED_TEXT))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public abstract partial class DATA_VALUE
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_BOOLEAN : DATA_VALUE
    {
        
        /// <remarks/>
        public bool value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_INTERVAL : DATA_VALUE
    {
        
        /// <remarks/>
        public DV_ORDERED lower;
        
        /// <remarks/>
        public DV_ORDERED upper;
        
        /// <remarks/>
        public bool lower_included;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lower_includedSpecified;
        
        /// <remarks/>
        public bool upper_included;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool upper_includedSpecified;
        
        /// <remarks/>
        public bool lower_unbounded;
        
        /// <remarks/>
        public bool upper_unbounded;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_QUANTIFIED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_AMOUNT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DURATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_TEMPORAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DATE_TIME))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public abstract partial class DV_ORDERED : DATA_VALUE
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class REFERENCE_RANGE
    {
        
        /// <remarks/>
        public DV_TEXT meaning;
        
        /// <remarks/>
        public DV_INTERVAL range;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_AMOUNT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DURATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_TEMPORAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DATE_TIME))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public abstract partial class DV_QUANTIFIED : DV_ORDERED
    {
        
        /// <remarks/>
        public string magnitude_status;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DURATION))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_AMOUNT : DV_QUANTIFIED
    {
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "-1")]
        public float accuracy;
        
        /// <remarks/>
        public bool accuracy_is_percent;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accuracy_is_percentSpecified;
        
        public DV_AMOUNT()
        {
            this.accuracy = ((float)(-1F));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_DURATION : DV_AMOUNT
    {
        
        /// <remarks/>
        public string value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DATE_TIME))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_TEMPORAL : DV_QUANTIFIED
    {
        
        /// <remarks/>
        public DV_DURATION accuracy;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_DATE_TIME : DV_TEMPORAL
    {
        
        /// <remarks/>
        public string value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_MULTIMEDIA))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public abstract partial class DV_ENCAPSULATED : DATA_VALUE
    {
        
        /// <remarks/>
        public CODE_PHRASE charset;
        
        /// <remarks/>
        public CODE_PHRASE language;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_MULTIMEDIA : DV_ENCAPSULATED
    {
        
        /// <remarks/>
        public string alternate_text;
        
        /// <remarks/>
        public DV_URI uri;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] data;
        
        /// <remarks/>
        public CODE_PHRASE media_type;
        
        /// <remarks/>
        public CODE_PHRASE compression_algorithm;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] integrity_check;
        
        /// <remarks/>
        public CODE_PHRASE integrity_check_algorithm;
        
        /// <remarks/>
        public int size;
        
        /// <remarks/>
        public DV_MULTIMEDIA thumbnail;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_IDENTIFIER : DATA_VALUE
    {
        
        /// <remarks/>
        public string issuer;
        
        /// <remarks/>
        public string assigner;
        
        /// <remarks/>
        public string id;
        
        /// <remarks/>
        public string type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class DV_EHR_URI : DV_URI
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PARTY_SELF))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PARTY_IDENTIFIED))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public abstract partial class PARTY_PROXY
    {
        
        /// <remarks/>
        public PARTY_REF external_ref;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class PARTY_REF : OBJECT_REF
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PARTY_REF))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class OBJECT_REF
    {
        
        /// <remarks/>
        public OBJECT_ID id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string @namespace;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class PARTY_SELF : PARTY_PROXY
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class PARTY_IDENTIFIED : PARTY_PROXY
    {
        
        /// <remarks/>
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("identifiers")]
        public DV_IDENTIFIER[] identifiers;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class FEEDER_AUDIT_DETAILS
    {
        
        /// <remarks/>
        public string system_id;
        
        /// <remarks/>
        public PARTY_IDENTIFIED location;
        
        /// <remarks/>
        public PARTY_IDENTIFIED provider;
        
        /// <remarks/>
        public PARTY_PROXY subject;
        
        /// <remarks/>
        public DV_DATE_TIME time;
        
        /// <remarks/>
        public string version_id;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class FEEDER_AUDIT
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("originating_system_item_ids")]
        public DV_IDENTIFIER[] originating_system_item_ids;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("feeder_system_item_ids")]
        public DV_IDENTIFIER[] feeder_system_item_ids;
        
        /// <remarks/>
        public DV_ENCAPSULATED original_content;
        
        /// <remarks/>
        public FEEDER_AUDIT_DETAILS originating_system_audit;
        
        /// <remarks/>
        public FEEDER_AUDIT_DETAILS feeder_system_audit;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public partial class LINK
    {
        
        /// <remarks/>
        public DV_TEXT meaning;
        
        /// <remarks/>
        public DV_TEXT type;
        
        /// <remarks/>
        public DV_EHR_URI target;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    public abstract partial class UID_BASED_ID : OBJECT_ID
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_AssessmentLanguage
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_AssessmentLanguageTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_AssessmentLanguage()
        {
            this.code_string = "en";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_AssessmentLanguageTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_AssessmentLanguageTerminology_id()
        {
            this.value = "ISO_639-1";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_AssessmentTerritory
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_AssessmentTerritoryTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_AssessmentTerritory()
        {
            this.code_string = "UK";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_AssessmentTerritoryTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_AssessmentTerritoryTerminology_id()
        {
            this.value = "ISO_3166-1";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_AssessmentCategory
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_AssessmentCategoryDefining_code defining_code;
        
        public ITK_Initial_Glaucoma_AssessmentCategory()
        {
            this.value = "event";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_AssessmentCategoryDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_AssessmentCategoryDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_AssessmentCategoryDefining_code()
        {
            this.code_string = "433";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_AssessmentCategoryDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_AssessmentCategoryDefining_codeTerminology_id()
        {
            this.value = "openehr";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_AssessmentContext
    {
        
        /// <remarks/>
        public DV_DATE_TIME start_time;
        
        /// <remarks/>
        public DV_DATE_TIME end_time;
        
        /// <remarks/>
        public string location;
        
        /// <remarks/>
        public DV_CODED_TEXT setting;
        
        /// <remarks/>
        public PARTY_IDENTIFIED health_care_facility;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("participations")]
        public PARTICIPATION[] participations;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_1_prd__History
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_1_prd__HistoryName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_1_prd__History()
        {
            this.archetype_node_id = "openEHR-EHR-SECTION.adhoc.v1";
            this.type = "SECTION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_1_prd__HistoryName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_1_prd__HistoryName()
        {
            this.value = "1. History";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examination
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Visual_Acuity")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_Acuity[] Visual_Acuity;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examination Pupillary_examination;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Intraocular_pressure_measurement")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurement[] Intraocular_pressure_measurement;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Visual_field_measurement")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurement[] Visual_field_measurement;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Clinical_Synopsis")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_Synopsis[] Clinical_Synopsis;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examination()
        {
            this.archetype_node_id = "openEHR-EHR-SECTION.adhoc.v1";
            this.type = "SECTION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationName()
        {
            this.value = "2. Glaucoma examination";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_Acuity
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityName name;
        
        /// <remarks/>
        public UID_BASED_ID uid;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("links")]
        public LINK[] links;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityLanguage language;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityEncoding encoding;
        
        /// <remarks/>
        public PARTY_SELF subject;
        
        /// <remarks/>
        public PARTY_IDENTIFIED provider;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_participations")]
        public PARTICIPATION[] other_participations;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityProtocol protocol;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityData data;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_Acuity()
        {
            this.archetype_node_id = "openEHR-EHR-OBSERVATION.visual_acuity.v1";
            this.type = "OBSERVATION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityName()
        {
            this.value = "Visual Acuity";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityLanguage
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityLanguageTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityLanguage()
        {
            this.code_string = "en";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityLanguageTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityLanguageTerminology_id()
        {
            this.value = "ISO_639-1";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityEncoding
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityEncodingTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityEncoding()
        {
            this.code_string = "UTF-8";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityEncodingTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityEncodingTerminology_id()
        {
            this.value = "IANA_character-sets";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityProtocol
    {
        
        /// <remarks/>
        public System.Xml.XmlElement Measurement_Device_Details;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityProtocol()
        {
            this.archetype_node_id = "at0020";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityData
    {
        
        /// <remarks/>
        public DV_DATE_TIME origin;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_ Visual_acuity_unaided_;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correction Visual_acuity_with_correction;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinhole Visual_acuity_with_pinhole;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityData()
        {
            this.archetype_node_id = "at0001";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_Name name;
        
        /// <remarks/>
        public DV_DATE_TIME time;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_Data data;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_State state;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_()
        {
            this.archetype_node_id = "at0002";
            this.type = "POINT_EVENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_Name
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_Name()
        {
            this.value = "Visual acuity unaided ";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_Data
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eye Left_eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eye Right_eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataAdditional_Comment Additional_Comment;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_Data()
        {
            this.archetype_node_id = "at0003";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEye Eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_Result Visual_Acuity_Result;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eye()
        {
            this.archetype_node_id = "at0053";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeName()
        {
            this.value = "Left eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEye()
        {
            this.archetype_node_id = "at0007";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeName()
        {
            this.value = "Eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeValueDefining_code()
        {
            this.code_string = "at0012";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeEyeValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_Result Absent_Result;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultMetric_Snellen Metric_Snellen;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLogMar logMar;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLow_Vision_Score Low_Vision_Score;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_Result()
        {
            this.archetype_node_id = "at0028";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultName()
        {
            this.value = "Visual Acuity Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coded_text_value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value))]
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("text_value", typeof(DV_TEXT))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultValueType valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_Result()
        {
            this.archetype_node_id = "at0055";
            this.type = "ELEMENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultName()
        {
            this.value = "Absent Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0064,
        
        /// <remarks/>
        at0065,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultAbsent_ResultValueType
    {
        
        /// <remarks/>
        DV_CODED_TEXT,
        
        /// <remarks/>
        DV_TEXT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultMetric_Snellen
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultMetric_SnellenName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultMetric_SnellenValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultMetric_Snellen()
        {
            this.archetype_node_id = "at0056";
            this.type = "ELEMENT";
            this.valueType = "DV_PROPORTION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultMetric_SnellenName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultMetric_SnellenName()
        {
            this.value = "Metric Snellen";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultMetric_SnellenValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public float numerator;
        
        /// <remarks/>
        public float denominator;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultMetric_SnellenValueType type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultMetric_SnellenValueType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLogMar
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLogMarName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLogMarValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLogMar()
        {
            this.archetype_node_id = "at0046";
            this.type = "ELEMENT";
            this.valueType = "DV_QUANTITY";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLogMarName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLogMarName()
        {
            this.value = "logMar";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLogMarValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public double magnitude;
        
        /// <remarks/>
        public int precision;
        
        /// <remarks/>
        public string units;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLogMarValue()
        {
            this.units = " ";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLow_Vision_Score
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLow_Vision_Score()
        {
            this.archetype_node_id = "at0015";
            this.type = "ELEMENT";
            this.valueType = "DV_ORDINAL";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreName()
        {
            this.value = "Low Vision Score";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public int value;
        
        /// <remarks/>
        public DV_CODED_TEXT symbol;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEye Eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_Result Visual_Acuity_Result;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eye()
        {
            this.archetype_node_id = "at0053";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeName()
        {
            this.value = "Right eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEye()
        {
            this.archetype_node_id = "at0007";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeName()
        {
            this.value = "Eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeValueDefining_code()
        {
            this.code_string = "at0013";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeEyeValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_Result Absent_Result;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultMetric_Snellen Metric_Snellen;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLogMar logMar;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLow_Vision_Score Low_Vision_Score;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_Result()
        {
            this.archetype_node_id = "at0028";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultName()
        {
            this.value = "Visual Acuity Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coded_text_value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value))]
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("text_value", typeof(DV_TEXT))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultValueType valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_Result()
        {
            this.archetype_node_id = "at0055";
            this.type = "ELEMENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultName()
        {
            this.value = "Absent Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0064,
        
        /// <remarks/>
        at0065,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultAbsent_ResultValueType
    {
        
        /// <remarks/>
        DV_CODED_TEXT,
        
        /// <remarks/>
        DV_TEXT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultMetric_Snellen
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultMetric_SnellenName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultMetric_SnellenValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultMetric_Snellen()
        {
            this.archetype_node_id = "at0056";
            this.type = "ELEMENT";
            this.valueType = "DV_PROPORTION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultMetric_SnellenName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultMetric_SnellenName()
        {
            this.value = "Metric Snellen";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultMetric_SnellenValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public float numerator;
        
        /// <remarks/>
        public float denominator;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultMetric_SnellenValueType type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultMetric_SnellenValueType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLogMar
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLogMarName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLogMarValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLogMar()
        {
            this.archetype_node_id = "at0046";
            this.type = "ELEMENT";
            this.valueType = "DV_QUANTITY";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLogMarName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLogMarName()
        {
            this.value = "logMar";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLogMarValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public double magnitude;
        
        /// <remarks/>
        public int precision;
        
        /// <remarks/>
        public string units;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLogMarValue()
        {
            this.units = " ";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLow_Vision_Score
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLow_Vision_Score()
        {
            this.archetype_node_id = "at0015";
            this.type = "ELEMENT";
            this.valueType = "DV_ORDINAL";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreName()
        {
            this.value = "Low Vision Score";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public int value;
        
        /// <remarks/>
        public DV_CODED_TEXT symbol;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataAdditional_Comment
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataAdditional_CommentName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataAdditional_Comment()
        {
            this.archetype_node_id = "at0040";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataAdditional_CommentName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_DataAdditional_CommentName()
        {
            this.value = "Additional Comment";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_State
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Refractive_Correction_Applied")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_Applied[] Refractive_Correction_Applied;
        
        /// <remarks/>
        public System.Xml.XmlElement Refraction_details;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_State()
        {
            this.archetype_node_id = "at0041";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_Applied
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_Applied()
        {
            this.archetype_node_id = "at0042";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedName()
        {
            this.value = "Refractive Correction Applied";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedValueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_unaided_StateRefractive_Correction_AppliedValueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0070,
        
        /// <remarks/>
        at0123,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correction
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionName name;
        
        /// <remarks/>
        public DV_DATE_TIME time;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionData data;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionState state;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correction()
        {
            this.archetype_node_id = "at0002";
            this.type = "POINT_EVENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionName()
        {
            this.value = "Visual acuity with correction";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionData
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eye Left_eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eye Right_eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataAdditional_Comment Additional_Comment;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionData()
        {
            this.archetype_node_id = "at0003";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEye Eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_Result Visual_Acuity_Result;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eye()
        {
            this.archetype_node_id = "at0053";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeName()
        {
            this.value = "Left eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEye()
        {
            this.archetype_node_id = "at0007";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeName()
        {
            this.value = "Eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeValueDefining_code()
        {
            this.code_string = "at0012";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeEyeValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_Result Absent_Result;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultMetric_Snellen Metric_Snellen;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLogMar logMar;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLow_Vision_Score Low_Vision_Score;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_Result()
        {
            this.archetype_node_id = "at0028";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultName()
        {
            this.value = "Visual Acuity Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coded_text_value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value))]
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("text_value", typeof(DV_TEXT))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultValueType valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_Result()
        {
            this.archetype_node_id = "at0055";
            this.type = "ELEMENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultName()
        {
            this.value = "Absent Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0064,
        
        /// <remarks/>
        at0065,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultAbsent_ResultValueType
    {
        
        /// <remarks/>
        DV_CODED_TEXT,
        
        /// <remarks/>
        DV_TEXT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultMetric_Snellen
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultMetric_SnellenName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultMetric_SnellenValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultMetric_Snellen()
        {
            this.archetype_node_id = "at0056";
            this.type = "ELEMENT";
            this.valueType = "DV_PROPORTION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultMetric_SnellenName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultMetric_SnellenName()
        {
            this.value = "Metric Snellen";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultMetric_SnellenValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public float numerator;
        
        /// <remarks/>
        public float denominator;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultMetric_SnellenValueType type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultMetric_SnellenValueType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLogMar
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLogMarName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLogMarValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLogMar()
        {
            this.archetype_node_id = "at0046";
            this.type = "ELEMENT";
            this.valueType = "DV_QUANTITY";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLogMarName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLogMarName()
        {
            this.value = "logMar";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLogMarValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public double magnitude;
        
        /// <remarks/>
        public int precision;
        
        /// <remarks/>
        public string units;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLogMarValue()
        {
            this.units = " ";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLow_Vision_Score
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLow_Vision_Score()
        {
            this.archetype_node_id = "at0015";
            this.type = "ELEMENT";
            this.valueType = "DV_ORDINAL";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreName()
        {
            this.value = "Low Vision Score";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public int value;
        
        /// <remarks/>
        public DV_CODED_TEXT symbol;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEye Eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_Result Visual_Acuity_Result;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eye()
        {
            this.archetype_node_id = "at0053";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeName()
        {
            this.value = "Right eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEye()
        {
            this.archetype_node_id = "at0007";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeName()
        {
            this.value = "Eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeValueDefining_code()
        {
            this.code_string = "at0013";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeEyeValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_Result Absent_Result;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultMetric_Snellen Metric_Snellen;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLogMar logMar;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLow_Vision_Score Low_Vision_Score;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_Result()
        {
            this.archetype_node_id = "at0028";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultName()
        {
            this.value = "Visual Acuity Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coded_text_value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value))]
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("text_value", typeof(DV_TEXT))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultValueType valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_Result()
        {
            this.archetype_node_id = "at0055";
            this.type = "ELEMENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultName()
        {
            this.value = "Absent Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0064,
        
        /// <remarks/>
        at0065,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultAbsent_ResultValueType
    {
        
        /// <remarks/>
        DV_CODED_TEXT,
        
        /// <remarks/>
        DV_TEXT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultMetric_Snellen
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultMetric_SnellenName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultMetric_SnellenValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultMetric_Snellen()
        {
            this.archetype_node_id = "at0056";
            this.type = "ELEMENT";
            this.valueType = "DV_PROPORTION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultMetric_SnellenName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultMetric_SnellenName()
        {
            this.value = "Metric Snellen";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultMetric_SnellenValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public float numerator;
        
        /// <remarks/>
        public float denominator;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultMetric_SnellenValueType type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultMetric_SnellenValueType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLogMar
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLogMarName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLogMarValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLogMar()
        {
            this.archetype_node_id = "at0046";
            this.type = "ELEMENT";
            this.valueType = "DV_QUANTITY";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLogMarName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLogMarName()
        {
            this.value = "logMar";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLogMarValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public double magnitude;
        
        /// <remarks/>
        public int precision;
        
        /// <remarks/>
        public string units;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLogMarValue()
        {
            this.units = " ";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLow_Vision_Score
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLow_Vision_Score()
        {
            this.archetype_node_id = "at0015";
            this.type = "ELEMENT";
            this.valueType = "DV_ORDINAL";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreName()
        {
            this.value = "Low Vision Score";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public int value;
        
        /// <remarks/>
        public DV_CODED_TEXT symbol;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataAdditional_Comment
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataAdditional_CommentName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataAdditional_Comment()
        {
            this.archetype_node_id = "at0040";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataAdditional_CommentName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionDataAdditional_CommentName()
        {
            this.value = "Additional Comment";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionState
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateConfounding_Factors Confounding_Factors;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Refractive_Correction_Applied")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_Applied[] Refractive_Correction_Applied;
        
        /// <remarks/>
        public System.Xml.XmlElement Refraction_details;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionState()
        {
            this.archetype_node_id = "at0041";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateConfounding_Factors
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateConfounding_FactorsName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateConfounding_Factors()
        {
            this.archetype_node_id = "at0112";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateConfounding_FactorsName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateConfounding_FactorsName()
        {
            this.value = "Confounding Factors";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_Applied
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_Applied()
        {
            this.archetype_node_id = "at0042";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedName()
        {
            this.value = "Refractive Correction Applied";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedValueDefining_code()
        {
            this.code_string = "at0123";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_correctionStateRefractive_Correction_AppliedValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinhole
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeName name;
        
        /// <remarks/>
        public DV_DATE_TIME time;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeData data;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeState state;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinhole()
        {
            this.archetype_node_id = "at0002";
            this.type = "POINT_EVENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeName()
        {
            this.value = "Visual acuity with pinhole";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeData
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eye Left_eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eye Right_eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataAdditional_Comment Additional_Comment;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeData()
        {
            this.archetype_node_id = "at0003";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEye Eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_Result Visual_Acuity_Result;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eye()
        {
            this.archetype_node_id = "at0053";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeName()
        {
            this.value = "Left eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEye()
        {
            this.archetype_node_id = "at0007";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeName()
        {
            this.value = "Eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeValueDefining_code()
        {
            this.code_string = "at0012";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeEyeValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_Result Absent_Result;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultMetric_Snellen Metric_Snellen;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLogMar logMar;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLow_Vision_Score Low_Vision_Score;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_Result()
        {
            this.archetype_node_id = "at0028";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultName()
        {
            this.value = "Visual Acuity Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coded_text_value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value))]
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("text_value", typeof(DV_TEXT))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultValueType valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_Result()
        {
            this.archetype_node_id = "at0055";
            this.type = "ELEMENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultName()
        {
            this.value = "Absent Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0064,
        
        /// <remarks/>
        at0065,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultAbsent_ResultValueType
    {
        
        /// <remarks/>
        DV_CODED_TEXT,
        
        /// <remarks/>
        DV_TEXT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultMetric_Snellen
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultMetric_SnellenName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultMetric_SnellenValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultMetric_Snellen()
        {
            this.archetype_node_id = "at0056";
            this.type = "ELEMENT";
            this.valueType = "DV_PROPORTION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultMetric_SnellenName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultMetric_SnellenName()
        {
            this.value = "Metric Snellen";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultMetric_SnellenValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public float numerator;
        
        /// <remarks/>
        public float denominator;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultMetric_SnellenValueType type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultMetric_SnellenValueType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLogMar
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLogMarName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLogMarValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLogMar()
        {
            this.archetype_node_id = "at0046";
            this.type = "ELEMENT";
            this.valueType = "DV_QUANTITY";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLogMarName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLogMarName()
        {
            this.value = "logMar";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLogMarValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public double magnitude;
        
        /// <remarks/>
        public int precision;
        
        /// <remarks/>
        public string units;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLogMarValue()
        {
            this.units = " ";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLow_Vision_Score
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLow_Vision_Score()
        {
            this.archetype_node_id = "at0015";
            this.type = "ELEMENT";
            this.valueType = "DV_ORDINAL";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreName()
        {
            this.value = "Low Vision Score";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataLeft_eyeVisual_Acuity_ResultLow_Vision_ScoreValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public int value;
        
        /// <remarks/>
        public DV_CODED_TEXT symbol;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEye Eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_Result Visual_Acuity_Result;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eye()
        {
            this.archetype_node_id = "at0053";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeName()
        {
            this.value = "Right eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEye()
        {
            this.archetype_node_id = "at0007";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeName()
        {
            this.value = "Eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeValueDefining_code()
        {
            this.code_string = "at0013";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeEyeValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_Result Absent_Result;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultMetric_Snellen Metric_Snellen;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLogMar logMar;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLow_Vision_Score Low_Vision_Score;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_Result()
        {
            this.archetype_node_id = "at0028";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultName()
        {
            this.value = "Visual Acuity Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_Result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coded_text_value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value))]
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("text_value", typeof(DV_TEXT))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultValueType valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_Result()
        {
            this.archetype_node_id = "at0055";
            this.type = "ELEMENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultName()
        {
            this.value = "Absent Result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_value
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultCoded_text_valueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0064,
        
        /// <remarks/>
        at0065,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultAbsent_ResultValueType
    {
        
        /// <remarks/>
        DV_CODED_TEXT,
        
        /// <remarks/>
        DV_TEXT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultMetric_Snellen
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultMetric_SnellenName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultMetric_SnellenValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultMetric_Snellen()
        {
            this.archetype_node_id = "at0056";
            this.type = "ELEMENT";
            this.valueType = "DV_PROPORTION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultMetric_SnellenName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultMetric_SnellenName()
        {
            this.value = "Metric Snellen";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultMetric_SnellenValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public float numerator;
        
        /// <remarks/>
        public float denominator;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultMetric_SnellenValueType type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultMetric_SnellenValueType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLogMar
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLogMarName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLogMarValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLogMar()
        {
            this.archetype_node_id = "at0046";
            this.type = "ELEMENT";
            this.valueType = "DV_QUANTITY";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLogMarName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLogMarName()
        {
            this.value = "logMar";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLogMarValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public double magnitude;
        
        /// <remarks/>
        public int precision;
        
        /// <remarks/>
        public string units;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLogMarValue()
        {
            this.units = " ";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLow_Vision_Score
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLow_Vision_Score()
        {
            this.archetype_node_id = "at0015";
            this.type = "ELEMENT";
            this.valueType = "DV_ORDINAL";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreName()
        {
            this.value = "Low Vision Score";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataRight_eyeVisual_Acuity_ResultLow_Vision_ScoreValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public int value;
        
        /// <remarks/>
        public DV_CODED_TEXT symbol;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataAdditional_Comment
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataAdditional_CommentName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataAdditional_Comment()
        {
            this.archetype_node_id = "at0040";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataAdditional_CommentName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeDataAdditional_CommentName()
        {
            this.value = "Additional Comment";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeState
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Refractive_Correction_Applied")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_Applied[] Refractive_Correction_Applied;
        
        /// <remarks/>
        public System.Xml.XmlElement Refraction_details;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeState()
        {
            this.archetype_node_id = "at0041";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_Applied
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_Applied()
        {
            this.archetype_node_id = "at0042";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedName()
        {
            this.value = "Refractive Correction Applied";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedValueDefining_code()
        {
            this.code_string = "at0073";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_AcuityDataVisual_acuity_with_pinholeStateRefractive_Correction_AppliedValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examination
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationName name;
        
        /// <remarks/>
        public UID_BASED_ID uid;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("links")]
        public LINK[] links;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationLanguage language;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationEncoding encoding;
        
        /// <remarks/>
        public PARTY_SELF subject;
        
        /// <remarks/>
        public PARTY_IDENTIFIED provider;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_participations")]
        public PARTICIPATION[] other_participations;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationData data;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examination()
        {
            this.archetype_node_id = "openEHR-EHR-OBSERVATION.exam.v1";
            this.type = "OBSERVATION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationName()
        {
            this.value = "Pupillary examination";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationLanguage
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationLanguageTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationLanguage()
        {
            this.code_string = "en";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationLanguageTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationLanguageTerminology_id()
        {
            this.value = "ISO_639-1";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationEncoding
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationEncodingTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationEncoding()
        {
            this.code_string = "UTF-8";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationEncodingTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationEncodingTerminology_id()
        {
            this.value = "IANA_character-sets";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationData
    {
        
        /// <remarks/>
        public DV_DATE_TIME origin;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Any_event_as_Interval_Event", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_Event))]
        [System.Xml.Serialization.XmlElementAttribute("Any_event_as_Point_Event", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_Event))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationData()
        {
            this.archetype_node_id = "at0001";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_Event
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventName name;
        
        /// <remarks/>
        public DV_DATE_TIME time;
        
        /// <remarks/>
        public DV_DURATION width;
        
        /// <remarks/>
        public DV_CODED_TEXT math_function;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventData data;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_Event()
        {
            this.archetype_node_id = "at0002";
            this.type = "INTERVAL_EVENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventName()
        {
            this.value = "Any event";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventData
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupils Pupils;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventData()
        {
            this.archetype_node_id = "at0003";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupils
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindings Findings;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupils()
        {
            this.archetype_node_id = "openEHR-EHR-CLUSTER.pupils.v1";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsName()
        {
            this.value = "Pupils";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindings
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSide Side;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetails Details;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindings()
        {
            this.archetype_node_id = "at0014";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsName()
        {
            this.value = "Findings";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSide
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSide()
        {
            this.archetype_node_id = "at0015";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideName()
        {
            this.value = "Side";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideValueDefining_code()
        {
            this.code_string = "at0016";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsSideValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetails
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetailsName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetailsPupillary_accommodation_reflex Pupillary_accommodation_reflex;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetails()
        {
            this.archetype_node_id = "at0001";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetailsName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetailsName()
        {
            this.value = "Details";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetailsPupillary_accommodation_reflex
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetailsPupillary_accommodation_reflexName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_BOOLEAN))]
        public DATA_VALUE Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetailsPupillary_accommodation_reflex()
        {
            this.archetype_node_id = "at0006";
            this.type = "ELEMENT";
            this.valueType = "DV_BOOLEAN";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetailsPupillary_accommodation_reflexName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Interval_EventDataPupilsFindingsDetailsPupillary_accommodation_reflexName()
        {
            this.value = "Pupillary accommodation reflex";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_Event
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventName name;
        
        /// <remarks/>
        public DV_DATE_TIME time;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventData data;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_Event()
        {
            this.archetype_node_id = "at0002";
            this.type = "POINT_EVENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventName()
        {
            this.value = "Any event";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventData
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupils Pupils;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventData()
        {
            this.archetype_node_id = "at0003";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupils
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindings Findings;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupils()
        {
            this.archetype_node_id = "openEHR-EHR-CLUSTER.pupils.v1";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsName()
        {
            this.value = "Pupils";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindings
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSide Side;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetails Details;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindings()
        {
            this.archetype_node_id = "at0014";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsName()
        {
            this.value = "Findings";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSide
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSide()
        {
            this.archetype_node_id = "at0015";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideName()
        {
            this.value = "Side";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideValueDefining_code()
        {
            this.code_string = "at0016";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsSideValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetails
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetailsName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetailsPupillary_accommodation_reflex Pupillary_accommodation_reflex;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetails()
        {
            this.archetype_node_id = "at0001";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetailsName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetailsName()
        {
            this.value = "Details";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetailsPupillary_accommodation_reflex
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetailsPupillary_accommodation_reflexName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_BOOLEAN))]
        public DATA_VALUE Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetailsPupillary_accommodation_reflex()
        {
            this.archetype_node_id = "at0006";
            this.type = "ELEMENT";
            this.valueType = "DV_BOOLEAN";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetailsPupillary_accommodation_reflexName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationPupillary_examinationDataAny_event_as_Point_EventDataPupilsFindingsDetailsPupillary_accommodation_reflexName()
        {
            this.value = "Pupillary accommodation reflex";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurement
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementName name;
        
        /// <remarks/>
        public UID_BASED_ID uid;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("links")]
        public LINK[] links;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementLanguage language;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementEncoding encoding;
        
        /// <remarks/>
        public PARTY_SELF subject;
        
        /// <remarks/>
        public PARTY_IDENTIFIED provider;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_participations")]
        public PARTICIPATION[] other_participations;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocol protocol;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementData data;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurement()
        {
            this.archetype_node_id = "openEHR-EHR-OBSERVATION.intraocular_pressure_measurement.v1";
            this.type = "OBSERVATION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementName()
        {
            this.value = "Intraocular pressure measurement";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementLanguage
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementLanguageTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementLanguage()
        {
            this.code_string = "en";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementLanguageTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementLanguageTerminology_id()
        {
            this.value = "ISO_639-1";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementEncoding
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementEncodingTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementEncoding()
        {
            this.code_string = "UTF-8";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementEncodingTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementEncodingTerminology_id()
        {
            this.value = "IANA_character-sets";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocol
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_method Toniometry_method;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Device_details")]
        public System.Xml.XmlElement[] Device_details;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocol()
        {
            this.archetype_node_id = "at0006";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_method
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coded_text_value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodCoded_text_value))]
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("text_value", typeof(DV_TEXT))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodValueType valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_method()
        {
            this.archetype_node_id = "at0046";
            this.type = "ELEMENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodName()
        {
            this.value = "Toniometry method";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodCoded_text_value
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodCoded_text_valueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodCoded_text_valueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodCoded_text_valueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodCoded_text_valueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodCoded_text_valueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodCoded_text_valueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodCoded_text_valueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0047,
        
        /// <remarks/>
        at0048,
        
        /// <remarks/>
        at0049,
        
        /// <remarks/>
        at0050,
        
        /// <remarks/>
        at0051,
        
        /// <remarks/>
        at0052,
        
        /// <remarks/>
        at0053,
        
        /// <remarks/>
        at0066,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementProtocolToniometry_methodValueType
    {
        
        /// <remarks/>
        DV_CODED_TEXT,
        
        /// <remarks/>
        DV_TEXT,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementData
    {
        
        /// <remarks/>
        public DV_DATE_TIME origin;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_event Any_event;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementData()
        {
            this.archetype_node_id = "at0001";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_event
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventName name;
        
        /// <remarks/>
        public DV_DATE_TIME time;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventData data;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventState state;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_event()
        {
            this.archetype_node_id = "at0002";
            this.type = "POINT_EVENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventName()
        {
            this.value = "Any event";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventData
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eye Left_eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eye Right_eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataAdditional_Comment Additional_Comment;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventData()
        {
            this.archetype_node_id = "at0003";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEye Eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeIntraocular_Pressure Intraocular_Pressure;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeApplanation_Time Applanation_Time;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eye()
        {
            this.archetype_node_id = "at0054";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeName()
        {
            this.value = "Left eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEye()
        {
            this.archetype_node_id = "at0057";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeName()
        {
            this.value = "Eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeValueDefining_code()
        {
            this.code_string = "at0058";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeEyeValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeIntraocular_Pressure
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeIntraocular_PressureName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeIntraocular_PressureValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeIntraocular_Pressure()
        {
            this.archetype_node_id = "at0042";
            this.type = "ELEMENT";
            this.valueType = "DV_QUANTITY";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeIntraocular_PressureName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeIntraocular_PressureName()
        {
            this.value = "Intraocular Pressure";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeIntraocular_PressureValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public double magnitude;
        
        /// <remarks/>
        public int precision;
        
        /// <remarks/>
        public string units;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeIntraocular_PressureValue()
        {
            this.units = "mm[Hg]";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeApplanation_Time
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeApplanation_TimeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeApplanation_TimeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeApplanation_Time()
        {
            this.archetype_node_id = "at0065";
            this.type = "ELEMENT";
            this.valueType = "DV_QUANTITY";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeApplanation_TimeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeApplanation_TimeName()
        {
            this.value = "Applanation Time";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeApplanation_TimeValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public double magnitude;
        
        /// <remarks/>
        public int precision;
        
        /// <remarks/>
        public string units;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataLeft_eyeApplanation_TimeValue()
        {
            this.units = "millisec";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEye Eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeIntraocular_Pressure Intraocular_Pressure;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeApplanation_Time Applanation_Time;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eye()
        {
            this.archetype_node_id = "at0054";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeName()
        {
            this.value = "Right eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEye()
        {
            this.archetype_node_id = "at0057";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeName()
        {
            this.value = "Eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeValueDefining_code()
        {
            this.code_string = "at0059";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeEyeValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeIntraocular_Pressure
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeIntraocular_PressureName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeIntraocular_PressureValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeIntraocular_Pressure()
        {
            this.archetype_node_id = "at0042";
            this.type = "ELEMENT";
            this.valueType = "DV_QUANTITY";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeIntraocular_PressureName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeIntraocular_PressureName()
        {
            this.value = "Intraocular Pressure";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeIntraocular_PressureValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public double magnitude;
        
        /// <remarks/>
        public int precision;
        
        /// <remarks/>
        public string units;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeIntraocular_PressureValue()
        {
            this.units = "mm[Hg]";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeApplanation_Time
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeApplanation_TimeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeApplanation_TimeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeApplanation_Time()
        {
            this.archetype_node_id = "at0065";
            this.type = "ELEMENT";
            this.valueType = "DV_QUANTITY";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeApplanation_TimeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeApplanation_TimeName()
        {
            this.value = "Applanation Time";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeApplanation_TimeValue
    {
        
        /// <remarks/>
        public DV_INTERVAL normal_range;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_reference_ranges")]
        public REFERENCE_RANGE[] other_reference_ranges;
        
        /// <remarks/>
        public CODE_PHRASE normal_status;
        
        /// <remarks/>
        public string magnitude_status;
        
        /// <remarks/>
        public double magnitude;
        
        /// <remarks/>
        public int precision;
        
        /// <remarks/>
        public string units;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataRight_eyeApplanation_TimeValue()
        {
            this.units = "millisec";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataAdditional_Comment
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataAdditional_CommentName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataAdditional_Comment()
        {
            this.archetype_node_id = "at0063";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataAdditional_CommentName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventDataAdditional_CommentName()
        {
            this.value = "Additional Comment";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventState
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationIntraocular_pressure_measurementDataAny_eventState()
        {
            this.archetype_node_id = "at0007";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurement
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementName name;
        
        /// <remarks/>
        public UID_BASED_ID uid;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("links")]
        public LINK[] links;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementLanguage language;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementEncoding encoding;
        
        /// <remarks/>
        public PARTY_SELF subject;
        
        /// <remarks/>
        public PARTY_IDENTIFIED provider;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_participations")]
        public PARTICIPATION[] other_participations;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocol protocol;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementData data;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurement()
        {
            this.archetype_node_id = "openEHR-EHR-OBSERVATION.visual_field_measurement.v1";
            this.type = "OBSERVATION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementName()
        {
            this.value = "Visual field measurement";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementLanguage
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementLanguageTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementLanguage()
        {
            this.code_string = "en";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementLanguageTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementLanguageTerminology_id()
        {
            this.value = "ISO_639-1";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementEncoding
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementEncodingTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementEncoding()
        {
            this.code_string = "UTF-8";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementEncodingTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementEncodingTerminology_id()
        {
            this.value = "IANA_character-sets";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocol
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_method Perimetry_method;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocol()
        {
            this.archetype_node_id = "at0010";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_method
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_method()
        {
            this.archetype_node_id = "at0011";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodName()
        {
            this.value = "Perimetry method";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodValueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementProtocolPerimetry_methodValueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0012,
        
        /// <remarks/>
        at0013,
        
        /// <remarks/>
        at0014,
        
        /// <remarks/>
        at0015,
        
        /// <remarks/>
        at0016,
        
        /// <remarks/>
        at0017,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementData
    {
        
        /// <remarks/>
        public DV_DATE_TIME origin;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Any_event_as_Interval_Event", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_Event))]
        [System.Xml.Serialization.XmlElementAttribute("Any_event_as_Point_Event", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_Event))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementData()
        {
            this.archetype_node_id = "at0001";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_Event
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventName name;
        
        /// <remarks/>
        public DV_DATE_TIME time;
        
        /// <remarks/>
        public DV_DURATION width;
        
        /// <remarks/>
        public DV_CODED_TEXT math_function;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventData data;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_Event()
        {
            this.archetype_node_id = "at0002";
            this.type = "INTERVAL_EVENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventName()
        {
            this.value = "Any event";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventData
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataClinical_description Clinical_description;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Test_result")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_result[] Test_result;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventData()
        {
            this.archetype_node_id = "at0003";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataClinical_description
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataClinical_descriptionName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataClinical_description()
        {
            this.archetype_node_id = "at0005";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataClinical_descriptionName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataClinical_descriptionName()
        {
            this.value = "Clinical description";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEye Eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultPerimetry_method Perimetry_method;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Visual_field_result")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultVisual_field_result[] Visual_field_result;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultImage Image;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_result()
        {
            this.archetype_node_id = "at0007";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultName()
        {
            this.value = "Test result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEye()
        {
            this.archetype_node_id = "at0008";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeName()
        {
            this.value = "Eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeValueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultEyeValueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0019,
        
        /// <remarks/>
        at0020,
        
        /// <remarks/>
        at0021,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultPerimetry_method
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultPerimetry_methodName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultPerimetry_method()
        {
            this.archetype_node_id = "at0018";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultPerimetry_methodName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultPerimetry_methodName()
        {
            this.value = "Perimetry method";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultVisual_field_result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultVisual_field_resultName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultVisual_field_result()
        {
            this.archetype_node_id = "at0009";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultVisual_field_resultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultVisual_field_resultName()
        {
            this.value = "Visual field result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultImage
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultImageName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_MULTIMEDIA))]
        public DATA_VALUE Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultImage()
        {
            this.archetype_node_id = "at0006";
            this.type = "ELEMENT";
            this.valueType = "DV_MULTIMEDIA";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultImageName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Interval_EventDataTest_resultImageName()
        {
            this.value = "Image";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_Event
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventName name;
        
        /// <remarks/>
        public DV_DATE_TIME time;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventData data;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_Event()
        {
            this.archetype_node_id = "at0002";
            this.type = "POINT_EVENT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventName()
        {
            this.value = "Any event";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventData
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataClinical_description Clinical_description;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Test_result")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_result[] Test_result;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventData()
        {
            this.archetype_node_id = "at0003";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataClinical_description
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataClinical_descriptionName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataClinical_description()
        {
            this.archetype_node_id = "at0005";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataClinical_descriptionName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataClinical_descriptionName()
        {
            this.value = "Clinical description";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultName name;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEye Eye;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultPerimetry_method Perimetry_method;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Visual_field_result")]
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultVisual_field_result[] Visual_field_result;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultImage Image;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_result()
        {
            this.archetype_node_id = "at0007";
            this.type = "CLUSTER";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultName()
        {
            this.value = "Test result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEye
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeValue))]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEye()
        {
            this.archetype_node_id = "at0008";
            this.type = "ELEMENT";
            this.valueType = "DV_CODED_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeName()
        {
            this.value = "Eye";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeValue
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeValueDefining_code defining_code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeValueDefining_code
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeValueDefining_codeTerminology_id terminology_id;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeValueDefining_codeCode_string code_string;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeValueDefining_codeTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeValueDefining_codeTerminology_id()
        {
            this.value = "local";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public enum ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultEyeValueDefining_codeCode_string
    {
        
        /// <remarks/>
        at0019,
        
        /// <remarks/>
        at0020,
        
        /// <remarks/>
        at0021,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultPerimetry_method
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultPerimetry_methodName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultPerimetry_method()
        {
            this.archetype_node_id = "at0018";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultPerimetry_methodName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultPerimetry_methodName()
        {
            this.value = "Perimetry method";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultVisual_field_result
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultVisual_field_resultName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultVisual_field_result()
        {
            this.archetype_node_id = "at0009";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultVisual_field_resultName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultVisual_field_resultName()
        {
            this.value = "Visual field result";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultImage
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultImageName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_MULTIMEDIA))]
        public DATA_VALUE Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultImage()
        {
            this.archetype_node_id = "at0006";
            this.type = "ELEMENT";
            this.valueType = "DV_MULTIMEDIA";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultImageName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationVisual_field_measurementDataAny_event_as_Point_EventDataTest_resultImageName()
        {
            this.value = "Image";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_Synopsis
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisName name;
        
        /// <remarks/>
        public UID_BASED_ID uid;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("links")]
        public LINK[] links;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisLanguage language;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisEncoding encoding;
        
        /// <remarks/>
        public PARTY_SELF subject;
        
        /// <remarks/>
        public PARTY_IDENTIFIED provider;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other_participations")]
        public PARTICIPATION[] other_participations;
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisData data;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_Synopsis()
        {
            this.archetype_node_id = "openEHR-EHR-EVALUATION.clinical_synopsis.v1";
            this.type = "EVALUATION";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisName()
        {
            this.value = "Clinical Synopsis";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisLanguage
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisLanguageTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisLanguage()
        {
            this.code_string = "en";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisLanguageTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisLanguageTerminology_id()
        {
            this.value = "ISO_639-1";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisEncoding
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisEncodingTerminology_id terminology_id;
        
        /// <remarks/>
        public string code_string;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisEncoding()
        {
            this.code_string = "UTF-8";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisEncodingTerminology_id
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string value;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisEncodingTerminology_id()
        {
            this.value = "IANA_character-sets";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisData
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisDataManagement_decision Management_decision;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisData()
        {
            this.archetype_node_id = "at0001";
            this.type = "ITEM_TREE";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisDataManagement_decision
    {
        
        /// <remarks/>
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisDataManagement_decisionName name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("null_flavour", typeof(DV_CODED_TEXT))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(DV_TEXT))]
        public DV_TEXT Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string archetype_node_id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisDataManagement_decision()
        {
            this.archetype_node_id = "at0002";
            this.type = "ELEMENT";
            this.valueType = "DV_TEXT";
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.oceanehr.com/templates")]
    public partial class ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisDataManagement_decisionName
    {
        
        /// <remarks/>
        public string value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mappings")]
        public TERM_MAPPING[] mappings;
        
        /// <remarks/>
        public CODE_PHRASE defining_code;
        
        public ITK_Initial_Glaucoma_Assessment_2_prd__Glaucoma_examinationClinical_SynopsisDataManagement_decisionName()
        {
            this.value = "Management decision";
        }
    }
}
