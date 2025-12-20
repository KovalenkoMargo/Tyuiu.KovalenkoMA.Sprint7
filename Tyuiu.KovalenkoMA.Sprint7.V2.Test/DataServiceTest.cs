using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KovalenkoMA.Sprint7.V2.Lib;

namespace Tyuiu.KovalenkoMA.Sprint7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private string testFilePath = @"C:\Users\Марго\source\repos\Tyuiu.KovalenkoMA.Sprint7\Owners.csv";

        [TestMethod]
        public void TestLoadFromFile_CheckFileExists()
        {
            DataService ds = new DataService();

            try
            {
                var result = ds.LoadFromFile(testFilePath);
                Assert.IsNotNull(result, "Результат загрузки не должен быть null");
                Assert.AreEqual(10, result.Count, "Должно быть 10 записей в файле");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Ошибка загрузки файла: {ex.Message}");
            }
        }

        [TestMethod]
        public void TestLoadFromFile_CheckFirstRecord()
        {
            DataService ds = new DataService();
            var result = ds.LoadFromFile(testFilePath);

            Assert.AreEqual(1, result[0].Id, "ID первой записи должен быть 1");
            Assert.AreEqual("Иванов Иван Иванович", result[0].FullName, "Неверное ФИО");
            Assert.AreEqual("Москва,ул.Ленина 10", result[0].Address, "Неверный адрес");
            Assert.AreEqual("+79991234567", result[0].Phone, "Неверный телефон");
            Assert.AreEqual(1500000m, result[0].Capital, "Неверный капитал");
        }
        [TestMethod]
        public void TestSaveToFile_RoundTrip()
        {
            DataService ds = new DataService();
            var originalData = ds.LoadFromFile(testFilePath);
            string tempFile = "TestTemp.csv";

            ds.SaveToFile(tempFile, originalData);
            var loadedData = ds.LoadFromFile(tempFile);
            Assert.AreEqual(originalData.Count, loadedData.Count, "Количество записей не совпадает после сохранения/загрузки");

            for (int i = 0; i < originalData.Count; i++)
            {
                Assert.AreEqual(originalData[i].Id, loadedData[i].Id, $"Не совпадает ID записи {i}");
                Assert.AreEqual(originalData[i].FullName, loadedData[i].FullName,
                    $"Не совпадает ФИО записи {i}");
                Assert.AreEqual(originalData[i].Capital, loadedData[i].Capital,
                    $"Не совпадает капитал записи {i}");
            }

            System.IO.File.Delete(tempFile);
        }
    }
}
