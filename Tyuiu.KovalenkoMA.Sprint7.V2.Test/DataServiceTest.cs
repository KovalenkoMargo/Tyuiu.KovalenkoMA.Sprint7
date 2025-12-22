using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KovalenkoMA.Sprint7.V2.Lib;
using static Tyuiu.KovalenkoMA.Sprint7.V2.Lib.DataService;

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

            if (!File.Exists(testFilePath))
            {
                Assert.Fail($"Файл не найден: {testFilePath}");
            }

            try
            {
                var result = ds.LoadFromFile(testFilePath);
                Assert.IsNotNull(result, "Результат загрузки не должен быть null");
                Assert.AreEqual(10, result.Length, "Должно быть 10 записей в файле");
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
            Assert.AreEqual("Москва ул.Ленина 10", result[0].Address, "Неверный адрес");
            Assert.AreEqual("+79991234567", result[0].Phone, "Неверный телефон");
            Assert.AreEqual(1500000m, result[0].Capital, "Неверный капитал");
        }
        [TestMethod]
        public void TestSaveToFile_RoundTrip()
        {
            DataService ds = new DataService();
            var originalData = ds.LoadFromFile(testFilePath);
            string tempFile = "TestTemp.csv";
            string errorMessage;

            bool saveResult = ds.SaveToFile(tempFile, originalData, out errorMessage);
            Assert.IsTrue(saveResult, "Сохранение должно завершиться успешно: " + errorMessage);
            var loadedData = ds.LoadFromFile(tempFile);
            Assert.AreEqual(originalData.Length, loadedData.Length, "Количество записей не совпадает после сохранения/загрузки");

            for (int i = 0; i < originalData.Length; i++)
            {
                Assert.AreEqual(originalData[i].Id, loadedData[i].Id, $"Не совпадает ID записи {i}");
                Assert.AreEqual(originalData[i].FullName, loadedData[i].FullName,
                    $"Не совпадает ФИО записи {i}");
                Assert.AreEqual(originalData[i].Capital, loadedData[i].Capital,
                    $"Не совпадает капитал записи {i}");
            }

            if (File.Exists(tempFile))
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void TestSearchOwners()
        {
            DataService ds = new DataService();
            var testOwners = new DataService.Owner[]
            {
        new DataService.Owner
        {
            Id = 1,
            FullName = "Иванов Иван Иванович",
            Address = "Москва, ул.Ленина 10",
            Phone = "+79991234567",
            Capital = 1500000
        },
        new DataService.Owner
        {
            Id = 2,
            FullName = "Петров Петр Петрович",
            Address = "Санкт-Петербург, Невский пр.25",
            Phone = "+78121234567",
            Capital = 850000
        },
        new DataService.Owner
        {
            Id = 3,
            FullName = "Сидорова Анна Сергеевна",
            Address = "Казань, ул.Баумана 15",
            Phone = "+78431234567",
            Capital = 3200000
        }
            };

            var result1 = ds.SearchOwners(testOwners, "Иванов", "FullName");
            Assert.AreEqual(1, result1.Length, "Должен найти 1 запись по 'Иванов'");
            Assert.AreEqual("Иванов Иван Иванович", result1[0].FullName, "Должен найти Иванова");

            var result2 = ds.SearchOwners(testOwners, "Москва", "Address");
            Assert.AreEqual(1, result2.Length, "Должен найти 1 запись с Москвой");
            Assert.AreEqual("Москва, ул.Ленина 10", result2[0].Address, "Должен найти московский адрес");

            var result3 = ds.SearchOwners(testOwners, "7812", "Phone");
            Assert.AreEqual(1, result3.Length, "Должен найти 1 запись по коду 7812");
            Assert.AreEqual("+78121234567", result3[0].Phone, "Должен найти питерский телефон");

            var result4 = ds.SearchOwners(testOwners, "", "FullName");
            Assert.AreEqual(3, result4.Length, "Пустой поиск должен вернуть все 3 записи");

            var result5 = ds.SearchOwners(testOwners, "Козлов", "FullName");
            Assert.AreEqual(0, result5.Length, "Поиск несуществующего должен вернуть 0 записей");

            var result6 = ds.SearchOwners(testOwners, "2", "Id");
            Assert.AreEqual(1, result6.Length, "Должен найти запись с ID 2");
            Assert.AreEqual(2, result6[0].Id, "Должен быть Петров с ID 2");
        }

        [TestMethod]
        public void TestStatisticsMethods()
        {
            DataService ds = new DataService();
            var testOwners = new DataService.Owner[]
            {
        new DataService.Owner { Id = 1, FullName = "Владелец 1", Address = "Адрес 1", Phone = "111", Capital = 100000 },
        new DataService.Owner { Id = 2, FullName = "Владелец 2", Address = "Адрес 2", Phone = "222", Capital = 200000 },
        new DataService.Owner { Id = 3, FullName = "Владелец 3", Address = "Адрес 3", Phone = "333", Capital = 300000 },
        new DataService.Owner { Id = 4, FullName = "Владелец 4", Address = "Адрес 4", Phone = "444", Capital = 400000 },
        new DataService.Owner { Id = 5, FullName = "Владелец 5", Address = "Адрес 5", Phone = "555", Capital = 500000 }
            };

            int count = ds.GetCount(testOwners);
            Assert.AreEqual(5, count, "Должно быть 5 записей");

            decimal total = ds.GetTotalCapital(testOwners);
            Assert.AreEqual(1500000m, total, "Сумма капиталов: 100к+200к+300к+400к+500к = 1.5 млн");

            decimal average = ds.GetAverageCapital(testOwners);
            Assert.AreEqual(300000m, average, "Средний капитал: 1.5 млн / 5 = 300к");

            decimal min = ds.GetMinCapital(testOwners);
            Assert.AreEqual(100000m, min, "Минимальный капитал должен быть 100к (Владелец 1)");

            decimal max = ds.GetMaxCapital(testOwners);
            Assert.AreEqual(500000m, max, "Максимальный капитал должен быть 500к (Владелец 5)");

            var emptyArray = new DataService.Owner[0];
            Assert.AreEqual(0, ds.GetCount(emptyArray), "Пустой массив: количество = 0");
            Assert.AreEqual(0m, ds.GetTotalCapital(emptyArray), "Пустой массив: сумма = 0");
            Assert.AreEqual(0m, ds.GetAverageCapital(emptyArray), "Пустой массив: среднее = 0");
            Assert.AreEqual(0m, ds.GetMinCapital(emptyArray), "Пустой массив: минимум = 0");
            Assert.AreEqual(0m, ds.GetMaxCapital(emptyArray), "Пустой массив: максимум = 0");
        }

        [TestMethod]
        public void TestFilterByCapitalRange()
        {
            DataService ds = new DataService();

            Owner[] testOwners = new Owner[]
            {
        new Owner { Id = 1, FullName = "Test1", Capital = 1000000 },
        new Owner { Id = 2, FullName = "Test2", Capital = 2000000 },
        new Owner { Id = 3, FullName = "Test3", Capital = 3000000 }
            };

            var result1 = ds.FilterByCapitalRange(testOwners, 1500000, 2500000);
            Assert.AreEqual(1, result1.Length, "Должен быть 1 владелец");
            Assert.AreEqual("Test2", result1[0].FullName);

            var result2 = ds.FilterByCapitalRange(testOwners, 2500000, 1500000);
            Assert.AreEqual(1, result2.Length, "Должен исправить min/max местами");

            var result3 = ds.FilterByCapitalRange(testOwners, 5000000, 6000000);
            Assert.AreEqual(0, result3.Length, "Должен вернуть пустой массив");

            var result4 = ds.FilterByCapitalRange(new Owner[0], 1000000, 2000000);
            Assert.AreEqual(0, result4.Length, "Для пустого массива - пустой результат");
        }
    }
}
