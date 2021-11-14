using NUnit.Framework;
using System;
using Silque.CoreMagi;
using Silque.CoreMagi.Handlers;
using Silque.CoreMagi.Properties;
using System.Xml;

namespace Silque.Tests
{
    public class Spell_Properties_Creation
    {
        SpellGenerator sg = new SpellGenerator();
        [SetUp]
        public void Setup()
        {
            sg.UnloadProperties();
            Alignment.ResetAll();
            Affinity.ResetAll();
        }

        [Test]
        public void A1_Alignment_Duplicate_Creation()
        {
            try
            {
                new Alignment(100001, "Alignment 1");
                new Alignment(100001, "Alignment 2");
                Assert.Fail($"No error raised. There are {Alignment.GetAll().Length} alignments.");
            } catch (Exception e)
            {
                Assert.AreEqual("Alignment of ID: 100001 already exists as Alignment 1.", e.Message);
            }
        }

        [Test]
        public void A2_Alignment_Reset()
        {
            try
            {
                new Alignment(100001, "Alignment 1");
                Alignment.ResetAll();
                Assert.AreEqual(0, Alignment.GetAll().Length);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test]
        public void A3_Alignment_Removal()
        {
            try
            {
                Alignment align1 = new Alignment(100001, "Alignment 1");
                align1.DestroySelf();
                Assert.AreEqual(0, Alignment.GetAll().Length);
            } catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test]
        public void A4_Alignment_And_Affinity()
        {
            try
            {
                new Alignment(100001, "Alignment 1");
                new Affinity(200001, "Affinity 1");
                new Affinity(200002, "Affinity 2");

                Assert.AreEqual(1, Alignment.GetAll().Length);
                Assert.AreEqual(2, Affinity.GetAll().Length);
            } catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test]
        public void A5_Get_By_ID()
        {
            new Alignment(100001, "Alignment 1");
            new Alignment(100002, "Alignment 2");
            new Alignment(100003, "Alignment 3");

            Assert.AreEqual("Alignment 2", Alignment.GetByID(100002).Name);
        }

        [Test]
        public void A6_Delete_ID()
        {
            new Alignment(100001, "Alignment 1");
            Assert.IsTrue(Alignment.GetByID(100001).DestroySelf());
            Assert.AreEqual(0, Alignment.GetAll().Length);
        }

        [Test]
        public void A7_Type()
        {
            Alignment a = new Alignment(100001, "Alignment 1");
            Assert.AreEqual("Alignment", a.GetType().Name);
        }

        [Test]
        public void A8_GetByName()
        {
            new Element(300001, "Fire");
            Assert.AreEqual(300001, Element.GetByName("Fire").ID);
        }
    }

    public class Spell_Generator_Tests
    {
        SpellGenerator sg = new SpellGenerator();
        [SetUp]
        public void Setup()
        {
            sg.UnloadProperties();
        }

        [Test]
        public void D1_Create_From_XML()
        {
            sg.LoadProperties("SpellProperties.xml");
        }
    }
    public class Spell_Creation_Tests
    {
        SpellGenerator sg = new SpellGenerator();

        [SetUp]
        public void Setup()
        {
            sg.UnloadProperties();
            sg.LoadProperties("SpellProperties.xml");
        }

        [Test]
        public void B1_New_Basic_Spell()
        {
            SpellTemplate t = new SpellTemplate(
                "Fire", "Projectile",
                new string[] { "Chaos", "Anima" },
                new string[] { "Large", "Fast", "Penetration" });
            Spell output = sg.MakeSpell(t);
            Assert.AreEqual(SpellState.Disabled, output.State.Current);
            Assert.AreEqual("Fire", output.Information.Element.Name);
            Assert.AreEqual("Fast", output.Information.Attributes.Find((a) => a.Name == "Fast").Name);
        }

        [Test]
        public void B2_New_Basic_Spell_Library()
        {
            SpellTemplate t = new SpellTemplate(
                "Fire", "Projectile",
                new string[] { "chaos", "anima" },
                new string[] { "large", "fast", "penetration" });
            Spell output = sg.MakeSpell(t);
            Assert.AreEqual(SpellState.Disabled, output.Information.State);
        }
    }

    public class Spell_PhysicalHandler
    {
        SpellGenerator sg = new SpellGenerator();
        [SetUp]
        public void Setup()
        {
            sg.UnloadProperties();
        }

        [Test]
        public void C1_New_Basic_Spell_Physical_Handle()
        {
            Assert.Fail();
        }
    }
}