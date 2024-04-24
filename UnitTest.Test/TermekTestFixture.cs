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
using Moq;

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

        public interface IInventoryRepository
        {
            bool CheckInventoryIdExists(string inventoryId);
        }

        public class Termekek
        {
            private readonly IInventoryRepository _inventoryRepository;

            public Termekek(IInventoryRepository inventoryRepository)
            {
                _inventoryRepository = inventoryRepository;
            }

            public bool CheckInventoryIdExists(string inventoryId)
            {
                return _inventoryRepository.CheckInventoryIdExists(inventoryId);
            }
        }

        public class MockInventoryRepository : IInventoryRepository
        {
            public bool CheckInventoryIdExists(string inventoryId)
            {
                // Itt a mock működését implementálhatod, például mindig igazat adhatsz vissza
                return true;
            }
        }

        [Test]
        public void TestCheckInventoryIdExists()
        {
            // Arrange
            var mockRepository = new MockInventoryRepository();
            var termek = new Termekek(mockRepository);
            string inventoryId = "ba5790e5-a252-4fcc-885e-4918f07c6c20";

            // Act
            bool exists = termek.CheckInventoryIdExists(inventoryId);

            // Assert
            Assert.IsTrue(exists);
        }


        [Test]
        public void TestTartalmazSpeciálisKaraktereket_Tartalmaz()
        {
            // Arrange
            Termek termek = new Termek { nev = "Termék (speciális karakterekkel)" };

            // Act
            bool eredmény = termek.TartalmazSpeciálisKaraktereket();

            // Assert
            Assert.IsTrue(eredmény);
        }




    }


}
