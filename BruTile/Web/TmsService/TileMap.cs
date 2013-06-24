﻿// Copyright (c) BruTile developers team. All rights reserved. See License.txt in the project root for license information.

namespace BruTile.Web.TmsService
{
    // 
    // This source code was auto-generated by xsd, Version=2.0.50727.3038.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]

    public partial class TileMap
    {
        private string titleField;

        private string abstractField;

        private string sRSField;

        private TileMapBoundingBox boundingBoxField;

        private TileMapOrigin originField;

        private TileMapTileFormat tileFormatField;

        private TileMapTileSets tileSetsField;

        private string versionField;

        private string tilemapserviceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Title
        {
            get
            {
                return titleField;
            }
            set
            {
                titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Abstract
        {
            get
            {
                return abstractField;
            }
            set
            {
                abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRS
        {
            get
            {
                return sRSField;
            }
            set
            {
                sRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BoundingBox", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TileMapBoundingBox BoundingBox
        {
            get
            {
                return boundingBoxField;
            }
            set
            {
                boundingBoxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Origin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TileMapOrigin Origin
        {
            get
            {
                return originField;
            }
            set
            {
                originField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TileFormat", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TileMapTileFormat TileFormat
        {
            get
            {
                return tileFormatField;
            }
            set
            {
                tileFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TileSets", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TileMapTileSets TileSets
        {
            get
            {
                return tileSetsField;
            }
            set
            {
                tileSetsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return versionField;
            }
            set
            {
                versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tilemapservice
        {
            get
            {
                return tilemapserviceField;
            }
            set
            {
                tilemapserviceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TileMapBoundingBox
    {

        private string minxField;

        private string minyField;

        private string maxxField;

        private string maxyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string minx
        {
            get
            {
                return minxField;
            }
            set
            {
                minxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string miny
        {
            get
            {
                return minyField;
            }
            set
            {
                minyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maxx
        {
            get
            {
                return maxxField;
            }
            set
            {
                maxxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maxy
        {
            get
            {
                return maxyField;
            }
            set
            {
                maxyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TileMapOrigin
    {

        private string xField;

        private string yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string x
        {
            get
            {
                return xField;
            }
            set
            {
                xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string y
        {
            get
            {
                return yField;
            }
            set
            {
                yField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TileMapTileFormat
    {

        private string widthField;

        private string heightField;

        private string mimetypeField;

        private string extensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string width
        {
            get
            {
                return widthField;
            }
            set
            {
                widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string height
        {
            get
            {
                return heightField;
            }
            set
            {
                heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mime-type")]
        public string mimetype
        {
            get
            {
                return mimetypeField;
            }
            set
            {
                mimetypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extension
        {
            get
            {
                return extensionField;
            }
            set
            {
                extensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TileMapTileSets
    {

        private TileMapTileSetsTileSet[] tileSetField;

        private string profileField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TileSet", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TileMapTileSetsTileSet[] TileSet
        {
            get
            {
                return tileSetField;
            }
            set
            {
                tileSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string profile
        {
            get
            {
                return profileField;
            }
            set
            {
                profileField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TileMapTileSetsTileSet
    {

        private string hrefField;

        private string unitsperpixelField;

        private string orderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return hrefField;
            }
            set
            {
                hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("units-per-pixel")]
        public string unitsperpixel
        {
            get
            {
                return unitsperpixelField;
            }
            set
            {
                unitsperpixelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string order
        {
            get
            {
                return orderField;
            }
            set
            {
                orderField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NewDataSet
    {
        private TileMap[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TileMap")]
        public TileMap[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }
    }
}