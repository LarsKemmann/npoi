﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{

    public interface EG_ObjectChoices
    { 
        
    }
    public class CT_ShapeNonVisual
    {
        private CT_NonVisualDrawingProps cNvPrField;
        private CT_NonVisualDrawingShapeProps cNvSpPrField;

        public CT_NonVisualDrawingProps AddNewCNvPr()
        {
            this.cNvPrField = new CT_NonVisualDrawingProps();
            return this.cNvPrField;
        }
        public CT_NonVisualDrawingShapeProps AddNewCNvSpPr()
        {
            this.cNvSpPrField = new CT_NonVisualDrawingShapeProps();
            return this.cNvSpPrField;
        }

        public CT_NonVisualDrawingProps cNvPr
        {
            get
            {
                return this.cNvPrField;
            }
            set
            {
                this.cNvPrField = value;
            }
        }

        public CT_NonVisualDrawingShapeProps cNvSpPr
        {
            get
            {
                return this.cNvSpPrField;
            }
            set
            {
                this.cNvSpPrField = value;
            }
        }
    }
    public class CT_GraphicalObjectFrameNonVisual
    {

        CT_NonVisualDrawingProps cNvPrField;
        CT_NonVisualGraphicFrameProperties cNvGraphicFramePrField;

        public CT_NonVisualDrawingProps AddNewCNvPr()
        {
            this.cNvPrField = new CT_NonVisualDrawingProps();
            return this.cNvPrField;
        }
        public CT_NonVisualGraphicFrameProperties AddNewCNvGraphicFramePr()
        {
            this.cNvGraphicFramePrField = new CT_NonVisualGraphicFrameProperties();
            return this.cNvGraphicFramePrField;
        }

        public CT_NonVisualDrawingProps cNvPr
        {
            get { return cNvPrField; }
            set { cNvPrField = value; }
        }
        public CT_NonVisualGraphicFrameProperties cNvGraphicFramePr
        {
            get { return cNvGraphicFramePrField; }
            set { cNvGraphicFramePrField = value; }
        }
    }
    public class CT_GraphicalObjectFrame
    {
        CT_GraphicalObjectFrameNonVisual nvGraphicFramePrField;
        CT_Transform2D xfrmField;
        CT_GraphicalObject graphicField;
        private string macroField;
        private bool fPublishedField;

        public CT_Transform2D AddNewXfrm()
        {
            this.xfrmField = new CT_Transform2D();
            return this.xfrmField;
        }
        public CT_GraphicalObject AddNewGraphic()
        {
            this.graphicField = new CT_GraphicalObject();
            return this.graphicField;
        }

        public CT_GraphicalObjectFrameNonVisual AddNewNvGraphicFramePr()
        {
            this.nvGraphicFramePr=new CT_GraphicalObjectFrameNonVisual();
            return this.nvGraphicFramePr;
        }

        public CT_GraphicalObjectFrameNonVisual nvGraphicFramePr
        {
            get { return nvGraphicFramePrField; }
            set { nvGraphicFramePrField = value; }
        }
        public CT_Transform2D xfrm
        {
            get { return xfrmField; }
            set { xfrmField = value; }
        }
        [XmlAttributeAttribute()]
        public string macro
        {
            get { return macroField; }
            set { macroField = value; }
        }
        [XmlAttributeAttribute()]
        public bool fPublished
        {
            get { return fPublishedField; }
            set { fPublishedField = value; }
        }
        
        public CT_GraphicalObject graphic
        {
            get { return graphicField; }
            set { graphicField = value; }
        }
    }
    public class CT_Shape : EG_ObjectChoices
    {
        private CT_ShapeNonVisual nvSpPrField;
        private CT_ShapeProperties spPrField;
        private CT_ShapeStyle styleField;
        private CT_TextBody txBodyField;

        private string macroField;
        private string textlinkField;
        private bool fLocksTextField;
        private bool fPublishedField;

        public void Set(CT_Shape obj)
        {
            
        }

        public CT_ShapeNonVisual AddNewNvSpPr()
        {
            this.nvSpPrField = new CT_ShapeNonVisual();
            return this.nvSpPrField;
        }

        public CT_ShapeProperties AddNewSpPr()
        {
            this.spPrField = new CT_ShapeProperties();
            return this.spPrField;
        }
        public CT_ShapeStyle AddNewStyle()
        {
            this.styleField = new CT_ShapeStyle();
            return this.styleField;
        }
        public CT_TextBody AddNewTxBody()
        {
            this.txBodyField = new CT_TextBody();
            return this.txBodyField;
        }

        public CT_ShapeNonVisual nvSpPr
        {
            get
            {
                return this.nvSpPrField;
            }
            set
            {
                this.nvSpPrField = value;
            }
        }
        public CT_ShapeProperties spPr
        {
            get
            {
                return this.spPrField;
            }
            set
            {
                this.spPrField = value;
            }
        }
        public CT_TextBody txBody
        {
            get
            {
                return this.txBodyField;
            }
            set
            {
                this.txBodyField = value;
            }
        }
        public CT_ShapeStyle style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        [XmlAttributeAttribute()]
        public string macro
        {
            get { return macroField; }
            set { macroField = value; }
        }

        [XmlAttributeAttribute()]
        public string textlink
        {
            get { return textlinkField; }
            set { textlinkField = value; }
        }
        [XmlAttributeAttribute()]
        public bool fLocksText
        {
            get { return fLocksTextField; }
            set { fLocksTextField = value; }
        }

        [XmlAttributeAttribute()]
        public bool fPublished
        {
            get { return fPublishedField; }
            set { fPublishedField = value; }
        }
    }
    public class CT_ConnectorNonVisual
    {
        private CT_NonVisualDrawingProps cNvPrField;
        private CT_NonVisualConnectorProperties cNvCxnSpPrField;

        public CT_NonVisualConnectorProperties cNvCxnSpPr
        {
            get
            {
                return this.cNvCxnSpPrField;
            }
            set
            {
                this.cNvCxnSpPrField = value;
            }
        }
        public CT_NonVisualDrawingProps AddNewCNvPr()
        {
            this.cNvPr = new CT_NonVisualDrawingProps();
            return this.cNvPr;
        }
        public CT_NonVisualConnectorProperties AddNewCNvCxnSpPr()
        {
            this.cNvCxnSpPr = new CT_NonVisualConnectorProperties();
            return this.cNvCxnSpPr;
        }


        public CT_NonVisualDrawingProps cNvPr
        {
            get
            {
                return this.cNvPrField;
            }
            set
            {
                this.cNvPrField = value;
            }
        }
    }
    public class CT_GroupShape
    {
        CT_GroupShapeProperties grpSpPrField;
        CT_GroupShapeNonVisual nvGrpSpPrField;

        public CT_GroupShapeProperties AddNewGrpSpPr()
        {
            this.grpSpPrField = new CT_GroupShapeProperties();
            return this.grpSpPrField;
        }
        public CT_GroupShapeNonVisual AddNewNvGrpSpPr()
        {
            this.nvGrpSpPrField = new CT_GroupShapeNonVisual();
            return this.nvGrpSpPrField;
        }
        public CT_Connector AddNewCxnSp()
        {
            throw new NotImplementedException();
        }
        public CT_Shape AddNewSp()
        {
            throw new NotImplementedException();
        }
        public CT_Picture AddNewPic()
        {
            throw new NotImplementedException();
        }

        public CT_GroupShapeNonVisual nvGrpSpPr
        {
            get { return nvGrpSpPrField; }
            set { nvGrpSpPrField = value; }
        }
        public CT_GroupShapeProperties grpSpPr
        {
            get { return grpSpPrField; }
            set { grpSpPrField = value; }
        
        }
    }
    public class CT_GroupShapeNonVisual
    {
        CT_NonVisualDrawingProps cNvPrField;
        CT_NonVisualGroupDrawingShapeProps cNvGrpSpPrField;

        public CT_NonVisualGroupDrawingShapeProps AddNewCNvGrpSpPr()
        {
            this.cNvGrpSpPrField = new CT_NonVisualGroupDrawingShapeProps();
            return this.cNvGrpSpPrField;
        }
        public CT_NonVisualDrawingProps AddNewCNvPr()
        {
            this.cNvPrField = new CT_NonVisualDrawingProps();
            return this.cNvPrField;
        }

        public CT_NonVisualDrawingProps cNvPr
        {
            get { return cNvPrField; }
            set { cNvPrField = value; }
        }
        public CT_NonVisualGroupDrawingShapeProps cNvGrpSpPr
        {
            get { return cNvGrpSpPrField; }
            set { cNvGrpSpPrField = value; }
        }
    }
    public class CT_Marker
    {
        public int col
        {
            get;set;
        }
        public long colOff
        {
        get;set;
        }
        public int row
        {
        get;set;
        }
        public long rowOff
        {
        get;set;
        }
    }
    public enum ST_EditAs
    {
        twoCell,
        oneCell,
        absolute
    }
    public class CT_AnchorClientData
    {
        [XmlAttribute]
        public bool fLocksWithSheet
        {
            get;
            set;
        }
        [XmlAttribute]
        public bool fPrintsWithSheet
        {
            get;
            set;
        }
    }
    public interface EG_Anchor
    { 
    
    }
    public class CT_Drawing
    {

        private string idField;

        public CT_TwoCellAnchor AddNewTwoCellAnchor()
        {
            throw new NotImplementedException();
        }
        public int sizeOfTwoCellAnchorArray()
        {
            throw new NotImplementedException();
        }

        public string id
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
    }

    public class CT_LegacyDrawing
    {

        private string idField;

        public string id
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
    }

    public class CT_TwoCellAnchor : EG_Anchor
    {
        private CT_Marker fromField;
        private CT_Marker toField;
        private CT_AnchorClientData clientDataField;

        public CT_GraphicalObjectFrame AddNewGraphicFrame()
        {
            throw new NotImplementedException();
        }

        public CT_Picture AddNewPic()
        {
            throw new NotImplementedException();
        }
        public CT_Shape AddNewSp()
        {
            throw new NotImplementedException();
        }
        public CT_GroupShape AddNewGrpSp()
        {
            throw new NotImplementedException();
        }
        public CT_Connector AddNewCxnSp()
        {
            throw new NotImplementedException();
        }

        public CT_Marker from
        {
            get { return fromField; }
            set { fromField = value; }
        }
        public CT_Marker to
        {
            get { return toField; }
            set { toField = value; }
        }
        public ST_EditAs editAs
        {
            get;
            set;
        }
        public CT_AnchorClientData clientData
        {
            get { return clientDataField; }
            set { clientDataField = value; } 
        }
    }
    public class CT_Connector : EG_ObjectChoices
    { 
        string macroField;
        bool fPublishField;
        private CT_ShapeProperties spPrField;
        private CT_ShapeStyle styleField;
        private CT_ConnectorNonVisual nvCxnSpPrField;
        public CT_ConnectorNonVisual nvCxnSpPr
        {
            get { return nvCxnSpPrField; }
            set { nvCxnSpPrField = value; }
        }
        public CT_ConnectorNonVisual AddNewNvCxnSpPr()
        {
            this.nvCxnSpPr = new CT_ConnectorNonVisual();
            return nvCxnSpPr;
        }
        public CT_ShapeProperties AddNewSpPr()
        {
            this.spPrField = new CT_ShapeProperties();
            return spPrField;
        }
        public CT_ShapeStyle AddNewStyle()
        {
            this.styleField=new CT_ShapeStyle();
            return this.styleField;
        }
        public CT_ShapeProperties spPr
        {
            get
            {
                return this.spPrField;
            }
            set
            {
                this.spPrField = value;
            }
        }
         public CT_ShapeStyle style
         {
             get
             {
                 return this.styleField;
             }
             set
             {
                 this.styleField = value;
             }
         }
         [XmlAttributeAttribute()]
        public string macro
        {
            get{return this.macroField;}
            set{this.macroField=value;}
        }
        [XmlAttributeAttribute()]
        public bool fPublished
        {
            get{return this.fPublishField;}
            set{this.fPublishField = value;}
        }
    }
    public partial class CT_Picture:EG_ObjectChoices
    { 
        private CT_ShapeStyle styleField;
        private string macroField;
        private bool fPublishedField;

        [XmlAttributeAttribute()]
        public string macro
        {
            get { return macroField; }
            set { macroField = value; }
        }

        [XmlAttributeAttribute()]
        public bool fPublished
        {
            get { return fPublishedField; }
            set { fPublishedField = value; }
        }
        public CT_ShapeStyle style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }
    }
}
