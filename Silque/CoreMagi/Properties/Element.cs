using System;
using System.Collections.Generic;
using System.Xml;

namespace Silque.CoreMagi.Properties {
    public class Element : Property<Element>, IProperty {

        Dictionary<string, Relation> _eleRelation = new Dictionary<string, Relation>();

        public override Dictionary<string, float> Values { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Element(uint ID, string Name) : base(ID, Name)
        {

        }

        public bool AssignRelation()
        {
            return true;
        }

        public static bool GenerateRelation (XmlNode XmlData)
        {
            foreach (XmlNode Relationship in XmlData.ChildNodes)
            {

            }
            return true;
        }

        public Relation GetRelationship (string elementName)
        {
            return _eleRelation[elementName];
        }
    }
}