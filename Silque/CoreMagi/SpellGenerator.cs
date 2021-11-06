using System;
using System.Collections.Generic;
using System.Xml;
using Silque.CoreMagi.Properties;

namespace Silque.CoreMagi
{
    public class SpellGenerator
    {
        public SpellGenerator ()
        {
            // Acceps the following information:
            // the player

        }

        public bool LoadProperties(XmlNode XmlData)
        {
            // Make alignments
            XmlNode root = XmlData.SelectSingleNode("Alignments");
            foreach (XmlNode alignment in root.ChildNodes)
            {
                new Alignment(CreateIDXML(root.Attributes["id_prefix"].Value
                        ,alignment.SelectSingleNode("ID").InnerText
                        ,XmlData.Attributes["id_size"].Value)
                    ,alignment.SelectSingleNode("Name").InnerText);
            }
            // Make affinities
            root = XmlData.SelectSingleNode("Affinities");
            foreach (XmlNode affinity in root.ChildNodes)
            {
                new Affinity(CreateIDXML(root.Attributes["id_prefix"].Value
                        ,affinity.SelectSingleNode("ID").InnerText
                        ,XmlData.Attributes["id_size"].Value)
                    ,affinity.SelectSingleNode("Name").InnerText);
            }
            // Make elements
            root = XmlData.SelectSingleNode("Elements");
            foreach (XmlNode element in root.ChildNodes)
            {
                new Element(CreateIDXML(root.Attributes["id_prefix"].Value
                        ,element.SelectSingleNode("ID").InnerText
                        ,XmlData.Attributes["id_size"].Value)
                    , element.SelectSingleNode("Name").InnerText);
            }
            // Make attributes
            root = XmlData.SelectSingleNode("Attributes");
            foreach (XmlNode Attribute in root.ChildNodes)
            {
                uint id = CreateIDXML(root.Attributes["id_prefix"].Value,
                    Attribute.SelectSingleNode("ID").InnerText,
                    XmlData.Attributes["id_size"].Value);
                string name = Attribute.SelectSingleNode("Name").InnerText;
                Alignment align = Alignment.GetByID(Convert.ToUInt32(
                    Attribute.SelectSingleNode("Alignment_ID").InnerText));
                Affinity affin = Affinity.GetByID(Convert.ToUInt32(
                    Attribute.SelectSingleNode("Affinity_ID").InnerText));

                new SpellAttribute(id, name, align, affin);
            }
            return true;
        }

        public bool LoadProperties(string path)
        {
            XmlNode xml = PathToXML(path);
            return LoadProperties(xml);
        }

        public bool UnloadProperties()
        {
            Alignment.ResetAll();
            Affinity.ResetAll();
            Element.ResetAll();
            SpellAttribute.ResetAll();

            return true;
        }

        public Spell MakeSpell(SpellTemplate Template)
        {
            // Creates unactivated instance of spell
            // Register lockdown of properties
            // Appends into history of spells
            // Appends into active spells in player
            // Appends into active spells in scene
            Element elem = Element.GetByName(Template.Element);
            List<Affinity> affin = new List<Affinity>();
            foreach (string i in Template.Affinities)
            {
                Affinity a = Affinity.GetByName(i);
                if (a != null) affin.Add(a);
            }
            Alignment align = Alignment.GetByName(Template.Alignment);

            List<SpellAttribute> attrib = new List<SpellAttribute>();
            foreach (string i in Template.Attributes)
            {
                SpellAttribute a = SpellAttribute.GetByName(i);
                if (a != null) attrib.Add(a);
            }

            return new Spell(elem, affin, align, attrib);
        }

        public Spell MakeSpell(Element Element, List<Affinity> Affinities, Alignment Alignment, List<SpellAttribute> Attributes)
        {
            return new Spell(Element, Affinities, Alignment, Attributes);
        }

        XmlNode PathToXML(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode node = doc.DocumentElement.SelectSingleNode("/SpellProperties");
            return node;
        }

        uint CreateIDXML(string prefix, string id, string length)
        {
            string value = prefix + id;
            int i_length = Convert.ToInt32(length);
            if (value.Length != i_length) value = value.Insert(
                prefix.Length, new string('0', i_length - value.Length)
            );
            return Convert.ToUInt32(value);
        }
    }
}
