// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats.Spreadsheet
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using NPOI.OpenXmlFormats.Dml;

    public class ST_UnsignedshortHex
    {
        string stringValueField = null;
        public string StringValue
        {
            get { return stringValueField; }
            set { stringValueField = value; }
        }
        public byte[] ToBytes()
        {
            throw new NotImplementedException();
        }
    }





    public class CT_GradientFill
    {

        private List<CT_GradientStop> stopField;

        private ST_GradientType typeField;

        private double degreeField;

        private double leftField;

        private double rightField;

        private double topField;

        private double bottomField;

        public CT_GradientFill()
        {
            this.stopField = new List<CT_GradientStop>();
            this.typeField = ST_GradientType.linear;
            this.degreeField = 0D;
            this.leftField = 0D;
            this.rightField = 0D;
            this.topField = 0D;
            this.bottomField = 0D;
        }

        public List<CT_GradientStop> stop
        {
            get
            {
                return this.stopField;
            }
            set
            {
                this.stopField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(ST_GradientType.linear)]
        public ST_GradientType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(0D)]
        public double degree
        {
            get
            {
                return this.degreeField;
            }
            set
            {
                this.degreeField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(0D)]
        public double left
        {
            get
            {
                return this.leftField;
            }
            set
            {
                this.leftField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(0D)]
        public double right
        {
            get
            {
                return this.rightField;
            }
            set
            {
                this.rightField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(0D)]
        public double top
        {
            get
            {
                return this.topField;
            }
            set
            {
                this.topField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(0D)]
        public double bottom
        {
            get
            {
                return this.bottomField;
            }
            set
            {
                this.bottomField = value;
            }
        }
    }
    public class CT_XStringElement
    {

        private string vField;

        public string v
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]

    public class CT_Extension
    {

        private System.Xml.XmlElement anyField;

        private string uriField;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement Any
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
    }
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]

    public class CT_ExtensionList
    {

        private List<CT_Extension> extField;

        public CT_ExtensionList()
        {
            this.extField = new List<CT_Extension>();
        }
        [System.Xml.Serialization.XmlElementAttribute("ext")]
        public List<CT_Extension> ext
        {
            get
            {
                return this.extField;
            }
            set
            {
                this.extField = value;
            }
        }
    }
}
