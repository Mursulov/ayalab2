using System;
using Xunit;
using HomeworkLib;
using System.IO;

namespace HomeworkLib.Tests
{
    public class DocumentWorkerTests
    {
        [Fact]
        public void DocumentWorker_BaseEdition()
        {
            var dw = new DocumentWorker();
            using var sw = new StringWriter();
            Console.SetOut(sw);
            dw.OpenDocument(); dw.EditDocument(); dw.SaveDocument();
            var output = sw.ToString();
            Assert.Contains("Документ открыт", output);
            Assert.Contains("Редактирование документа доступно в версии Pro", output);
            Assert.Contains("Сохранение документа доступно в версии Pro", output);
        }

        [Fact]
        public void ProDocumentWorker_Edition()
        {
            var dw = new ProDocumentWorker();
            using var sw = new StringWriter();
            Console.SetOut(sw);
            dw.OpenDocument(); dw.EditDocument(); dw.SaveDocument();
            var output = sw.ToString();
            Assert.Contains("Документ отредактирован", output);
            Assert.Contains("Документ сохранен в старом формате", output);
        }

        [Fact]
        public void ExpertDocumentWorker_Edition()
        {
            var dw = new ExpertDocumentWorker();
            using var sw = new StringWriter();
            Console.SetOut(sw);
            dw.OpenDocument(); dw.EditDocument(); dw.SaveDocument();
            var output = sw.ToString();
            Assert.Contains("Документ сохранен в новом формате", output);
        }
    }
}
