using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KovalenkoMA.Sprint7.V2.Lib;

namespace Tyuiu.KovalenkoMA.Sprint7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private readonly string testFilePath = @"Data\Owners.csv";

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
        public void TestLoadFromFile_CheckAllRecords()
        {
 
            DataService ds = new DataService();


            var result = ds.LoadFromFile(testFilePath);


            Assert.AreEqual(3, result.Count);

      
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual("Иванов Иван Иванович", result[0].FullName);
            Assert.AreEqual(1500000m, result[0].Capital);

            
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual("Петров Петр Петрович", result[1].FullName);
            Assert.AreEqual(850000m, result[1].Capital);

            
            Assert.AreEqual(3, result[2].Id);
            Assert.AreEqual("Сидорова Анна Сергеевна", result[2].FullName);
            Assert.AreEqual(3200000m, result[2].Capital);
        }

        [TestMethod]
        public void TestGetTotalCapital_SimpleCalculation()
        {
            
            DataService ds = new DataService();
            var owners = ds.LoadFromFile(testFilePath);

            
            decimal total = ds.GetTotalCapital(owners);

            
            decimal expected = 1500000m + 850000m + 3200000m;
            Assert.AreEqual(expected, total, "Неверная сумма капитала");
        }

        [TestMethod]
        public void TestGetAverageCapital_SimpleCalculation()
        {
            
            DataService ds = new DataService();
            var owners = ds.LoadFromFile(testFilePath);

            
            decimal average = ds.GetAverageCapital(owners);

            decimal expected = 5550000m / 3;
            Assert.AreEqual(expected, average, "Неверное среднее значение");
        }

        [TestMethod]
        public void TestGetCount_CheckRecordsNumber()
        {
           
            DataService ds = new DataService();
            var owners = ds.LoadFromFile(testFilePath);

            
            int count = ds.GetCount(owners);

            
            Assert.AreEqual(3, count, "Неверное количество записей");
        }

        [TestMethod]
        public void TestSaveToFile_RoundTrip()
        {
           
            DataService ds = new DataService();

            var originalData = ds.LoadFromFile(testFilePath);


            string tempFile = "TestTemp.csv";

           
            ds.SaveToFile(tempFile, originalData);

            var loadedData = ds.LoadFromFile(tempFile);

            Assert.AreEqual(originalData.Count, loadedData.Count,
                "Количество записей не совпадает после сохранения/загрузки");

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
