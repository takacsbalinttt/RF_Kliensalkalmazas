using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiSample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTest.Test
{
    internal class TermekTestFixture
    {
        [Test]
        public void button_plus_Click_IncreasesQuantity()
        {
            
            var form = new Form1();
            var initialQuantity = 5;
            form.textBox_mennyiseg.Text = initialQuantity.ToString();

            
            form.button_plus_Click(null, null);

            
            var expectedQuantity = initialQuantity + 1;
            Assert.AreEqual(expectedQuantity.ToString(), form.textBox_mennyiseg.Text);
        }

        [Test]
        public void button_minus_Click_DecreasesQuantity()
        {
            
            var form = new Form1();
            var initialQuantity = 5;
            form.textBox_mennyiseg.Text = initialQuantity.ToString();

            
            form.button_minus_Click(null, null);

            
            var expectedQuantity = initialQuantity - 1;
            Assert.AreEqual(expectedQuantity.ToString(), form.textBox_mennyiseg.Text);
        }


        [Test]
        public void TestInventoryIdInitialization()
        {
            
            string expectedInventoryId = "ba5790e5-a252-4fcc-885e-4918f07c6c20";

            
            Termek termek = new Termek();
            termek.inventory_id = expectedInventoryId;

            
            Assert.AreEqual(expectedInventoryId, termek.inventory_id);
        }

        [Test]
        public void TestInventoryIdIsNullWhenNotSet()
        {
            
            Termek termek = new Termek();

            
            Assert.IsNull(termek.inventory_id);
        }

        [Test]
        public void TestInventoryIdCanBeChanged()
        {
            
            Termek termek = new Termek();
            termek.inventory_id = "initial_inventory_id";
            string expectedInventoryId = "new_inventory_id";

            
            termek.inventory_id = expectedInventoryId;

            
            Assert.AreEqual(expectedInventoryId, termek.inventory_id);
        }

        [Test]
        public void TestInventoryIsZeroByDefault()
        {
            
            Termek termek = new Termek();

            
            Assert.AreEqual(0, termek.keszlet);
        }

        [Test]
        public void TestInventorySetCorrectly()
        {
            
            Termek termek = new Termek();
            int expectedInventory = 10;

            
            termek.keszlet = expectedInventory;

            
            Assert.AreEqual(expectedInventory, termek.keszlet);
        }

        [Test]
        public void TestProductNameCannotBeEmpty()
        {
            
            Termek termek = new Termek();
            string invalidProductName = "";

            
            Assert.Throws<ArgumentException>(() => termek.nev = invalidProductName);
        }

        [Test]
        public void TestProductNameMaxLength()
        {
            
            Termek termek = new Termek();
            string longProductName = new string('A', 10000);

            
            Assert.Throws<ArgumentException>(() => termek.nev = longProductName);
        }

        [Test]
        public void TestProductNameSpecialCharacters()
        {
            
            Termek termek = new Termek();
            string productNameWithSpecialCharacters = "Example Product #123";

            
            Assert.Throws<ArgumentException>(() => termek.nev = productNameWithSpecialCharacters);
        }

        [Test]
        public void button_mentes_Click_UpdatesQuantity()
        {
            
            var form = new Form1();
            var initialQuantity = 120;
            form.textBox_mennyiseg.Text = initialQuantity.ToString();
            var selectedProductIndex = 0;

            
            form.listBox1.SelectedIndex = selectedProductIndex;
            form.button_mentes_Click(null, null);

            
            var expectedQuantity = int.Parse(form.textBox_mennyiseg.Text);
            Assert.AreEqual(expectedQuantity, form.termeklista[selectedProductIndex].keszlet);
        }
        

        [Test]
        public void button_megse_Click_RestoresOriginalQuantity()
        {
            
            var form = new Form1();
            var initialQuantity = 120;
            form.textBox_mennyiseg.Text = initialQuantity.ToString();
            var selectedProductIndex = 0;

            
            form.listBox1.SelectedIndex = selectedProductIndex;
            form.button_megse_Click(null, null);

            
            var expectedQuantity = initialQuantity;
            Assert.AreEqual(expectedQuantity.ToString(), form.textBox_mennyiseg.Text);
        }

        

    }


}
