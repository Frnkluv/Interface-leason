﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_leason
{
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из файла";       // заглушка
        }
    }
}
