//  Copyright 2011 U.S. Department of Defense

//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at

//      http://www.apache.org/licenses/LICENSE-2.0

//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.



//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "info:fedora/fedora-system:def/foxml#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "info:fedora/fedora-system:def/foxml#", IsNullable = false)]
public partial class digitalObject : digitalObjectType
{
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "info:fedora/fedora-system:def/foxml#")]
public partial class digitalObjectType
{

    private objectPropertiesType objectPropertiesField;

    private datastreamType[] datastreamField;

    private digitalObjectTypeVERSION vERSIONField;

    private string pIDField;

    private string fEDORA_URIField;

    private System.Xml.XmlAttribute[] anyAttrField;

    /// <remarks/>
    public objectPropertiesType objectProperties
    {
        get
        {
            return this.objectPropertiesField;
        }
        set
        {
            this.objectPropertiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("datastream")]
    public datastreamType[] datastream
    {
        get
        {
            return this.datastreamField;
        }
        set
        {
            this.datastreamField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public digitalObjectTypeVERSION VERSION
    {
        get
        {
            return this.vERSIONField;
        }
        set
        {
            this.vERSIONField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PID
    {
        get
        {
            return this.pIDField;
        }
        set
        {
            this.pIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string FEDORA_URI
    {
        get
        {
            return this.fEDORA_URIField;
        }
        set
        {
            this.fEDORA_URIField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr
    {
        get
        {
            return this.anyAttrField;
        }
        set
        {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "info:fedora/fedora-system:def/foxml#")]
public partial class objectPropertiesType
{

    private propertyType[] propertyField;

    private extpropertyType[] extpropertyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("property")]
    public propertyType[] property
    {
        get
        {
            return this.propertyField;
        }
        set
        {
            this.propertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("extproperty")]
    public extpropertyType[] extproperty
    {
        get
        {
            return this.extpropertyField;
        }
        set
        {
            this.extpropertyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "info:fedora/fedora-system:def/foxml#")]
public partial class propertyType
{

    private propertyTypeNAME nAMEField;

    private string vALUEField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public propertyTypeNAME NAME
    {
        get
        {
            return this.nAMEField;
        }
        set
        {
            this.nAMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string VALUE
    {
        get
        {
            return this.vALUEField;
        }
        set
        {
            this.vALUEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "info:fedora/fedora-system:def/foxml#")]
public enum propertyTypeNAME
{

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("info:fedora/fedora-system:def/model#state")]
    infofedorafedorasystemdefmodelstate,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("info:fedora/fedora-system:def/model#label")]
    infofedorafedorasystemdefmodellabel,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("info:fedora/fedora-system:def/model#createdDate")]
    infofedorafedorasystemdefmodelcreatedDate,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("info:fedora/fedora-system:def/view#lastModifiedDate")]
    infofedorafedorasystemdefviewlastModifiedDate,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("info:fedora/fedora-system:def/model#ownerId")]
    infofedorafedorasystemdefmodelownerId,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "info:fedora/fedora-system:def/foxml#")]
public partial class contentLocationType
{

    private contentLocationTypeTYPE tYPEField;

    private string rEFField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public contentLocationTypeTYPE TYPE
    {
        get
        {
            return this.tYPEField;
        }
        set
        {
            this.tYPEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string REF
    {
        get
        {
            return this.rEFField;
        }
        set
        {
            this.rEFField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "info:fedora/fedora-system:def/foxml#")]
public enum contentLocationTypeTYPE
{

    /// <remarks/>
    INTERNAL_ID,

    /// <remarks/>
    URL,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "info:fedora/fedora-system:def/foxml#")]
public partial class xmlContentType
{

    private System.Xml.XmlElement[] anyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "info:fedora/fedora-system:def/foxml#")]
public partial class contentDigestType
{

    private contentDigestTypeTYPE tYPEField;

    private bool tYPEFieldSpecified;

    private string dIGESTField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public contentDigestTypeTYPE TYPE
    {
        get
        {
            return this.tYPEField;
        }
        set
        {
            this.tYPEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TYPESpecified
    {
        get
        {
            return this.tYPEFieldSpecified;
        }
        set
        {
            this.tYPEFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DIGEST
    {
        get
        {
            return this.dIGESTField;
        }
        set
        {
            this.dIGESTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "info:fedora/fedora-system:def/foxml#")]
public enum contentDigestTypeTYPE
{

    /// <remarks/>
    MD5,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("SHA-1")]
    SHA1,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("SHA-256")]
    SHA256,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("SHA-384")]
    SHA384,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("SHA-512")]
    SHA512,

    /// <remarks/>
    HAVAL,

    /// <remarks/>
    TIGER,

    /// <remarks/>
    WHIRLPOOL,

    /// <remarks/>
    DISABLED,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "info:fedora/fedora-system:def/foxml#")]
public partial class datastreamVersionType
{

    private contentDigestType contentDigestField;

    private object itemField;

    private string idField;

    private string lABELField;

    private System.DateTime cREATEDField;

    private bool cREATEDFieldSpecified;

    private string mIMETYPEField;

    private string[] aLT_IDSField;

    private string fORMAT_URIField;

    private long sIZEField;

    public datastreamVersionType()
    {
        this.sIZEField = ((long)(0));
    }

    /// <remarks/>
    public contentDigestType contentDigest
    {
        get
        {
            return this.contentDigestField;
        }
        set
        {
            this.contentDigestField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("binaryContent", typeof(byte[]), DataType = "base64Binary")]
    [System.Xml.Serialization.XmlElementAttribute("contentLocation", typeof(contentLocationType))]
    [System.Xml.Serialization.XmlElementAttribute("xmlContent", typeof(xmlContentType))]
    public object Item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LABEL
    {
        get
        {
            return this.lABELField;
        }
        set
        {
            this.lABELField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime CREATED
    {
        get
        {
            return this.cREATEDField;
        }
        set
        {
            this.cREATEDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CREATEDSpecified
    {
        get
        {
            return this.cREATEDFieldSpecified;
        }
        set
        {
            this.cREATEDFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MIMETYPE
    {
        get
        {
            return this.mIMETYPEField;
        }
        set
        {
            this.mIMETYPEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string[] ALT_IDS
    {
        get
        {
            return this.aLT_IDSField;
        }
        set
        {
            this.aLT_IDSField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string FORMAT_URI
    {
        get
        {
            return this.fORMAT_URIField;
        }
        set
        {
            this.fORMAT_URIField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(long), "0")]
    public long SIZE
    {
        get
        {
            return this.sIZEField;
        }
        set
        {
            this.sIZEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "info:fedora/fedora-system:def/foxml#")]
public partial class datastreamType
{

    private datastreamVersionType[] datastreamVersionField;

    private string idField;

    private datastreamTypeCONTROL_GROUP cONTROL_GROUPField;

    private string fEDORA_URIField;

    private stateType sTATEField;

    private bool sTATEFieldSpecified;

    private bool vERSIONABLEField;

    public datastreamType()
    {
        this.vERSIONABLEField = true;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("datastreamVersion")]
    public datastreamVersionType[] datastreamVersion
    {
        get
        {
            return this.datastreamVersionField;
        }
        set
        {
            this.datastreamVersionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public datastreamTypeCONTROL_GROUP CONTROL_GROUP
    {
        get
        {
            return this.cONTROL_GROUPField;
        }
        set
        {
            this.cONTROL_GROUPField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string FEDORA_URI
    {
        get
        {
            return this.fEDORA_URIField;
        }
        set
        {
            this.fEDORA_URIField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public stateType STATE
    {
        get
        {
            return this.sTATEField;
        }
        set
        {
            this.sTATEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool STATESpecified
    {
        get
        {
            return this.sTATEFieldSpecified;
        }
        set
        {
            this.sTATEFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool VERSIONABLE
    {
        get
        {
            return this.vERSIONABLEField;
        }
        set
        {
            this.vERSIONABLEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "info:fedora/fedora-system:def/foxml#")]
public enum datastreamTypeCONTROL_GROUP
{

    /// <remarks/>
    E,

    /// <remarks/>
    M,

    /// <remarks/>
    R,

    /// <remarks/>
    X,

    /// <remarks/>
    B,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "info:fedora/fedora-system:def/foxml#")]
public enum stateType
{

    /// <remarks/>
    A,

    /// <remarks/>
    D,

    /// <remarks/>
    I,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "info:fedora/fedora-system:def/foxml#")]
public partial class extpropertyType
{

    private string nAMEField;

    private string vALUEField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NAME
    {
        get
        {
            return this.nAMEField;
        }
        set
        {
            this.nAMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string VALUE
    {
        get
        {
            return this.vALUEField;
        }
        set
        {
            this.vALUEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "info:fedora/fedora-system:def/foxml#")]
public enum digitalObjectTypeVERSION
{

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1.1")]
    Item11,
}
