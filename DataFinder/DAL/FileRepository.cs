﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFinder.DAL
{
    public class FileRepository
    {
        private IEnumerable<FileEntity> files { get; }

        public FileRepository()
        {
            files = new List<FileEntity>()
            {
                new FileEntity(Guid.NewGuid(), "Реферат.docx", "C:/Desktop/Docs/Реферат.docx"),
                new FileEntity(Guid.NewGuid(), "Отчет.docx", "C:/Desktop/Docs/Отчет.docx"),
                new FileEntity(Guid.NewGuid(), "Книга1.xls", "C:/Desktop/Docs/Книга1.xls"),
                new FileEntity(Guid.NewGuid(), "Фото на документы.jpeg", "C:/Desktop/Docs/Фото на документы.jpeg"),
                new FileEntity(Guid.NewGuid(), "Ярлык.lnk", "C:/Desktop/Docs/Ярлык.lnk"),
            };
        }

        public IEnumerable<FileEntity> GetFilesByDirectory()
        {
            return this.files;
        }

        public FileEntity GetFileByFileName(string fileName)
        {
            return this.files.FirstOrDefault(file => file.Name == fileName);
        }
    }
}
