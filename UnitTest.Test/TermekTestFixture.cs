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
            // Arrange
            var form = new Form1();
            var initialQuantity = 5;
            form.textBox_mennyiseg.Text = initialQuantity.ToString();

            // Act
            form.button_plus_Click(null, null);

            // Assert
            var expectedQuantity = initialQuantity + 1;
            Assert.AreEqual(expectedQuantity.ToString(), form.textBox_mennyiseg.Text);
        }

        [Test]
        public void button_minus_Click_DecreasesQuantity()
        {
            // Arrange
            var form = new Form1();
            var initialQuantity = 5;
            form.textBox_mennyiseg.Text = initialQuantity.ToString();

            // Act
            form.button_minus_Click(null, null);

            // Assert
            var expectedQuantity = initialQuantity - 1;
            Assert.AreEqual(expectedQuantity.ToString(), form.textBox_mennyiseg.Text);
        }

        [Test]
        public void Test_ProductList_LoadsCorrectly()
        {
            // Arrange
            var form = new ApiSample.Form1();

            // Act - Az adatkötés miatt a ListBox-nak van DataSource-je
            var dataSource = form.listBox1.DataSource;

            // Assert
            Assert.IsNotNull(dataSource, "A terméklista adatforrása nem lehet null.");
            Assert.IsTrue(form.listBox1.Items.Count > 0, "A ListBox-ban nincsenek megjelenített elemek.");
        }

        [Test]
        public void TestInventoryIdInitialization()
        {
            // Arrange
            string expectedInventoryId = "ba5790e5-a252-4fcc-885e-4918f07c6c20";

            // Act
            Termek termek = new Termek();
            termek.inventory_id = expectedInventoryId;

            // Assert
            Assert.AreEqual(expectedInventoryId, termek.inventory_id);
        }

        [Test]
        public void TestInventoryIdIsNullWhenNotSet()
        {
            // Arrange
            Termek termek = new Termek();

            // Assert
            Assert.IsNull(termek.inventory_id);
        }

        [Test]
        public void TestInventoryIdCanBeChanged()
        {
            // Arrange
            Termek termek = new Termek();
            termek.inventory_id = "initial_inventory_id";
            string expectedInventoryId = "new_inventory_id";

            // Act
            termek.inventory_id = expectedInventoryId;

            // Assert
            Assert.AreEqual(expectedInventoryId, termek.inventory_id);
        }

        [Test]
        public void TestInventoryIsZeroByDefault()
        {
            // Arrange
            Termek termek = new Termek();

            // Assert
            Assert.AreEqual(0, termek.keszlet);
        }

        [Test]
        public void TestInventorySetCorrectly()
        {
            // Arrange
            Termek termek = new Termek();
            int expectedInventory = 10;

            // Act
            termek.keszlet = expectedInventory;

            // Assert
            Assert.AreEqual(expectedInventory, termek.keszlet);
        }

        [Test]
        public void TestProductNameCannotBeEmpty()
        {
            // Arrange
            Termek termek = new Termek();
            string invalidProductName = "";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => termek.nev = invalidProductName);
        }

        [Test]
        public void TestProductNameMaxLength()
        {
            // Arrange
            Termek termek = new Termek();
            string longProductName = new string('A', 10000); // A hosszabb mint a megengedett 255 karakter

            // Act & Assert
            Assert.Throws<ArgumentException>(() => termek.nev = longProductName);
        }

        [Test]
        public void TestProductNameSpecialCharacters()
        {
            // Arrange
            Termek termek = new Termek();
            string productNameWithSpecialCharacters = "Example Product #123";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => termek.nev = productNameWithSpecialCharacters);
        }

        




        /*[Test]
        public void button_mentes_Click_UpdatesQuantity()
        {
            // Arrange
            var form = new Form1();
            var initialQuantity = 5;
            form.textBox_mennyiseg.Text = initialQuantity.ToString();
            var selectedProductIndex = 0; // Assuming the first product is selected

            // Act
            form.listBox1.SelectedIndex = selectedProductIndex;
            form.button_mentes_Click(null, null);

            // Assert
            var expectedQuantity = int.Parse(form.textBox_mennyiseg.Text);
            Assert.AreEqual(expectedQuantity, form.termeklista[selectedProductIndex].keszlet);
        }

        [Test]
        public void button_megse_Click_RestoresOriginalQuantity()
        {
            // Arrange
            var form = new Form1();
            var initialQuantity = 5;
            form.textBox_mennyiseg.Text = initialQuantity.ToString();
            var selectedProductIndex = 0; // Assuming the first product is selected

            // Act
            form.listBox1.SelectedIndex = selectedProductIndex;
            form.button_megse_Click(null, null);

            // Assert
            var expectedQuantity = initialQuantity;
            Assert.AreEqual(expectedQuantity.ToString(), form.textBox_mennyiseg.Text);
        }*/

    }
}
