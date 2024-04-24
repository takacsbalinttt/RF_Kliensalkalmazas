using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSample;
using NUnit.Framework;

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
    }
}
